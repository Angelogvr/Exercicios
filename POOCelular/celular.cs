namespace POOCelular
{
    public class celular
    {
        public string cor = "Preto";
        public string modelo = "Samsung";
        public string tamanho = "Médio?";
        public bool ligado = false;
        public string enviar(){
            return "Mensagem enviada";
        }
        public string ligar(){
            return "Ligação realizada";
        }
    }
}