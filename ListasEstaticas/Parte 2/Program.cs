using System;
public class DesafioListas
{
    public static void Main(string[] args)
    {
        // Lista do café da manhã
        
        string[] CafeManha = new string [5];

        CafeManha [0] = "Café";
        CafeManha [1] = "Cereais";
        CafeManha [2] = "Achocolatado";
        CafeManha [3] = "Pão";
        CafeManha [4] = "Suco";

        Console.WriteLine("Lista do café da manhã:");
        Console.WriteLine($"Item 1: {CafeManha[0]}");
        Console.WriteLine($"Item 2: {CafeManha[1]}");
        Console.WriteLine($"Item 3: {CafeManha[2]}");
        Console.WriteLine($"Item 4: {CafeManha[3]}");
        Console.WriteLine($"Item 5: {CafeManha[4]}");
        Console.WriteLine();

        // Lista dos preços do café da manhã
        double[] PrecoCafe = new double [5];

        PrecoCafe [0] = 1.50;
        PrecoCafe [1] = 4.30;
        PrecoCafe [2] = 3.50;
        PrecoCafe [3] = 7.00;
        PrecoCafe [4] = 5.00;

        Console.WriteLine("Lista dos Preços do café da manhã:");
        foreach(double itens in PrecoCafe) Console.WriteLine(itens.ToString("F2"));
        Console.WriteLine();

        // Lista do almoço
        string[] Almoco = new string [5];

        Almoco [0] = "Prato 1";
        Almoco [1] = "Prato 2";
        Almoco [2] = "Prato 3";
        Almoco [3] = "Prato 4";
        Almoco [4] = "Prato 5";

        Console.WriteLine("Lista do almoço:");
        foreach(string itens in Almoco) Console.WriteLine(itens);
        Console.WriteLine();
        
        // Lista dos preços do almoço
        double[] PrecoAlmoco = new double [5];

        PrecoAlmoco [0] = 25.00;
        PrecoAlmoco [1] = 26.00;
        PrecoAlmoco [2] = 30.00;
        PrecoAlmoco [3] = 22.00;
        PrecoAlmoco [4] = 25.00;

        Console.WriteLine("Lista dos preços do almoço:");
        foreach(double itens in PrecoAlmoco) Console.WriteLine(itens.ToString("F2"));
        Console.WriteLine();

        // Lista dos compradores
        string[] Compradores = new string [5];

        Compradores [0] = "Comprador 1";
        Compradores [1] = "Comprador 2";
        Compradores [2] = "Comprador 3";
        Compradores [3] = "Comprador 4";
        Compradores [4] = "Comprador 5";

        Console.WriteLine("Lista dos compradores:");
        foreach(string itens in Compradores) Console.WriteLine(itens);
    }
}