using System;

public class MatrizInicio
{
    public static void Main(string[] args)
    {
        int[,] matriz = new int[3,3]{
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        
        Console.WriteLine("Valores na linha 0: {" + matriz[0,0] + ", " + matriz[0,1] + ", " + matriz[0,2] + "}");
        Console.WriteLine("Valores na linha 1: {" + matriz[1,0] + ", " + matriz[1,1] + ", " + matriz[1,2] + "}");
        Console.WriteLine("Valores na linha 2: {" + matriz[2,0] + ", " + matriz[2,1] + ", " + matriz[2,2] + "}");
    }
}
