public class Estoque{
    Vinil[] vinis = new Vinil[0];


    public void Adicionar(Vinil vinil){

        Vinil[] novoVetor = new Vinil[vinis.Length + 1];

        for (int pos = 0; pos < vinis.Length; pos++)
        {
            Vinil item = vinis[pos];
            novoVetor[pos] = item;
                        
        }

        novoVetor[novoVetor.Length - 1] = vinil;

         vinis = novoVetor;

    }

    public void Listar(){

        int cont = 1;

        foreach (Vinil item in vinis){
            Console.WriteLine($"{cont}.Nome:{item.nome} / Valor(R$):{item.preco} / Artista:{item.artista} / Ano:{item.ano} / {item.estoque} no estoque");
            cont++;
            
        }


    }

    public void Entrada(int pos, int qtd){

        Vinil vinil = vinis[pos - 1];
        vinil.estoque += qtd;


    }

    public void Saida(int pos, int qtd){

        Vinil vinil = vinis[pos - 1];
        vinil.estoque -= qtd;

    }

    public void Remover(int pos){

        if(pos >= 1 && pos <= vinis.Length){
            Vinil[] novoVetor = new Vinil[vinis.Length -1];
            int novaPosicao = 0;

            for( int i = 0; i < vinis.Length; i++){
                if( i != pos -1){
                    novoVetor[novaPosicao] = vinis[i];
                    novaPosicao++;
                }
            }
            vinis = novoVetor;      
        }

        
        
        
 
    }

}
