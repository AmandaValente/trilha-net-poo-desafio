
namespace DesafioPOO.Models
{
    public abstract class Smartphone : ISmartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string Imei;
        protected int Memoria {get;set;}



        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;


        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando para {Numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação de {Numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp , int memoria);

        public void RegistrarVideo()
        {
            Console.WriteLine($"Vídeo registrado com sucesso!");
        }
    }
}