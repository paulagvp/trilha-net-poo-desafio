using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "21212121212", modelo: "Modelo 1", imei: "12121212121", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine(" ");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone (numero: "3333333333", modelo: "Modelo 2", imei: "55555555555", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
