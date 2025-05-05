using System;
public class RefatorandoParte2
{
        struct CafeManha{
            public string Alimento;
            public double Preco;
        }

        struct Almoco{
            public string Alimento;
            public double Preco;
        } 
        
        struct Clientes{
            public string Alimento;
            public double Preco;
        }
        
    public static void Main(string[] args)
    {  
        const int TAMANHO_LISTA = 5;

        CafeManha[] cardapioCafeManha = new CafeManha[TAMANHO_LISTA];

        cardapioCafeManha[0] = new CafeManha {Alimento = "Café", Preco = 1.50};
        cardapioCafeManha[1] = new CafeManha {Alimento = "Cereais", Preco = 4.30};
        cardapioCafeManha[2] = new CafeManha {Alimento = "Achocolatado", Preco = 3.50};
        cardapioCafeManha[3] = new CafeManha {Alimento = "Pão", Preco = 7.00};
        cardapioCafeManha[4] = new CafeManha {Alimento = "Suco", Preco = 5.00};

        Console.WriteLine("Cardápio do café da manhã: ");

        for(int aux = 0; aux < TAMANHO_LISTA; aux++){
            Console.WriteLine($"{aux + 1}. {cardapioCafeManha[aux].Alimento} - R$ {cardapioCafeManha[aux].Preco:F2}");
        }

        Console.WriteLine();

        Almoco[] cardapioAlmoco = new Almoco[TAMANHO_LISTA];

        cardapioAlmoco[0] = new Almoco {Alimento = "Prato 1", Preco = 23.55};
        cardapioAlmoco[1] = new Almoco {Alimento = "Prato 2", Preco = 30.00};
        cardapioAlmoco[2] = new Almoco {Alimento = "Prato 3", Preco = 23.50};
        cardapioAlmoco[3] = new Almoco {Alimento = "Prato 4", Preco = 47.00};
        cardapioAlmoco[4] = new Almoco {Alimento = "Prato 5", Preco = 29.75};

        Console.WriteLine("Cardápio do Almoço: ");

        for(int aux = 0; aux < TAMANHO_LISTA; aux++){
            Console.WriteLine($"{aux + 1}. {cardapioAlmoco[aux].Alimento} - R$ {cardapioAlmoco[aux].Preco:F2}");
        }

        Console.WriteLine();

        Clientes[] pedidosClientes = new Clientes[5];
        pedidosClientes[0] = new Clientes { Alimento = "Café", Preco = 1.50 };
        pedidosClientes[1] = new Clientes { Alimento = "Prato 2", Preco = 30.00 };
        pedidosClientes[2] = new Clientes { Alimento = "Suco", Preco = 5.00 };
        pedidosClientes[3] = new Clientes { Alimento = "Prato 3", Preco = 23.50 };
        pedidosClientes[4] = new Clientes { Alimento = "Pão", Preco = 7.00 };

        Console.WriteLine("Pedidos dos Clientes: ");

        for (int aux = 0; aux < TAMANHO_LISTA; aux++){
            Console.WriteLine($"{aux + 1}. {pedidosClientes[aux].Alimento} - R$ {pedidosClientes[aux].Preco:F2}");
        }
    }
}
