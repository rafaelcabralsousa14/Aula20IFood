namespace Aula20Ifood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EndereçoAtual { get; set; }

        public string MostrarDados(){
            return $"Dados do perfil \nNome: {Nome} \nEndereço Atual: {EndereçoAtual}";
        }
        public string FazerPedido(string restaurante){
            return $"Pedido iniciado no restaurante {restaurante}";
        }
        public string Pagar(int valor){
            return $"Pedido no valor R${valor} pago";
        }
    }
}
