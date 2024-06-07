using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Nokia
            Nokia nokia = new Nokia("123456789", "Nokia", "123456789012345", 64);

            // Testando métodos e propriedades da instância Nokia
            Console.WriteLine("=== Nokia ===");
            Console.WriteLine("Número: " + nokia.Numero);
            Console.WriteLine("Marca: " + nokia.Marca);
            Console.WriteLine("IMEI: " + nokia.IMEI);
            Console.WriteLine("Memória: " + nokia.Memoria + "GB");

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Criando uma instância de iPhone
            iPhone iphone = new iPhone("987654321", "Apple", "987654321098765", 128);

            // Testando métodos e propriedades da instância iPhone
            Console.WriteLine("=== iPhone ===");
            Console.WriteLine("Número: " + iphone.Numero);
            Console.WriteLine("Marca: " + iphone.Marca);
            Console.WriteLine("IMEI: " + iphone.IMEI);
            Console.WriteLine("Memória: " + iphone.Memoria + "GB");

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine();

            // Criando uma instância de Samsung
            Samsung samsung = new Samsung("456123789", "Samsung", "456123789012345", 256);

            // Testando métodos e propriedades da instância Samsung
            Console.WriteLine("=== Samsung ===");
            Console.WriteLine("Número: " + samsung.Numero);
            Console.WriteLine("Marca: " + samsung.Marca);
            Console.WriteLine("IMEI: " + samsung.IMEI);
            Console.WriteLine("Memória: " + samsung.Memoria + "GB");

            samsung.Ligar();
            samsung.ReceberLigacao();
            samsung.InstalarAplicativo("Facebook");

            Console.WriteLine();

            // Criando uma instância de Xiaomi
            Xiaomi xiaomi = new Xiaomi("789456123", "Xiaomi", "789456123012345", 128);

            // Testando métodos e propriedades da instância Xiaomi
            Console.WriteLine("=== Xiaomi ===");
            Console.WriteLine("Número: " + xiaomi.Numero);
            Console.WriteLine("Marca: " + xiaomi.Marca);
            Console.WriteLine("IMEI: " + xiaomi.IMEI);
            Console.WriteLine("Memória: " + xiaomi.Memoria + "GB");

            xiaomi.Ligar();
            xiaomi.ReceberLigacao();
            xiaomi.InstalarAplicativo("Twitter");

            Console.ReadLine(); // Aguarda o pressionamento de uma tecla para sair
        }
    }
}
