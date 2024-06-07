using System;

namespace DesafioPOO.Models
{
    public class iPhone : Smartphone
    {
        public iPhone(string numero, string marca, string imei, int memoria) 
            : base(numero, marca, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na App Store...");
        }
    }
}
