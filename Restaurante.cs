namespace Aula20Ifood
{
    public class Restaurante
    {
        public string NomeR { get; set; }
        public string Endereço { get; set; }

        public string MostrarDados(){
            return $"Dados do restaurante \nNome: {NomeR} \nEndereço: {Endereço}";
        }
    }
}