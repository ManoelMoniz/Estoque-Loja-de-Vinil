namespace _1;

class Program
{
    static void Main(string[] args)
    {

        Estoque estoque = new Estoque();        


        int menu = 0;

        do{

            Console.WriteLine("[1]NOVO");
            Console.WriteLine("[2]LISTAR");
            Console.WriteLine("[3]REMOVER PRODUTOS");
            Console.WriteLine("[4]ENTRADA ESTOQUE");
            Console.WriteLine("[5]SAÍDA ESTOQUE");
            Console.WriteLine("[0]SAIR");
            menu = int.Parse(Console.ReadLine());

            if(menu == 1)
            {
                Vinil novovinil = new Vinil();

                Console.WriteLine("Nome do Albúm:");
                novovinil.nome = Console.ReadLine();

                Console.WriteLine("Preço:");
                novovinil.preco = int.Parse(Console.ReadLine());            
                
                Console.WriteLine("Gênero:");
                novovinil.genero = Console.ReadLine();

                Console.WriteLine("Artista:");
                novovinil.artista = Console.ReadLine();

                Console.WriteLine("Ano do albúm:");
                novovinil.ano = int.Parse(Console.ReadLine());

                estoque.Adicionar(novovinil);

            }

            else if(menu == 2)
            {
                Console.WriteLine("Itens no estoque:");
                estoque.Listar();
                
            }

            else if(menu == 3)
            {
                Console.WriteLine("Itens no estoque:");
                estoque.Listar();

                Console.WriteLine("Posição do item a ser removido:");
                int x = Convert.ToInt32(Console.ReadLine());

                estoque.Remover(x);          

                             
               
            }

            else if(menu == 4)
            {

                Console.WriteLine("Itens no estoque:");
                estoque.Listar();

                Console.WriteLine("Posição do Vinil:");
                int pos = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade de Entrada:");
                int qtd = int.Parse(Console.ReadLine());

                estoque.Entrada(pos, qtd); 

                
            }

            else if(menu == 5)
            {
                Console.WriteLine("Itens no estoque:");
                estoque.Listar();

                Console.WriteLine("Posição do Vinil:");
                int pos = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade de Saída:");
                int qtd = int.Parse(Console.ReadLine());


                estoque.Saida(pos, qtd);
                
            }

            

        }
        while(menu != 0); 
        
    }
      
}
