using DesafioPOO.Models;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone, INokia
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp, int memoria)
        {
            Console.WriteLine($"o aplicativo que está sendo instalado no Nokia é {nomeApp} ocupando {memoria} MB");
        }

        public void TraduzirTexto()
        {
            Console.WriteLine("Texto tradudizo");
        }

    }
}
