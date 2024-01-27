using DesafioPOO.Models;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone, INokia
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override string InstalarAplicativo(string nomeApp, int memoria)
        {
            return "o aplicativo que está sendo instalado no Nokia é " + nomeApp + " ocupando " + memoria + " MB";
        }

        public string ApresentarMemoria(int memoria)
        {
            return "Memoria com " + memoria + "MB ocupada.";
        }
    }
}
