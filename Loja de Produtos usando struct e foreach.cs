namespace Loja_de_Produtos_com_Struct
{
    internal class Program
    {                                                           
        static int i;                                                   //variavel usada para repetição        
        static Produto[] produtos = new Produto[5];                     //convertendo a estrutura em um array
        static void Main(string[] args)
        {
           
            Console.WriteLine("Bem vindo a sua loja:\n ");
            int op = 0;                                          //variavel para selecionar uma das opções
            while (op != 3)                                     //estrutura de repetição para chamar o menu quando a opção for diferente de 3
            {

                Console.WriteLine("|---------MENU----------|");             //menu de opções 
                Console.WriteLine("|1- Cadastrar Produtos. |");             //opção 1
                Console.WriteLine("|2- Lista Produtos.     |");             //opção 2
                Console.WriteLine("|3- Sair.               |");             //opção 3
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("\nEscolha uma opção:");                  //pede para escolher uma das opções acima
                op = Convert.ToInt32(Console.ReadLine());                   //leitura da variavel das opções
                switch (op)
                {
                    case 1:                         //caso escolha 1
                        Cadastro();                 //chama a função do cadastro
                        break;

                    case 2:                         //caso escolha 2
                        Listar();                   //chama a função da lista
                        break;

                    case 3:                         //caso escolha 3
                        Sair();                     //chama a função de sair
                        break;

                    default:                        //caso escolha um número diferente de 1 ou 2 ou 3
                        Console.Clear();
                        Console.WriteLine("Essa opção não existe.");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");
                        Console.ReadKey();                                                              //apertar qualquer tecla para continuar
                        Console.Clear();                                                                //limpa oque foi escrito antes 
                        break;


                }

            }
        }
        private static void Cadastro()                                              //função do cadastro 
        {

            if (i == 0)                                                             //se ainda não cadastrou os produtos
            {
                Console.Clear();                                                    //limpa oque foi escrito antes 
                for (i = 0; i < produtos.Length; i++)                               //estrutura de repetição para perguntar o nome, preço, quantidade e o código do produto
                {
                    Console.Write($"Digite o nome do {i + 1}° produto: ");                      //pede para digitar o nome do produto
                    produtos[i].nome = Console.ReadLine()!;                                     //recebe o nome do produto
                    
                    Console.Write($"Digite o valor do(a) {produtos[i].nome} (ex:0,00): ");           //pede para digitar o preço do produto
                    produtos[i].preco = Convert.ToDecimal(Console.ReadLine());                       //recebe o preço do produto mencinado acima
                    
                    Console.Write($"Digite a quantidade no estoque do(a) {produtos[i].nome}: ");     //pede para digitar a quantidade desse mesmo produto que ele quer no estoque
                    produtos[i].qtd = Convert.ToInt32(Console.ReadLine());                           //recebe o valor da quantidade do produto que ele quer no estoque
                    
                    Console.Write($"Digite o código de barra do {produtos[i].nome}: ");              //pergunta qual o código do produto mencionado acima
                    produtos[i].cod = Console.ReadLine()!;                                           //recebe o valor do código do produto mencionado acima
                    
                    Console.WriteLine("");                                                      //pula uma linha

                }
                Console.WriteLine("Cadastro concluído.");

            }
            else                                                                //se os produtos já foram cadastrados
            {
                Console.Clear();                                                //limpa oque foi escrito antes 
                Console.WriteLine("Você já fez o cadastro dos produtos.");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();                                                                      //apertar qualquer tecla para continuar
            Console.Clear();                                                                        //limpa oque foi escrito antes
        }

        private static void Listar()                                                   //função para a lista de produtos
        {
            Console.Clear();                                                           //limpa oque foi escrito antes
            if (i == 0)                                                                //se ainda não cadastrou os produtos
            {
                Console.WriteLine("Você ainda não cadastrou nenhum produto.");         //fala que os produtos ainda não foram cadastrados
            }
            else                                                                       //se os produtos já foram cadastrados
            {

                Console.WriteLine("----------------------------------------Lista de itens------------------------------------------");
                foreach (var item in produtos)                                             //estrutura para listar os produtos cadastrados anteriormente
                {
                    Console.WriteLine($"- {item.qtd} und de {item.nome} - R${item.preco} por unidade - Total: {item.qtd} x {item.preco} = R${item.qtd*item.preco} - Codigo de barra: {item.cod}.");
                }
                Console.WriteLine("------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();                                                                   //apertar qualquer tecla para continuar
            Console.Clear();                                                                    //limpa oque foi escrito antes    
        }
        private static void Sair()                                                              //função para sair 
        {
            Console.Clear();                                                                    //limpa oque foi escrito antes
            Console.WriteLine("Encerrando o programa.");
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();                                                                  //finaliza o programa
            Console.Clear();                                                                    //limpa oque foi escrito antes
            Console.WriteLine("Obrigado por utilizar nossa loja, VOLTE SEMPRE :D");             //mensagem final
        }
        public struct Produto                                                               //estrura para agrupurar varias variaveis 
        {
            public string nome;                                                             //variavel do nome do produto
            public decimal preco;                                                           //variavel do preco do produto
            public int qtd;                                                                 //variavel da quantidade do produto
            public string cod;                                                              //variavel do codigo do produto

        }
    }
}