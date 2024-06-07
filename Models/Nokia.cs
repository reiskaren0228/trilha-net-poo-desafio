using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string marca, string imei, int memoria) 
            : base(numero, marca, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na loja de aplicativos da Nokia...");
        }
    }
}
