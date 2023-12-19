using System.Buffers;
using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smatphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123654", modelo: "ModeloX", imei: "22222", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "99999-0000", modelo: "ModeloY", imei: "33333", memoria: 64);
nokia.ReceberLigacao();
iphone.InstalarAplicativo("Google Maps");