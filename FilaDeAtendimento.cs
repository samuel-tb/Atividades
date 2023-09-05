namespace Fila_de_Atendimento
{
    internal class Program
    {
        static Pessoa[] pessoas = new Pessoa[5];                            //transformar o struct em um array
        static int i;                                                       // variavel para fazer repetição

        static void Main(string[] args)
        {
            int op = 0;                                                             //variavel para escolher uma opção
            Console.WriteLine("Bem vindo a fila de atendimento.\n");                //mensagem do inicio
            while (op != 4)                                                         //estrutrutura de repetiçao para rodar o menu
            {
                Console.WriteLine("|============== MENU =============|");
                Console.WriteLine("|1 - Cadastrar pessoas.           |");           //opção 1
                Console.WriteLine("|2 - Listar a fila de atendimento.|");           //opção 2
                Console.WriteLine("|3 - Atendimento.                 |");           //opção 3
                Console.WriteLine("|4 - Sair.                        |");           //opção 4
                Console.WriteLine("|=================================|");
                Console.WriteLine("\nEscolha uma opção:");                          //mensagem para escolher uma opção        
                op = Convert.ToInt32(Console.ReadLine());                           //armazena o valor da opção selecionada
                switch (op)                                                         //armazena o valor da opção selecionada
                {
                    case 1:                     //caso escolha 1
                        Cadastrar();            //puxa a função "cadastrar"           
                        break;

                    case 2:                     //caso escolha 2            
                        Listar();               //puxa a função "listar"
                        break;

                    case 3:                     //caso escolha 3 
                        Atender();              //puxa a função "atender"
                        break;

                    case 4:                     //caso escolha 4
                        Sair();                 //puxa a função "sair"
                        break;

                    default:                    // caso escolha algo diferente de 1 ou 2 ou 3 ou 4             
                        Console.Clear();
                        Console.WriteLine("Essa opção não existe.");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");       //pede para apertar qualquer tecla para voltar a menu
                        Console.ReadKey();                                                                  //aperta qualquer tecla para continuar
                        Console.Clear();                                                                    //limpa tudo escrito antes
                        break;
                }
            }
        }

        private static void Cadastrar()                                         //função cadastrar 
        {
            if (i == 0)                                                         //se não foi as pessoas não foram cadastradas 
            {
                Console.Clear();                                                //limpa tudo escrito antes
                for (i = 0; i < pessoas.Length; i++)                            //estrutura de repetição para fazer o cadastro das 5 pessoas
                {
                    Console.Write($"Digite o nome da {i + 1}° pessoa: ");       //pergunta o nome da pessoa
                    pessoas[i].nome = Console.ReadLine()!;                      //salva o nome da pessoa 

                    Console.Write($"Digite o cpf do(a) {pessoas[i].nome}: ");   //pergunta o cpf    
                    pessoas[i].cpf = Console.ReadLine()!;                       //salva o cpf da pessoa

                    Console.Write($"Digite a senha  que corresponde o(a) {pessoas[i].nome}: ");     //pergunta a senha
                    pessoas[i].senha = Convert.ToInt32(Console.ReadLine());                         //salva a senha da pessoa

                    Console.WriteLine("");                                  //pula uma linha

                }
                Console.WriteLine("Cadastro concluído.");

            }

            else                                                                            //se as pessoas já foram cadastradas
            {
                Console.Clear();                                                            //limpa tudo escrito antes
                Console.WriteLine("Você já fez o cadastro das pessoas.");                   //fala que já fez o cadastro 
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");       //pede para apertar qualquer tecla para voltar a menu
            Console.ReadKey();                                                                  //aperta qualquer tecla para continuar              
            Console.Clear();                                                                    //limpa tudo escrito antes
        }

        private static void Listar()                                                    //função para listar as pessoas cadastradas                               
        {
            Console.Clear();                                                            //limpa tudo escrito antes
            if (i == 0)                                                                 //se as pessoas ainda não foram cadastradas
            {
                Console.WriteLine("Você ainda não cadastrou nenhuma pessoa.");          //fala que não foi cadastrado nenhuma pessoa
            }

            else                                                                        //se as pessoas já foram cadastradas 
            {
                SistemaFila();                                                          //puxa a função de organização da fila
                Console.WriteLine("======================== Lista de atendimento ========================\n");
                foreach (var item in pessoas)                                        //estrutura de repetição para citar a pessoas que foram cadastras
                {                                                                           //falando seu nome, cpf e senha
                    Console.WriteLine(" ----------------------------");
                    Console.WriteLine($" Nome: {item.nome}");                         //fala o nome
                    Console.WriteLine($" Cpf: {item.cpf}"); ;                         //fala o cpf da pessoa correspondente
                    Console.WriteLine($" Senha: {item.senha}");                       //fala a senha da pessoa correspondente
                    Console.WriteLine(" ----------------------------");
                    Console.WriteLine("");                                                  //pula uma linha
                }
                Console.WriteLine("======================================================================");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");       //pede para apertar qualquer tecla para voltar a menu
            Console.ReadKey();                                                                  //aperta qualquer tecla para continuar              
            Console.Clear();                                                                    //limpa tudo escrito antes
        }

        private static void Atender()                                                   //função para atender o clientes cadastrados
        {
            Console.Clear();                                                            //limpa tudo escrito antes
            if (i == 0)                                                                 //se as pessoas ainda não foram cadastradas
            {
                Console.WriteLine("Você ainda não cadastrou nenhuma pessoa.");          //fala que não foi cadastrado nenhuma pessoa
            }

            else                                                                        //se as pessoas já foram cadastradas 
            {
                SistemaFila();                                                          //puxa a função de organização da fila
                string resp;                                                            //variável para a resposta do usuário
                for (i = 0; i < pessoas.Length; i++)                                     //estrutura de repetição para fazer o atendimento da ordem das senhas 
                {
                    Console.WriteLine($"---------- Senha {pessoas[i].senha} - Sr(a).{pessoas[i].nome} ----------\n");            //fala a senha da pessoa e o seu nome
                    Console.WriteLine($"O que deseja Sr(a).{pessoas[i].nome}? ");                                   //pergunta oque a pessoa deseja
                    resp = Console.ReadLine()!;                                                                     //aloca a resposta do usuário
                    Console.WriteLine("\nObrigado. Tenha um bom dia :D");                                           //mensagem para aparecer depois da resposta do usuário
                    Console.WriteLine("\nPressione qualquer tecla para continuar.");                                //pede para apertar qualquer tecla para seguir para a próxima pessoa da fila
                    Console.ReadKey();                                                                              //aperta qualquer tecla para continuar              
                    Console.Clear();                                                                                //limpa tudo escrito antes
                }
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");                           //pede para apertar qualquer tecla para voltar a menu
            Console.ReadKey();                                                                                      //aperta qualquer tecla para continuar              
            Console.Clear();                                                                                        //limpa tudo escrito antes
        }

        private static void Sair()                                                                                  //função de encerrar o programa
        {
            Console.Clear();                                                                                        //limpa tudo escrito antes
            Console.WriteLine("Encerrando o programa.");                                                            //fala que está encerrando o programa
            Console.WriteLine("Pressione qualquer tecla para encerrar.");                                           //pede para apertar qualquer tecla para encerrar o programa
            Console.ReadKey();                                                                                      //aperta qualquer tecla para continuar              
            Console.Clear();                                                                                        //limpa tudo escrito antes
            Console.WriteLine("Obrigado por utilizar nosso atendimento. Volte sempre :D");                          //mensagem final
        }

        
        private static void SistemaFila()                                       //função para organizar as pessoas de acordo com sua senha
        {
            int aux;                                                            //variavies utilizadas
            string aux2, aux3;
            for (int y=0; y<4; y++)                                             //estrutura de repetição para organizar a senha
            {
                for (i = 0; i < 5-1; i++)                                         
                {
                    if (pessoas[i].senha > pessoas[i + 1].senha)                //se o atual numero for mais que o proximo
                    {
                        aux = pessoas[i+1].senha;                               //aux vira o proximo valor da senha
                        aux2 = pessoas[i + 1].cpf;                              //aux2 vira o proximo valor do cpf
                        aux3 = pessoas[i + 1].nome;                             //aux3 vira o proximo valor do nome

                        pessoas[i + 1].senha = pessoas[i].senha;                //o proximo valor da senha vira o atual
                        pessoas[i + 1].cpf = pessoas[i].cpf;                    //o proximo valor do cpf vira o atual
                        pessoas[i + 1].nome = pessoas[i].nome;                  //o proximo valor do nome vira o atual

                        pessoas[i].senha = aux;                                 //o atual valor da senha vira aux
                        pessoas[i].cpf = aux2;                                  //o atual valor do cpf vira aux2
                        pessoas[i].nome = aux3;                                 //o atual valor do nome vira aux3
                    }
                }
            }
        }
        
        
        
        
        public struct Pessoa                                                                                    //estrutura para alocar variaveis 
        {
            public string nome;                                                                                 //variavel para alocar o nome
            public string cpf;                                                                                  //variavel para alocar o cpf
            public int senha;

        }
    }
}
