using DesafioPOO.Models;

namespace SmartphoneTestes;

public class NokiaTestes
{
    private Nokia _nokia;

    public NokiaTestes()
    {
        _nokia = new Nokia(numero: "2345", modelo: "tipo1", imei: "abcs", memoria: 64);

    }

    [Fact]
    public void LigarExibirMensagem()
    {

        var msg = _nokia.Ligar("2345");

        Assert.Equal("Ligando para 2345", msg);


    }
    [Fact]
    public void TestarApresentarMemoria()
    {

        var msg = _nokia.ApresentarMemoria(14);

        Assert.Equal("Memoria com 14MB ocupada.", msg);

    }
    [Fact]
    public void TestarInstalarAplicativo()
    {

        var msg = _nokia.InstalarAplicativo("Spotfy", 67);
        
        Assert.Equal("o aplicativo que está sendo instalado no Nokia é Spotfy ocupando 67 MB", msg);

    }
    [Fact]
    public void TestarRegistrarVideo()
    {

        var msg = _nokia.RegistrarVideo(32);
        
        Assert.Equal("Vídeo ocupando 32 MB", msg);
    }

}
