using System;
public class IntroducaoListas
{
    // Definição de uma estrutura chamada "Prato", que representa um item do cardápio
    struct Prato{
            public string Nome;
            public double Preco;
        }
    public static void Main(string[] args){

        // Constante que define um tamanho para lista
        const int TAMANHO_LISTA = 5;

        // Criação de um vetor do tipo "Prato" com 5 posições
        Prato[] cardapio = new Prato[TAMANHO_LISTA];

        // Atribuição de valores nome e preco para cada Prato
        cardapio[0] = new Prato {Nome = "Feijoada", Preco = 25.00};
        cardapio[1] = new Prato {Nome = "Strogonoff", Preco = 18.50};
        cardapio[2] = new Prato {Nome = "Lasanha", Preco = 22.00};
        cardapio[3] = new Prato {Nome = "Frango Assado", Preco = 20.00};
        cardapio[4] = new Prato {Nome = "Peixe Grelhado", Preco = 29.00};

        // Impressão da mensagem
        Console.WriteLine("Cardápio de Almoço: ");

        // Laço para percorrer o vetor e imprimir os pratos e seus preços
        for(int aux = 0; aux < TAMANHO_LISTA; aux++){
            // Impressão e formatação dos valores
            Console.WriteLine($"{aux + 1}. {cardapio[aux].Nome} - R$ {cardapio[aux].Preco:F2}");
        }
    }
}