using System;

public class MatrizInicio
{
    public static void Main(string[] args)
    {
        // Declara uma Matriz de 3x3 com valores inteiros
        int[,] matriz = new int[3,3]{
            // Declarando os valores de cada bloco da Matriz, separados pela "," que foi declarada acima
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        
        // Imprime os valores de cada bloco da Matriz, [x,y] o primeiro valor é a linha e o segundo coluna
        Console.WriteLine("Valores na linha 0: {" + matriz[0,0] + ", " + matriz[0,1] + ", " + matriz[0,2] + "}");
        Console.WriteLine("Valores na linha 1: {" + matriz[1,0] + ", " + matriz[1,1] + ", " + matriz[1,2] + "}");
        Console.WriteLine("Valores na linha 2: {" + matriz[2,0] + ", " + matriz[2,1] + ", " + matriz[2,2] + "}");
    }
}
