using System;
public class DesafioMatrizes
{
    public static void Main(string[] args)
    {
        // Crie um programa em C# que declare uma matriz 8x8 de numeros inteiros. O programa deve preencher os quadrados coloridos da matriz com o valor 1 e o restante da matriz com o valor 0. Apos o preencher a matriz o programa deve exibir a matriz ciompleta na tela;

        // Declaração das matrizes e seus valores respectivos de cada bloco
        int[,] matrizUm = new int[8,8]{
            {1,1,1,1,1,1,1,1},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0}
        };

        int[,] matrizDois = new int[8,8]{
            {1,0,0,0,0,0,0,0},
            {1,0,0,0,0,0,0,0},
            {1,0,0,0,0,0,0,0},
            {1,0,0,0,0,0,0,0},
            {1,0,0,0,0,0,0,0},
            {1,0,0,0,0,0,0,0},
            {1,0,0,0,0,0,0,0},
            {1,0,0,0,0,0,0,0}
        };

        int[,] matrizTres = new int[8,8]{
            {1,0,0,0,0,0,0,0},
            {0,1,0,0,0,0,0,0},
            {0,0,1,0,0,0,0,0},
            {0,0,0,1,0,0,0,0},
            {0,0,0,0,1,0,0,0},
            {0,0,0,0,0,1,0,0},
            {0,0,0,0,0,0,1,0},
            {0,0,0,0,0,0,0,1}
        };

        int[,] matrizQuatro = new int[8,8]{
            {1,1,1,1,1,1,1,1},
            {1,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1}
        };

        int[,] matrizCinco = new int[8,8]{
            {1,1,1,1,1,1,1,1},
            {1,1,0,0,0,0,0,0},
            {1,0,1,0,0,0,0,0},
            {1,0,0,1,0,0,0,0},
            {1,0,0,0,1,0,0,0},
            {1,0,0,0,0,1,0,0},
            {1,0,0,0,0,0,1,0},
            {1,0,0,0,0,0,0,1}
        };

        int[,] matrizSeis = new int[8,8]{
            {1,0,0,0,0,0,0,1},
            {0,1,0,0,0,0,1,0},
            {0,0,1,0,0,1,0,0},
            {0,0,0,1,1,0,0,0},
            {0,0,0,1,1,0,0,0},
            {0,0,1,0,0,1,0,0},
            {0,1,0,0,0,0,1,0},
            {1,0,0,0,0,0,0,1}
        };

        // Impressão manual dos valores
        // Console.WriteLine("Valores na linha 0: {" + matrizUm[0,0] + ", " + matrizUm[0,1] + ", " + matrizUm[0,2] + ", " + matrizUm[0,3] + ", " + matrizUm[0,4] + ", " + matrizUm[0,5] + ", " + matrizUm[0,6] + ", " + matrizUm[0,7] + "}");
        // Console.WriteLine("Valores na linha 1: {" + matrizUm[1,0] + ", " + matrizUm[1,1] + ", " + matrizUm[1,2] + ", " + matrizUm[1,3] + ", " + matrizUm[1,4] + ", " + matrizUm[1,5] + ", " + matrizUm[1,6] + ", " + matrizUm[1,7] + "}");
        // Console.WriteLine("Valores na linha 2: {" + matrizUm[2,0] + ", " + matrizUm[2,1] + ", " + matrizUm[2,2] + ", " + matrizUm[2,3] + ", " + matrizUm[2,4] + ", " + matrizUm[2,5] + ", " + matrizUm[2,6] + ", " + matrizUm[2,7] + "}");
        // Console.WriteLine("Valores na linha 3: {" + matrizUm[3,0] + ", " + matrizUm[3,1] + ", " + matrizUm[3,2] + ", " + matrizUm[3,3] + ", " + matrizUm[3,4] + ", " + matrizUm[3,5] + ", " + matrizUm[3,6] + ", " + matrizUm[3,7] + "}");
        // Console.WriteLine("Valores na linha 4: {" + matrizUm[4,0] + ", " + matrizUm[4,1] + ", " + matrizUm[4,2] + ", " + matrizUm[4,3] + ", " + matrizUm[4,4] + ", " + matrizUm[4,5] + ", " + matrizUm[4,6] + ", " + matrizUm[4,7] + "}");
        // Console.WriteLine("Valores na linha 5: {" + matrizUm[5,0] + ", " + matrizUm[5,1] + ", " + matrizUm[5,2] + ", " + matrizUm[5,3] + ", " + matrizUm[5,4] + ", " + matrizUm[5,5] + ", " + matrizUm[5,6] + ", " + matrizUm[5,7] + "}");
        // Console.WriteLine("Valores na linha 6: {" + matrizUm[6,0] + ", " + matrizUm[6,1] + ", " + matrizUm[6,2] + ", " + matrizUm[6,3] + ", " + matrizUm[6,4] + ", " + matrizUm[6,5] + ", " + matrizUm[6,6] + ", " + matrizUm[6,7] + "}");
        // Console.WriteLine("Valores na linha 7: {" + matrizUm[7,0] + ", " + matrizUm[7,1] + ", " + matrizUm[7,2] + ", " + matrizUm[7,3] + ", " + matrizUm[7,4] + ", " + matrizUm[7,5] + ", " + matrizUm[7,6] + ", " + matrizUm[7,7] + "}");

    // Impressão do comentario e da matriz
        Console.WriteLine("Matriz Um: ");
        ImpressaoMatrizes(matrizUm);

        Console.WriteLine("\nMatriz Dois: ");
        ImpressaoMatrizes(matrizDois);

        Console.WriteLine("\nMatriz Tres: ");
        ImpressaoMatrizes(matrizTres);

        Console.WriteLine("\nMatriz Quatro: ");
        ImpressaoMatrizes(matrizQuatro);

        Console.WriteLine("\nMatriz Cinco: ");
        ImpressaoMatrizes(matrizCinco);

        Console.WriteLine("\nMatriz Seis: ");
        ImpressaoMatrizes(matrizSeis);
    }

    public static void ImpressaoMatrizes(int[,] matriz){                                // Função para gerar a impresão das matrizes, usando os laços for vai percorer linha por linha, coluna por coluna as preenchendo 
        for (int aux = 0; aux < matriz.GetLength(0); aux++){                            // Laço externo que ira retornar o numero de linha da matriz
            for (int i = 0; i < matriz.GetLength(1); i++){                              // Laço interno que ira retornar o numero de colunas da matriz
                Console.Write(matriz[aux, i] + " ");                                    // Imprime o valor presente na posição [aux, i] da matriz, retornando valor por valor com um espaço entre eles 
            } 
            Console.WriteLine();                                                        // Vai Pular pra linha de baixo apos todos os valores da primeira linha serem inseridas(acabar o primeiro laço)
        }
    }
}

