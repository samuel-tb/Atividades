namespace churras
{
    internal class Program
    {
        static string[] carnes = new string[999];                                                        //variaveis 
        static string[] bebidas = new string[999];
        static int[] qtdc = new int[999];
        static int[] qtdb = new int[999];
        static decimal[] precoc = new decimal[999];
        static decimal[] precob = new decimal[999];
        static int i, i2, respc, respb, pessoas;
        static decimal resultadoc, resultadob;
        static decimal[] rc = new decimal[999];
        static decimal[] rb = new decimal[999];
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Churras!\n");
            int op = 0;
            while (op != 4)                                                                    //variavel para escolher opção
            {
                Console.WriteLine("|====== Escolha uma opção ======|");                        //opções
                Console.WriteLine("|1 - Cadastrar Carnes.          |");
                Console.WriteLine("|2 - Cadastrar Bebidas.         |");
                Console.WriteLine("|3 - Ver valor por pessoa.      |");
                Console.WriteLine("|4 - Sair.                      |");
                Console.WriteLine("|===============================|");
                op = Convert.ToInt32(Console.ReadLine());                                    //salva o valor da variavel
                switch (op)
                {
                    case 1:                                                    //caso escolha 1

                        Carne();                                               //puxa a função de cadastrar carnes
                        break;

                    case 2:                                                    //caso escolha 2

                        Bebida();                                              //puxa a função de cadastrar bebidas
                        break;

                    case 3:                                                    //caso escolha 3

                        Valor();                                               //puxa a função de mostrar o valor por pessoa
                        break;

                    case 4:                                                    //caso escolha 4

                        Sair();                                                //puxa a função de sair do programa
                        break;

                    default:

                        Console.Clear();                                                                    //limpa tudo escrito antes
                        Console.WriteLine("Essa opção não existe.");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");       //pede para apertar qualquer tecla para voltar a menu
                        Console.ReadKey();                                                                  //aperta qualquer tecla para continuar
                        Console.Clear();                                                                    //limpa tudo escrito antes
                        break;

                }
            }
        }

        private static void Carne()                                                    //função de cadastrar carnes
        {
            Console.Clear();                                                           //limpa tudo escrito antes
            if (i == 0)                                                                //se não estiver cadastrado nenhuma carne
            {
                Console.Write("Quantas carnes deseja cadastrar (max. 17) ? ");
                respc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                for (i = 0; i < respc; i++)                                            //estrutrura de repetição para cadastrar a carne
                {
                    Console.Write($"Digite o nome da {i + 1}° carne: ");
                    carnes[i] = Console.ReadLine()!;
                    Console.Write($"Digite o valor por kg de {carnes[i]}: ");
                    precoc[i] = Convert.ToDecimal(Console.ReadLine());
                    Console.Write($"Digite quantos kg de {carnes[i]}: ");
                    qtdc[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                }
                Console.WriteLine("Cadastro de carnes concluido.");
            }
            else                                                                        //se já estiver cadastrado as carnes
            {
                Console.WriteLine("Você já fez o cadastro das carnes.");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");       //pede para apertar qualquer tecla para voltar a menu
            Console.ReadKey();                                                                  //aperta qualquer tecla para continuar
            Console.Clear();

        }

        private static void Bebida()                                                    //função de cadastrar bebidas
        {
            Console.Clear();
            if (i2 == 0)                                                                //se não estiver cadastrado as bebidas
            {
                Console.Write("Quantas bebidas deseja cadastrar  (max. 17)? ");
                respb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                for (i2 = 0; i2 < respb; i2++)                                            //estrutura de repetição para cadastrar as bebidas
                {
                    Console.Write($"Digite o nome da {i2 + 1}° bebida: ");
                    bebidas[i2] = Console.ReadLine()!;
                    Console.Write($"Digite o valor da(o) {bebidas[i2]}: ");
                    precob[i2] = Convert.ToDecimal(Console.ReadLine());
                    Console.Write($"Digite a quantidade de {bebidas[i2]}: ");
                    qtdb[i2] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                }
                Console.WriteLine("Cadastro de bebidas concluido.");                        
            }
            else                                                                            //se já estiver cadastrado as bebidas
            {
                Console.WriteLine("Você já fez o cadastro das bebidas.");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");       //pede para apertar qualquer tecla para voltar a menu
            Console.ReadKey();                                                                  //aperta qualquer tecla para continuar
            Console.Clear();
        }

        private static void Valor()                                                                        //função pra calcular valor por pessoa
        {
            Console.Clear();                                                                            
            if (i == 0 && i2 == 0)                                                                        //se não estiver cadastrados os alimentos
            {
                Console.WriteLine("Você ainda não fez o cadastro dos alimentos.");
            }
            else                                                                                            //se estiver cadastrados os alimentos
            {    
                Console.Write("Quantas pessoas irão no churras ? ");                                        //cadastra quantas pessoas vão no churrasco
                pessoas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("===================================");
                for (i = 0; i < respc; i++)                                                                 //estrutura de repetição para mostrar as carnes cadastradas e o valor por pessoa
                {
                    rc[i] = (qtdc[i] * precoc[i]) / pessoas;
                    


                    Console.WriteLine($"{carnes[i]}: R${rc[i]} por pessoa.");                                 
                }
                for (i = 0; i < respb; i++)                                                                  //estrutura de repetição para mostrar as bebidas cadastradas e o valor por pessoa                                                              
                {
                    rb[i] = (qtdb[i] * precob[i])/pessoas;
                    
                    
                   
                    Console.WriteLine($"{bebidas[i]}: R${rb[i]} por pessoa.");
                }
                Console.WriteLine("");
                resultadoc = rc[0] + rc[1] + rc[2] + rc[3] + rc[4] + rc[5] + rc[6] + rc[7] + rc[8] + rc[9] + rc[10] + rc[11] + rc[12] + rc[13] + rc[14] + rc[15] + rc[16] + rc[17];                //soma os valores das carnes
                resultadob = rb[0] + rb[1] + rb[2] + rb[3] + rb[4] + rb[5] + rb[6] + rb[7] + rb[8] + rb[9] + rb[10] + rb[11] + rb[12] + rb[13] + rb[14] + rb[15] + rb[16] + rb[17];                //soma os valores das bebidas
                Console.WriteLine($"Total: R${resultadob+resultadoc}.");        //fala o valor total de carnes e bebidas somadas
                Console.WriteLine("===================================");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu de opções.");       //pede para apertar qualquer tecla para voltar a menu
            Console.ReadKey();                                                                  //aperta qualquer tecla para continuar
            Console.Clear();
        }

        private static void Sair()                                                                                  //função de sair
        {
            Console.Clear();                                                                                        //limpa tudo escrito antes
            Console.WriteLine("Encerrando o programa.");                                                            //fala que está encerrando o programa
            Console.WriteLine("Pressione qualquer tecla para encerrar.");                                           //pede para apertar qualquer tecla para encerrar o programa
            Console.ReadKey();
        }
    }
}
