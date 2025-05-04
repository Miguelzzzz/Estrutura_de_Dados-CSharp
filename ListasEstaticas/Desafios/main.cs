using System;
public class RefatorandoAtividade
{
    struct Comanda{
        public string Nome;
        public string Comida;
        public double PrecoComida;
        public string Bebida;
        public double PrecoBebida;  
    }

    static void Main(){
                
        const int TAMANHO_LISTA = 5; 

        Comanda[] cardapio = new Comanda[TAMANHO_LISTA];

        cardapio[0] = new Comanda { Nome = "Carlos", Comida = "Feijoada", PrecoComida = 25.00, Bebida = "Suco abacaxi", PrecoBebida = 5.50 };
        cardapio[1] = new Comanda { Nome = "Marcos", Comida = "Strogonoff", PrecoComida = 18.50, Bebida = "Suco Morango", PrecoBebida = 5.50 };
        cardapio[2] = new Comanda { Nome = "Leticia", Comida = "Lasanha", PrecoComida = 22.00, Bebida = "Agua", PrecoBebida = 2.50 };
        cardapio[3] = new Comanda { Nome = "Amanda", Comida = "Frango Assado", PrecoComida = 20.00, Bebida = "Refrigerante", PrecoBebida = 6.50 };
        cardapio[4] = new Comanda { Nome = "Edvaldo", Comida = "Peixe Grelhado", PrecoComida = 28.00, Bebida = "Batida de laranja", PrecoBebida = 9.50 };

        // Exibe o cardápio
        Console.WriteLine("Comanda do Almoço:");
        for (int i = 0; i < TAMANHO_LISTA; i++)
        {
            Console.WriteLine($"{i + 1}. {cardapio[i].Nome} / {cardapio[i].Comida}  - R$  {cardapio[i].PrecoComida:F2} / {cardapio[i].Bebida} - R$ {cardapio[i].PrecoBebida:F2}");
        }
    }
}