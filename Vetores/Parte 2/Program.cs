using System;

class OperacoesMatematicas 
{
    static void Main(string[] args)
    {
        // DECLARANDO VETORES

        int tamanho = 3;                                                   // Declaro uma variavel int com algum valor.
        int[] vetorA = new int[tamanho];                                   // Criação dos vetores recebendo como valor a variavel criada.
        int[] vetorB = new int[tamanho];
        int[] Soma = new int[tamanho];
        int[] Sub = new int[tamanho];
        int[] Mult = new int[tamanho];
        int[] Div = new int[tamanho];

        // DEFININDO OS VALORES DOS VETORES

        Console.WriteLine("=== Vetor A ===");
            for (int aux = 0; aux < tamanho; aux++){                        // Laço para que a variavel tamanho possa receber outro tamanho e aumentar o vetor
                Console.Write($"Digite o valor para vetorA[{aux}]: ");      // Pede ao usuario um valor que ira ficar em um lugar especifico do Vetor
                vetorA[aux] = int.Parse(Console.ReadLine()!);               // Console.ReadLine() Le o que o usuario digitar como string; int.Parse(...) Converte a string para int; A ! ignora o aviso de possível null
            }

        Console.WriteLine("\n=== Vetor B ===");
            for (int aux = 0; aux < tamanho; aux++){
                Console.Write($"Digite o valor para vetorB[{aux}]: ");
                vetorB[aux] = int.Parse(Console.ReadLine()!);
            }

        // OPERAÇÕES MATEMATICAS

        for (int aux = 0; aux < tamanho; aux++){                            // Soma elemento por elemento do Vetor A e B
            Soma[aux] = vetorA[aux] + vetorB[aux];
        }
        
        for (int aux = 0; aux < tamanho; aux++){                            // Subtração elemento por elemento do Vetor A e B
            Sub[aux] = vetorA[aux] - vetorB[aux];
        } 

        for (int aux = 0; aux < tamanho; aux++){                            // Divisão elemento por elemento do Vetor A e B
            Div[aux] = vetorA[aux] / vetorB[aux];
        } 

        for (int aux = 0; aux < tamanho; aux++){                            // Multiplicação elemento por elemento do Vetor A e B
            Mult[aux] = vetorA[aux] * vetorB[aux];
        } 

        // RESULTADO DAS OPERAÇÕES

        Console.WriteLine("\n=== Resultado da Soma ===");
            for (int aux = 0; aux < tamanho; aux++){   
                Console.WriteLine($"Soma[{aux}] = {Soma[aux]}");            // Exibe a posição do Vetor e o valor que sera armazenado (operação da A e B)
            }

        Console.WriteLine("\n=== Resultado da Subtração ===");
            for (int aux = 0; aux < tamanho; aux++){   
                Console.WriteLine($"Subtração[{aux}] = {Sub[aux]}");
            }

        Console.WriteLine("\n=== Resultado da Divisão ===");
            for (int aux = 0; aux < tamanho; aux++){   
                Console.WriteLine($"Divisão[{aux}] = {Div[aux]}");
            }

        Console.WriteLine("\n=== Resultado da Multiplicação ===");
            for (int aux = 0; aux < tamanho; aux++){   
                Console.WriteLine($"Multiplição[{aux}] = {Mult[aux]}");
            }
    }
}
