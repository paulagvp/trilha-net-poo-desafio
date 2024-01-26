﻿using DesafioPOO.Models;

Console.WriteLine("Bem vindo ao Desafio de POO do DecolaTech.");

int Funcionando = 1;

do
{
    Console.WriteLine("Digite o modelo do seu Smartphone:");
    var ModeloCelular = Console.ReadLine();

    if(ModeloCelular.ToLower() == "nokia")
    {
        Smartphone nokia = new Nokia(numero: "21212121212", modelo: "Modelo 1", imei: "12121212121", memoria: 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");
        Funcionando = 0;

    }else if(ModeloCelular.ToLower() == "iphone")
    {
        Smartphone iphone = new Iphone (numero: "3333333333", modelo: "Modelo 2", imei: "55555555555", memoria: 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Meets"); 
        Funcionando = 0;

    }else 
    {
        Console.WriteLine("Modelo não cadastrado, favor escolher entre os modelos Nokia ou Iphone. \nCaso seu celular não seja desse modelo digite 's' para sair.");
        var sair = Console.ReadLine().ToLower();
        if (sair  == "s"){Funcionando = 0;}
    }
}while (Funcionando == 1);