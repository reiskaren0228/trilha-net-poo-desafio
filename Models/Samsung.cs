using System;

namespace DesafioPOO.Models
{
    public class Xiaomi : Smartphone
    {
        public Xiaomi(string numero, string marca, string modelo, string imei, string memoria) 
            : base(numero, marca, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na Mi Store...");
        }
    }
}
