using System.IO;
using System.Security.AccessControl;
using System.Reflection.Emit;
using System.Data;
using System.Collections.Generic;
using DesafioPOO.Models;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioDio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // TODO: Realizar os testes com as classes Nokia e Iphone
            Smartphone iphone = new Iphone(numero: "99999-9999", modelo: "14s", imei: "4y8t4y89", memoria: 256);
            Smartphone nokia = new Nokia(numero: "99999-9999", modelo: "XYZ", imei: "gho8o78", memoria: 16);

            Console.WriteLine("Nokia");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\nIphone");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}