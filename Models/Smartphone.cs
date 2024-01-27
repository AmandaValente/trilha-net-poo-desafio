
namespace DesafioPOO.Models
{
    public abstract class Smartphone : ISmartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string Imei;
        protected int Memoria { get; set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;



        }

        public string Ligar(string numero)
        {
            return "Ligando para " + numero;

        }

        public string ReceberLigacao(string numero)
        {
            return "Recebendo ligação de " + numero;
        }

        public abstract string InstalarAplicativo(string nomeApp, int memoria);

        public string RegistrarVideo(int memoria)
        {
            return "Vídeo ocupando " + memoria + " MB";
        }
    }
}