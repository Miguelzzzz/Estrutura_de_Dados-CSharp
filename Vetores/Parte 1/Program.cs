using System;

public class VetorInicio
{
    public static void Main(string[] args)
    {
        // Declara um vetor de tamanho especificado (começando do 0)
        string[] frutas = new string[6];
        
        // Atribui valores aos elementos do vetor
        frutas[0] = "Melancia";
        frutas[1] = "Kiwi";
        frutas[2] = "Jaca";
        frutas[3] = "Manga";
        frutas[4] = "Tomate";
        frutas[5] = "Banana";
        
        // Exibe todo o conteúdo do vetor, todos os valores
        Console.WriteLine("Frutas: " + string.Join(", ", frutas));

        // Exibi o conteúdo do vetor na tela usando interpolação
        Console.WriteLine ($"Fruta escolhida: {frutas[3]}");

        // Pula uma linha na exibição(cria uma linha em branco)
        Console.WriteLine();

        string[] series = new string[5];
        
        series[0] = "Flash";
        series[1] = "Game of Thrones";
        series[2] = "Avatar";
        series[3] = "Friends";
        series[4] = "The Office";
        
        Console.WriteLine("Séries: " + string.Join(", ", series));
        Console.WriteLine ($"Série escolhida: {series[4]}");
        Console.WriteLine();

        
        double[] precos = new double[5];
        
        precos[0] = 9.50;
        precos[1] = 997.90;
        precos[2] = 1.99;
        precos[3] = 13.50;
        precos[4] = 77.80;
        
        // string.Join É um método que junta os elementos de uma coleção em uma única string, separando-os por um delimitador que você especificar(Nesse caso é a ", ")
        // Select(p => p.ToString("F2")) é uma operação que percorre cada elemento do vetor precos e converte cada elemento em uma string formatada com duas casas decimais
        Console.WriteLine("Preços: " + string.Join(", ", precos.Select(p => p.ToString("F2"))));

        // :F2 Faz com que o preço seja exibido com duas casas decimais
        Console.WriteLine ($"Preço definido: {precos[4]:F2}");
        Console.WriteLine();

        string[] mercadoLivre = new string[5];
        mercadoLivre[0] = "Camiseta";
        mercadoLivre[1] = "Pneu";
        mercadoLivre[2] = "Ração";
        mercadoLivre[3] = "Produto Quimico";
        mercadoLivre[4] = "Motor";
        
        Console.WriteLine("Produtos do Mercado Livre: " + string.Join(", ", mercadoLivre));
        Console.WriteLine ($"Produto escolhido: {mercadoLivre[0]}");
        Console.WriteLine();

        // Exibe o conteudo especificado de varios vetores e exibe eles juntos usando interpolação
        Console.WriteLine($"Fruta: {frutas[4]}  Série: {series[1]}  Preço: {precos[3]:F2}  Produto: {mercadoLivre[2]}");
        
        Console.WriteLine();

        // Exibe o conteudo especificado de varios vetores e exibe eles juntos usando concatenação
        // O .ToString("F2") faz com que o preço seja exibido com duas casas decimais 
        Console.WriteLine("Fruta: " + frutas[2] + "  Série: " + series[0] + "  Preço: " + precos[4].ToString("F2") + "  Produto: " + mercadoLivre[4]);
        
        Console.ReadLine();
    }
}