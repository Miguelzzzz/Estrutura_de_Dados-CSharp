// using System;
// using System.Text;
// public class Node
// {
//     public int Data;
//     // Dado armazenado no nó
//     public Node Next;
//     // Referência para o próximo nó na lista

//     // Construtor para criar um novo nó
//     public Node(int data)
//     {
//         Data = data;
//         Next = null;
//     }
// }

// // Definição da classe LinkedList que representa a lista encadeada
// public class LinkedList
// {
//     private Node head;
//     // Referência para o primeiro nó da lista

//     // Construtor para inicializar a lista vazia
//     public LinkedList()
//     {
//         head = null;
//     }
   
//     // Método para adicionar um nó no final da lista
//     public void Add(int data)
//     {
//         Node newNode = new Node(data);

//         if (head == null)
//         {
//             // Se a lista estiver vazia, o novo nó se torna o head
//             head = newNode;
//         }
//         else
//         {
//             // Caso contrário, percorre a lista até o último nó e adiciona o novo nó
//             Node current = head;
//             while (current.Next != null)
//             {
//                 current = current.Next;
//             }
//             current.Next = newNode;
//         }
//     }

//     // Método para remover um nó com um valor específico
//     public void Remove(int data)
//     {
//         if (head == null) // Lista vazia
//         {
//             Console.WriteLine("Lista vazia. Nada para remover.");
//             return;
//         }

//         // Caso especial: remover a cabeça
//         if (head.Data.Equals(data))
//         {
//             head = head.Next;
//             return;
//         }

//         Node current = head;
//         while (current.Next != null)
//         {
//             if (current.Next.Data.Equals(data))
//             {
//                 current.Next = current.Next.Next;
//                 return;
//             }
//             current = current.Next;
//         }
//         Console.WriteLine("Elemento não encontrado na lista.");
//     }

//     // Método para exibir os elementos da lista
//     public void Display()
//     {
//         Node current = head;
//         while (current != null)
//         {
//             Console.Write(current.Data + " -> ");
//             current = current.Next;
//         }
//         Console.WriteLine("null");
//     }
// }

// // Classe principal para testar a lista encadeada
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Configura a codificação de saída para UTF-8
//         Console.OutputEncoding = Encoding.UTF8;

//         LinkedList list = new LinkedList();

//         // Adicionando elementos à lista
//         list.Add(1000);
//         list.Add(2000);
//         list.Add(4000);
//         list.Add(6000);
//         list.Add(8000);
//         list.Add(10000);

//         // Exibindo os elementos da lista
//         Console.WriteLine("Lista original:");
//         list.Display();

//         // Removendo um elemento
//         Console.WriteLine("\nRemovendo 1000:");
//         list.Remove(1000);
//         list.Display();

//         // Removendo um elemento
//         Console.WriteLine("\nRemovendo 10000:");
//         list.Remove(10000);
//         list.Display();

//         // Removendo um elemento
//         Console.WriteLine("\nRemovendo 2000:");
//         list.Remove(2000);
//         list.Display();

//         // Tentando remover elemento não existente
//         Console.WriteLine("\nTentando remover 3000:");
//         list.Remove(3000);
//         list.Display();
//     }
// }