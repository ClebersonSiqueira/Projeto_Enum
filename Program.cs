using System;
using Projeto_Fixacao_Enum.Entities.Enums;
using Projeto_Fixacao_Enum.Entities;
using System.Globalization;

namespace Projeto_Fixacao_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //While para fazer como se fosse uma "function Update" (Loop infinito)
            while (true)
            {
                //Bloco Try/Catch (Tratar erros de execução) para não travar o sistema sem informar o que aconteceu de errado
                try
                {
                    #region Solicita dados do cliente
                    Console.WriteLine("Enter Client data: ");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Birth date (DD/MM/YYYY): ");
                    DateTime birthDate = DateTime.Parse(Console.ReadLine());
                    Client client = new Client(name, email, birthDate);
                    #endregion

                    #region Solicita e armazena o status do pedido com o cliente
                    Console.WriteLine("Enter Order Data:");
                    Console.Write("Status: ");
                    OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
                    Order order = new Order(DateTime.Now, status, client);
                    #endregion

                    #region Solicita os produtos do pedido
                    Console.Write("How many items to this order? ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"Enter {i} item data:");
                        Console.Write("Product Name: ");
                        string productName = Console.ReadLine();
                        Console.Write("Product Price: ");
                        double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Product product = new Product(productName, productPrice);

                        Console.Write("Quantity: ");
                        int ProductQuantity = int.Parse(Console.ReadLine());

                        OrderItem orderItem = new OrderItem(ProductQuantity, productPrice, product);

                        order.AddItem(orderItem);

                    }
                    #endregion

                    Console.WriteLine();
                    Console.WriteLine("ORDER SUMMARY:");
                    Console.WriteLine(order);
                    Console.WriteLine("Do you want to insert another order? (Y/N)");
                    string anwser = Console.ReadLine();

                    if (anwser == "N")
                        break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro: {e.Message}");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
