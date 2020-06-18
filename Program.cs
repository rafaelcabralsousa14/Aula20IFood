using System;

namespace Aula20Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            System.Console.WriteLine("Qual é o seu nome?");
            cliente.Nome = Console.ReadLine();
            System.Console.WriteLine("Para qual endereço o pedido deve ser enviado?");
            cliente.EndereçoAtual = Console.ReadLine();
            System.Console.WriteLine(cliente.MostrarDados());
            System.Console.WriteLine("Quer fazer um novo pedido?");
            string resposta = Console.ReadLine();
            if(resposta == "Sim"){
                Restaurante mcdonalds = new Restaurante();
                mcdonalds.NomeR = "McDonalds";
                mcdonalds.Endereço = "Av. Dr. Gastão Vidigal";
                System.Console.WriteLine(mcdonalds.MostrarDados());
                System.Console.WriteLine(cliente.FazerPedido("McDonalds"));
                Pedido pedido1 = new Pedido();
                pedido1.Cliente = cliente.Nome;
                pedido1.Restaurante = mcdonalds.NomeR;
                pedido1.valor = 24;
                System.Console.WriteLine("Qual será a forma de pagamento?");
                pedido1.FormaPagamento = Console.ReadLine();
                cliente.Pagar(24);
                pedido1.PedidoPago = true; 
                System.Console.WriteLine(pedido1.MostrarDados());
                System.Console.WriteLine("Quer cancelar o pedido?");
                string cancelamento = Console.ReadLine();
                if(cancelamento == "sim"){
                    System.Console.WriteLine("Pedido cancelado");
                }else{
                    System.Console.WriteLine(pedido1.EntregarPedido());
                }
            }
        }
    }
}