namespace Aula20Ifood
{
    public class Pedido
    {
        public string[] Itens { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaPagamento { get; set; }
        public bool PedidoPago { get; set; }
        public int valor { get; set; }

        public string EntregarPedido(){
            if(PedidoPago == true){
                return "Pedido está a caminho!";
            }else{
                return "O pedido ainda não foi pago!";
            }
        }
        public string MostrarDados(){
            return $"Informações do Pedido \nCliente: {Cliente} \nRestaurante: {Restaurante} \nValor: {valor} \nForma de Pagamento: {FormaPagamento}";
        }
    }
}