namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }


        public override string InstalarAplicativo(string nomeApp, int memoria)
        {
            return "o aplicativo que está sendo instalado é "+ nomeApp;
        }
    }
}