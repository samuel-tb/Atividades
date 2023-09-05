using System.Security.Cryptography;

namespace Churras
{
    internal class Program
    {
        static string[] carnes = new string[999];
        static string[] bebidas = new string[999];
        static int[] qtdc = new int[999];
        static int[] qtdb = new int[999];
        static decimal[] precoc = new decimal[999];
        static decimal[] precob = new decimal[999];
        static int i, i2, respc, respb, pessoas;
        static decimal resultadoc, resultadob;
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Churras!\n");
            int op=0;
            while (op != 4)
            {
                Console.WriteLine("|====== Escolha uma opção ======|");
                Console.WriteLine("|1 - Cadastrar Carnes.          |");
                Console.WriteLine("|2 - Cadastrar Bebidas.         |");
                Console.WriteLine("|3 - Ver valor por pessoa.      |");
                Console.WriteLine("|4 - Sair.                      |");
                Console.WriteLine("|===============================|");
                op = Convert.ToInt32(Console.ReadLine());
                switch(op)
                {
                    case 1:

                        Carne();
                        break;

                    case 2:

                        Bebida();
                        break;

                    case 3:

                        Valor();
                        break;

                    case 4:

                        Sair();
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

        private static void Carne()
        {
            Console.Clear();
            if (i == 0)
            {
                Console.Write("Quantas carnes deseja cadastrar ? ");
                respc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                for (i = 0; i < respc; i++)
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
            else
            {
                Console.WriteLine("Você já fez o cadastro das carnes.");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");       //pede para apertar qualquer tecla para voltar a menu
            Console.ReadKey();                                                                  //aperta qualquer tecla para continuar
            Console.Clear();

        }

        private static void Bebida()
        {
            Console.Clear();
            if (i2 == 0)
            {
                Console.Write("Quantas bebidas deseja cadastrar ? ");
                respb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                for (i2 = 0; i2 < respb; i2++)
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
            else
            {
                Console.WriteLine("Você já fez o cadastro das bebidas.");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");       //pede para apertar qualquer tecla para voltar a menu
            Console.ReadKey();                                                                  //aperta qualquer tecla para continuar
            Console.Clear();
        }

        private static void Valor()
        {
            Console.Clear();
            if (i == 0 && i2 ==0)
            {
                Console.WriteLine("Você ainda não fez o cadastro dos alimentos.");
            }
            else
            {
                Console.Write("Quantas pessoas iram no churras ? ");
                pessoas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("===================================");
                for (i = 0; i < respc; i++)
                {
                    resultadoc = (qtdc[i] * precoc[i]) / pessoas;
                    Console.WriteLine($"{carnes[i]}: R${resultadoc} por pessoa.");
                }
                for (i = 0; i < respb; i++)
                {
                    resultadob = (qtdb[i] * precob[i]) / pessoas;
                    Console.WriteLine($"{bebidas[i]}: R${resultadob} por pessoa.");
                }
                Console.WriteLine($"Total: R${resultadoc + resultadob} por pessoa.");
                Console.WriteLine("===================================");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu de opções.");       //pede para apertar qualquer tecla para voltar a menu
            Console.ReadKey();                                                                  //aperta qualquer tecla para continuar
            Console.Clear();
        }

        private static void Sair()
        {
            Console.Clear();                                                                                        //limpa tudo escrito antes
            Console.WriteLine("Encerrando o programa.");                                                            //fala que está encerrando o programa
            Console.WriteLine("Pressione qualquer tecla para encerrar.");                                           //pede para apertar qualquer tecla para encerrar o programa
            Console.ReadKey();
        }
    }
}