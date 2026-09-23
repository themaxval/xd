using System;

class Program
{
    static void Main()
    {
        string nombre;
        int vida = 100;
        int vidaViejita = 50;
        int opcion;

        Console.WriteLine("=== CUIDADO CON LA VEJA ===");

        Console.Write("Escribe tu nombre: ");
        nombre = Console.ReadLine();

        Console.WriteLine("\nHola " + nombre);
        Console.WriteLine("Subiste al bus, toca un largo viaje de regreso a casa.");
        Console.WriteLine("Encontraste un asiento libre para dormir rico todo el viaje y te sentaste.");
        Console.WriteLine("Pero de repente...");
        Console.WriteLine("¡Una vieja quiere quitarte el asiento!");
        Console.WriteLine("¡Comienza el combate por el asiento!");

        while (vida > 0 && vidaViejita > 0)
        {
            Console.WriteLine("\nTu energía: " + vida);
            Console.WriteLine("Energía de la viejita: " + vidaViejita);

            Console.WriteLine("\n¿Qué quieres hacer?");
            Console.WriteLine("1. Defender tu asiento");
            Console.WriteLine("2. Descansar");
            Console.Write("Elige: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                vidaViejita = vidaViejita - 10;

                Console.WriteLine("\nDefendiste tu asiento.");
                Console.WriteLine("La viejita perdió 10 de energía.");

                if (vidaViejita > 0)
                {
                    vida = vida - 5;

                    Console.WriteLine("¡La viejita intentó quitarte el asiento!");
                    Console.WriteLine("Perdiste 5 de energía.");
                }
            }
            else if (opcion == 2)
            {
                vida = vida + 10;

                if (vida > 100)
                {
                    vida = 100;
                }

                Console.WriteLine("\nTe acomodaste en el asiento.");
                Console.WriteLine("Recuperaste 10 de energía.");
            }
            else
            {
                Console.WriteLine("\nOpción incorrecta.");
            }
        }

        if (vidaViejita <= 0)
        {
            Console.WriteLine("\n=== VICTORIA ===");
            Console.WriteLine("¡Conseguiste conservar tu asiento!");
            Console.WriteLine("La viejita se fue a otro asiento.");
        }
        else
        {
            Console.WriteLine("\n=== DERROTA ===");
            Console.WriteLine("La viejita consiguió tu asiento.");
            Console.WriteLine("Ahora tienes que ir parado.");
        }

        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }
}