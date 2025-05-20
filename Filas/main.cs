using System;
using System.Collections.Generic;

class Restaurante{
    public string Nome { get; set; }
    public string Prato { get; set; }
    public int Preco { get; set; }
    
    public Restaurante(string nome, string prato, int preco){
        Nome = nome;
        Prato = prato;
        Preco = preco;
    }
    public override string ToString(){
        return $"Nome: {Nome}, Prato: {Prato}, Preço: {Preco}";
    }
}
class Program{
    static void Main(){
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        
        LinkedList<Restaurante> filaDePedidos = new LinkedList<Restaurante>();

        filaDePedidos.AddLast(new Restaurante("Renata", "Lasanha", 30));
        filaDePedidos.AddLast(new Restaurante("Paulo", "Pizza", 45));
        filaDePedidos.AddLast(new Restaurante("Rodrigo", "Salada", 20));

        Console.WriteLine("Pedidos na ordem de chegada:");
        ExibirPedidos(filaDePedidos);

        Console.WriteLine("\nRemovendo pedido de: Paulo");
        RemoverPedido(filaDePedidos, "Paulo");

        Console.WriteLine("\nPedidos após remoção:");
        ExibirPedidos(filaDePedidos);

        Console.WriteLine("\nAdicionando pedido prioritário: Renata");
        filaDePedidos.AddFirst(new Restaurante("Renata", "Feijoada", 50));

        Console.WriteLine("\nFila atualizada:");
        ExibirPedidos(filaDePedidos);
    }

    static void ExibirPedidos(LinkedList<Restaurante> fila){
        foreach (var pedido in fila){
            Console.WriteLine(pedido);
        }
    }

    static void RemoverPedido(LinkedList<Restaurante> fila, string nome){
        var noAtual = fila.First;
        while (noAtual != null){
            if (noAtual.Value.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)){
                fila.Remove(noAtual);
                break;
            }
            noAtual = noAtual.Next;
        }
    }
}