using System;

class Program
{
    static void Main()
    {
        string nombre;
        int vida = 100;
        int vidaEnemigo = 50;
        int opcion;

        Console.WriteLine("=== AVENTURA RPG ===");

        Console.Write("Escribe tu nombre: ");
        nombre = Console.ReadLine();

        Console.WriteLine("\nHola " + nombre);
        Console.WriteLine("¡Un Goblin apareció!");
        Console.WriteLine("Comienza el combate.");

        while (vida > 0 && vidaEnemigo > 0)
        {
            Console.WriteLine("\nTu vida: " + vida);
            Console.WriteLine("Vida del Goblin: " + vidaEnemigo);

            Console.WriteLine("\n¿Qué quieres hacer?");
            Console.WriteLine("1. Atacar");
            Console.WriteLine("2. Curarse");
            Console.Write("Elige: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                vidaEnemigo = vidaEnemigo - 10;

                Console.WriteLine("\nAtacaste al Goblin.");
                Console.WriteLine("Le hiciste 10 de daño.");

                if (vidaEnemigo > 0)
                {
                    vida = vida - 5;

                    Console.WriteLine("El Goblin te atacó.");
                    Console.WriteLine("Perdiste 5 de vida.");
                }
            }
            else if (opcion == 2)
            {
                vida = vida + 10;

                if (vida > 100)
                {
                    vida = 100;
                }

                Console.WriteLine("\nTe curaste 10 de vida.");
            }
            else
            {
                Console.WriteLine("\nOpción incorrecta.");
            }
        }

        if (vidaEnemigo <= 0)
        {
            Console.WriteLine("\n=== VICTORIA ===");
            Console.WriteLine("Derrotaste al Goblin.");
        }
        else
        {
            Console.WriteLine("\n=== DERROTA ===");
            Console.WriteLine("Te quedaste sin vida.");
        }

        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }
}