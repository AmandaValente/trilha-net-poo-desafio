using DesafioPOO.Models;


Smartphone Nokia = new Nokia(numero: "2345", modelo: "tipo1", imei: "abcs", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Spotfy");
Nokia.ReceberLigacao();

Smartphone iphone = new Iphone(numero: "56748", modelo: "tipo3", imei: "gdhgf", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");


