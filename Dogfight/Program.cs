using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogfight
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allPerros = new List<string>() { "Bulldog Gladiator", "Canitaur God", "Corgi Guard", "Crossbowman Pug", "Dachshund Inquisitor", "Doberman Knight", "German Sheperd Oprichnik", "Greyhound Hunter", "Poodle Warlock", "Saint Bernard", "Shiba Inu Samurai", "Siberian Husky Barbarian", "Sir Gunter", "Spaniel Admiral", "Undead Dog Infantry" };
            List<string> allPerros2 = new List<string>() { "(0) Bulldog Gladiator", "(1) Canitaur God", "(2) Corgi Guard", "(3) Crossbowman Pug", "(4) Dachshund Inquisitor", "(5) Doberman Knight", "(6) German Sheperd Oprichnik", "(7) Greyhound Hunter", "(8) Poodle Warlock", "(9) Saint Bernard", "(10) Shiba Inu Samurai", "(11) Siberian Husky Barbarian", "(12) Sir Gunter", "(13) Spaniel Admiral", "(14) Undead Dog Infantry" };

            string jug1dog1;
            string jug1dog2;
            string jug1dog3;
            string jug2dog1;
            string jug2dog2;
            string jug2dog3;

            //Inicio del juego, se le piden los nombres a los jugadores y se seleccionan los Gladiadogs.

            Console.WriteLine("¡Bienvenidos a GLADIADOGS! Donde los peleas callejeras de perros son cosa del pasado...");
            Console.WriteLine("Escoge a tus perros, forma un equipo y acaba con tu rival en esta mítica arena!");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Domador 1, escribe tu nombre...");
            string jug1 = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Ahora, Domador 2, escribe tu nombre...");
            string jug2 = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Lista de Gladiadogs: ");
            allPerros2.ForEach(perro => Console.WriteLine(perro));
            Console.WriteLine(jug1 + " elige a tu primer Gladiadog...");
            int jug1dog1num = -1;
            while (true)
            {
                jug1dog1num = Int32.Parse(Console.ReadLine());
                if (jug1dog1num < allPerros.Count() && jug1dog1num >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escriba un numero valido...");
                }
            }
            jug1dog1 = allPerros[jug1dog1num];
            string dogToElim = allPerros2[jug1dog1num];
            allPerros2.Remove(dogToElim);
            allPerros2.Insert(jug1dog1num, "Gladiadog No Disponible...");
            Console.WriteLine(jug1 + " ha agregado a " + jug1dog1 + " a su equipo!");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Lista de Gladiadogs: ");
            allPerros2.ForEach(perro => Console.WriteLine(perro));
            Console.WriteLine(jug2 + " elige a tu primer Gladiadog...");
            int jug2dog1num = -1;
            while (true)
            {
                jug2dog1num = Int32.Parse(Console.ReadLine());
                if (jug2dog1num < allPerros.Count() && jug2dog1num >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escriba un numero valido...");
                }
            }
            jug2dog1 = allPerros[jug2dog1num];
            dogToElim = allPerros2[jug2dog1num];
            allPerros2.Remove(dogToElim);
            allPerros2.Insert(jug2dog1num, "Gladiadog No Disponible...");
            Console.WriteLine(jug2 + " ha agregado a " + jug2dog1 + " a su equipo!");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Lista de Gladiadogs: ");
            allPerros2.ForEach(perro => Console.WriteLine(perro));
            Console.WriteLine(jug2 + " elige a tu segundo Gladiadog...");
            int jug2dog2num = -1;
            while (true)
            {
                jug2dog2num = Int32.Parse(Console.ReadLine());
                if (jug2dog2num < allPerros.Count() && jug2dog2num >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escriba un numero valido...");
                }
            }
            jug2dog2 = allPerros[jug2dog2num];
            dogToElim = allPerros2[jug2dog2num];
            allPerros2.Remove(dogToElim);
            allPerros2.Insert(jug2dog2num, "Gladiadog No Disponible...");
            Console.WriteLine(jug2 + " ha agregado a " + jug2dog2 + " a su equipo!");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Lista de Gladiadogs: ");
            allPerros2.ForEach(perro => Console.WriteLine(perro));
            Console.WriteLine(jug1 + " elige a tu segundo Gladiadog...");
            int jug1dog2num = -1;
            while (true)
            {
                jug1dog2num = Int32.Parse(Console.ReadLine());
                if (jug1dog2num < allPerros.Count() && jug1dog2num >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escriba un numero valido...");
                }
            }
            jug1dog2 = allPerros[jug1dog2num];
            dogToElim = allPerros2[jug1dog2num];
            allPerros2.Remove(dogToElim);
            allPerros2.Insert(jug1dog2num, "Gladiadog No Disponible...");
            Console.WriteLine(jug1 + " ha agregado a " + jug1dog2 + " a su equipo!");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Lista de Gladiadogs: ");
            allPerros2.ForEach(perro => Console.WriteLine(perro));
            Console.WriteLine(jug1 + " elige a tu ultimo Gladiadog...");
            int jug1dog3num = -1;
            while (true)
            {
                jug1dog3num = Int32.Parse(Console.ReadLine());
                if (jug1dog3num < allPerros.Count() && jug1dog3num >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escriba un numero valido...");
                }
            }
            jug1dog3 = allPerros[jug1dog3num];
            dogToElim = allPerros2[jug1dog3num];
            allPerros2.Remove(dogToElim);
            allPerros2.Insert(jug1dog3num, "Gladiadog No Disponible...");
            Console.WriteLine(jug1 + " ha agregado a " + jug1dog3 + " a su equipo!");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Lista de Gladiadogs: ");
            allPerros2.ForEach(perro => Console.WriteLine(perro));
            Console.WriteLine(jug2 + " elige a tu ultimo Gladiadog...");
            int jug2dog3num = -1;
            while (true)
            {
                jug2dog3num = Int32.Parse(Console.ReadLine());
                if (jug2dog3num < allPerros.Count() && jug2dog3num >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escriba un numero valido...");
                }
            }
            jug2dog3 = allPerros[jug2dog3num];
            dogToElim = allPerros2[jug2dog3num];
            allPerros2.Remove(dogToElim);
            allPerros2.Insert(jug2dog3num, "Gladiadog No Disponible...");
            Console.WriteLine(jug2 + " ha agregado a " + jug2dog3 + " a su equipo!");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("¡La selección de los equipos ha terminado!");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Equipo de " + jug1 + ": " + jug1dog1 + ", " + jug1dog2 + ", " + jug1dog3);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Equipo de " + jug2 + ": " + jug2dog1 + ", " + jug2dog2 + ", " + jug2dog3);

            //Se termina esta parte y se da inicio al juego.
            //Se inicializan los Gladiadogs

            Dog p1dog1 = new Dog(jug1dog1);
            Dog p1dog2 = new Dog(jug1dog2);
            Dog p1dog3 = new Dog(jug1dog3);
            Dog p2dog1 = new Dog(jug2dog1);
            Dog p2dog2 = new Dog(jug2dog2);
            Dog p2dog3 = new Dog(jug2dog3);

            Attacks attacks = new Attacks();

            Dog activeDog1 = p1dog1;
            Dog activeDog2 = p2dog1;

            while ((p1dog1.life == 1 || p1dog2.life == 1 || p1dog3.life == 1) && (p2dog1.life == 1 || p2dog2.life == 1 || p2dog3.life == 1))
            {
                p1dog1.ShowStats();
                p1dog2.ShowStats();
                p1dog3.ShowStats();
                p2dog1.ShowStats();
                p2dog2.ShowStats();
                p2dog3.ShowStats();

                //Turno del Jugador 1
                while ((p1dog1.life == 1 || p1dog2.life == 1 || p1dog3.life == 1) && (p2dog1.life == 1 || p2dog2.life == 1 || p2dog3.life == 1))
                {
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Turno de " + jug1 + ". Tu Gladiadog activo es: " + activeDog1.name);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("(1) Atacar - (2) Descansar - (3) Cambiar Gladiadog");
                    Console.WriteLine("----------------------------------------------------------");
                    int decision = Int32.Parse(Console.ReadLine());
                    if (decision == 1)
                    {
                        Console.WriteLine("¿Qué ataque deseas usar?");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.Write("(1) ");
                        attacks.AttackStats(activeDog1.attack1);
                        Console.Write("(2) ");
                        attacks.AttackStats(activeDog1.attack2);
                        Console.Write("(3) ");
                        attacks.AttackStats(activeDog1.attack3);
                        Console.Write("(4) ");
                        attacks.AttackStats(activeDog1.attackSpecial);
                        Console.WriteLine("----------------------------------------------------------");

                        int ataquedecidido = Int32.Parse(Console.ReadLine());
                        if (ataquedecidido == 1)
                        {
                            if (activeDog1.name == p1dog1.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attack1))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog1, p1dog1.attack1);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attack1))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog2, p1dog1.attack1);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attack1))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog3, p1dog1.attack1);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog1.name == p1dog2.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attack1))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog1, p1dog2.attack1);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attack1))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog2, p1dog2.attack1);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attack1))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog3, p1dog2.attack1);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog1.name == p1dog3.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attack1))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog1, p1dog3.attack1);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attack1))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog2, p1dog3.attack1);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attack1))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog3, p1dog3.attack1);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                        }
                        else if (ataquedecidido == 2)
                        {
                            if (activeDog1.name == p1dog1.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attack2))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog1, p1dog1.attack2);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attack2))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog2, p1dog1.attack2);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attack2))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog3, p1dog1.attack2);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog1.name == p1dog2.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attack2))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog1, p1dog2.attack2);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attack2))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog2, p1dog2.attack2);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attack2))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog3, p1dog2.attack2);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog1.name == p1dog3.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attack2))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog1, p1dog3.attack2);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attack2))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog2, p1dog3.attack2);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attack2))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog3, p1dog3.attack2);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                        }
                        else if (ataquedecidido == 3)
                        {
                            if (activeDog1.name == p1dog1.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attack3))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog1, p1dog1.attack3);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attack3))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog2, p1dog1.attack3);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attack3))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog3, p1dog1.attack3);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog1.name == p1dog2.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attack3))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog1, p1dog2.attack3);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attack3))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog2, p1dog2.attack3);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attack3))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog3, p1dog2.attack3);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog1.name == p1dog3.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attack3))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog1, p1dog3.attack3);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attack3))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog2, p1dog3.attack3);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attack3))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog3, p1dog3.attack3);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                        }
                        else if (ataquedecidido == 4)
                        {
                            if (activeDog1.name == p1dog1.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attackSpecial))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog1, p1dog1.attackSpecial);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attackSpecial))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog2, p1dog1.attackSpecial);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog1.currentStamina >= attacks.StaminaCost(p1dog1.attackSpecial))
                                    {
                                        attacks.DoDamage(p1dog1, p2dog3, p1dog1.attackSpecial);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog1.name == p1dog2.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attackSpecial))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog1, p1dog2.attackSpecial);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attackSpecial))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog2, p1dog2.attackSpecial);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog2.currentStamina >= attacks.StaminaCost(p1dog2.attackSpecial))
                                    {
                                        attacks.DoDamage(p1dog2, p2dog3, p1dog2.attackSpecial);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog1.name == p1dog3.name)
                            {
                                if (activeDog2.name == p2dog1.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attackSpecial))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog1, p1dog3.attackSpecial);
                                        if (p2dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog1 + " ha caido en batalla!");
                                            p2dog1.life = 0;
                                            if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog2.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attackSpecial))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog2, p1dog3.attackSpecial);
                                        if (p2dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog2 + " ha caido en batalla!");
                                            p2dog2.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog3.life == 1)
                                            {
                                                activeDog2 = p2dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog2.name == p2dog3.name)
                                {
                                    if (p1dog3.currentStamina >= attacks.StaminaCost(p1dog3.attackSpecial))
                                    {
                                        attacks.DoDamage(p1dog3, p2dog3, p1dog3.attackSpecial);
                                        if (p2dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p2dog3 + " ha caido en batalla!");
                                            p2dog3.life = 0;
                                            if (p2dog1.life == 1)
                                            {
                                                activeDog2 = p2dog1;
                                            }
                                            else if (p2dog2.life == 1)
                                            {
                                                activeDog2 = p2dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p1dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Elige un ataque válido...");
                            continue;
                        }

                    }
                    else if (decision == 2)
                    {
                        Console.WriteLine("¿Seguro que deseas que tu Gladiadog descanse? (1) Si - (2) No");
                        int confirmacion = Int32.Parse(Console.ReadLine());
                        if (confirmacion == 1)
                        {
                            if (activeDog1.name == p1dog1.name)
                            {
                                p1dog1.RegStamina();
                            }
                            else if (activeDog1.name == p1dog2.name)
                            {
                                p1dog2.RegStamina();
                            }
                            else if (activeDog1.name == p1dog3.name)
                            {
                                p1dog3.RegStamina();
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (decision == 3)
                    {
                        Console.WriteLine("¿Seguro que deseas cambiar a tu Gladiadog? (1) Si - (2) No");
                        int confirmacion = Int32.Parse(Console.ReadLine());
                        if (confirmacion == 1)
                        {
                            Console.WriteLine("Tu Gladiadog en batalla es: " + activeDog1.name);
                            
                            if (activeDog1.name == p1dog1.name)
                            {
                                if (p1dog2.life == 1 && p1dog3.life == 1)
                                {
                                    Console.WriteLine("¿Por cuál deseas cambiarlo?");
                                    Console.WriteLine("(1) " + p1dog2.name + " (2) " + p1dog3.name);
                                    int decision1 = Int32.Parse(Console.ReadLine());
                                    if (decision1 == 1)
                                    {
                                        activeDog1 = p1dog2;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog2.name);
                                        break;
                                    }
                                    else if (decision1 == 2)
                                    {
                                        activeDog1 = p1dog3;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog3.name);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese no es una de las opciones...");
                                        continue;
                                    }
                                }
                                else if (p1dog2.life == 1 && p1dog3.life == 0)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p1dog2.name);
                                    activeDog1 = p1dog2;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog2.name);
                                    break;
                                }
                                else if (p1dog2.life == 0 && p1dog3.life == 1)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p1dog3.name);
                                    activeDog1 = p1dog3;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog3.name);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No te quedan más Gladiadogs vivos...");
                                    continue;
                                }
                            }
                            else if (activeDog1.name == p1dog2.name)
                            {
                                if (p1dog1.life == 1 && p1dog3.life == 1)
                                {
                                    Console.WriteLine("¿Por cuál deseas cambiarlo?");
                                    Console.WriteLine("(1) " + p1dog1.name + " (2) " + p1dog3.name);
                                    int decision1 = Int32.Parse(Console.ReadLine());
                                    if (decision1 == 1)
                                    {
                                        activeDog1 = p1dog1;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog1.name);
                                        break;
                                    }
                                    else if (decision1 == 2)
                                    {
                                        activeDog1 = p1dog3;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog3.name);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese no es una de las opciones...");
                                        continue;
                                    }
                                }
                                else if (p1dog1.life == 1 && p1dog3.life == 0)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p1dog1.name);
                                    activeDog1 = p1dog1;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog1.name);
                                    break;
                                }
                                else if (p1dog1.life == 0 && p1dog3.life == 1)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p1dog3.name);
                                    activeDog1 = p1dog3;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog3.name);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No te quedan más Gladiadogs vivos...");
                                    continue;
                                }
                            }
                            else if (activeDog1.name == p1dog3.name)
                            {
                                if (p1dog1.life == 1 && p1dog2.life == 1)
                                {
                                    Console.WriteLine("¿Por cuál deseas cambiarlo?");
                                    Console.WriteLine("(1) " + p1dog1.name + " (2) " + p1dog2.name);
                                    int decision1 = Int32.Parse(Console.ReadLine());
                                    if (decision1 == 1)
                                    {
                                        activeDog1 = p1dog1;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog1.name);
                                        break;
                                    }
                                    else if (decision1 == 2)
                                    {
                                        activeDog1 = p1dog2;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog2.name);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese no es una de las opciones...");
                                        continue;
                                    }
                                }
                                else if (p1dog1.life == 1 && p1dog2.life == 0)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p1dog1.name);
                                    activeDog1 = p1dog1;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog1.name);
                                    break;
                                }
                                else if (p1dog1.life == 0 && p1dog2.life == 1)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p1dog2.name);
                                    activeDog1 = p1dog2;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p1dog2.name);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No te quedan más Gladiadogs vivos...");
                                    continue;
                                }
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Elige una opción válida...");
                    }
                }

                Console.WriteLine("Fin del turno de " + jug1 + ". Los Gladiadogs se encuentran en el siguiente estado: ");
                p1dog1.ShowStats();
                p1dog2.ShowStats();
                p1dog3.ShowStats();
                p2dog1.ShowStats();
                p2dog2.ShowStats();
                p2dog3.ShowStats();


                //Turno del Jugador 2
                while ((p1dog1.life == 1 || p1dog2.life == 1 || p1dog3.life == 1) && (p2dog1.life == 1 || p2dog2.life == 1 || p2dog3.life == 1))
                {
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Turno de " + jug2 + ". Tu Gladiadog activo es: " + activeDog2.name);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("(1) Atacar - (2) Descansar - (3) Cambiar Gladiadog");
                    Console.WriteLine("----------------------------------------------------------");
                    int decision = Int32.Parse(Console.ReadLine());
                    if (decision == 1)
                    {
                        Console.WriteLine("¿Qué ataque deseas usar?");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.Write("(1) ");
                        attacks.AttackStats(activeDog2.attack1);
                        Console.Write("(2) ");
                        attacks.AttackStats(activeDog2.attack2);
                        Console.Write("(3) ");
                        attacks.AttackStats(activeDog2.attack3);
                        Console.Write("(4) ");
                        attacks.AttackStats(activeDog2.attackSpecial);
                        Console.WriteLine("----------------------------------------------------------");

                        int ataquedecidido = Int32.Parse(Console.ReadLine());
                        if (ataquedecidido == 1)
                        {
                            if (activeDog2.name == p2dog1.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attack1))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog1, p2dog1.attack1);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attack1))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog2, p2dog1.attack1);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attack1))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog3, p2dog1.attack1);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog2.name == p2dog2.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attack1))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog1, p2dog2.attack1);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attack1))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog2, p2dog2.attack1);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attack1))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog3, p2dog2.attack1);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog2.name == p2dog3.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attack1))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog1, p2dog3.attack1);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attack1))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog2, p2dog3.attack1);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attack1))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog3, p2dog3.attack1);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                        }
                        else if (ataquedecidido == 2)
                        {
                            if (activeDog2.name == p2dog1.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attack2))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog1, p2dog1.attack2);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attack2))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog2, p2dog1.attack2);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attack2))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog3, p2dog1.attack2);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog2.name == p2dog2.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attack2))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog1, p2dog2.attack2);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attack2))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog2, p2dog2.attack2);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attack2))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog3, p2dog2.attack2);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog2.name == p2dog3.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attack2))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog1, p2dog3.attack2);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attack2))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog2, p2dog3.attack2);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attack2))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog3, p2dog3.attack2);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                        }
                        else if (ataquedecidido == 3)
                        {
                            if (activeDog2.name == p2dog1.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attack3))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog1, p2dog1.attack3);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attack3))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog2, p2dog1.attack3);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attack3))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog3, p2dog1.attack3);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog2.name == p2dog2.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attack3))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog1, p2dog2.attack3);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attack3))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog2, p2dog2.attack3);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attack3))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog3, p2dog2.attack3);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog2.name == p2dog3.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attack3))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog1, p2dog3.attack3);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attack3))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog2, p2dog3.attack3);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attack3))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog3, p2dog3.attack3);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                        }
                        else if (ataquedecidido == 4)
                        {
                            if (activeDog2.name == p2dog1.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attackSpecial))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog1, p2dog1.attackSpecial);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attackSpecial))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog2, p2dog1.attackSpecial);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog1.currentStamina >= attacks.StaminaCost(p2dog1.attackSpecial))
                                    {
                                        attacks.DoDamage(p2dog1, p1dog3, p2dog1.attackSpecial);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog1.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog2.name == p2dog2.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attackSpecial))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog1, p2dog2.attackSpecial);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attackSpecial))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog2, p2dog2.attackSpecial);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog2.currentStamina >= attacks.StaminaCost(p2dog2.attackSpecial))
                                    {
                                        attacks.DoDamage(p2dog2, p1dog3, p2dog2.attackSpecial);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog2.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                            else if (activeDog2.name == p2dog3.name)
                            {
                                if (activeDog1.name == p1dog1.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attackSpecial))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog1, p2dog3.attackSpecial);
                                        if (p1dog1.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog1 + " ha caido en batalla!");
                                            p1dog1.life = 0;
                                            if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog2.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attackSpecial))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog2, p2dog3.attackSpecial);
                                        if (p1dog2.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog2 + " ha caido en batalla!");
                                            p1dog2.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog3.life == 1)
                                            {
                                                activeDog1 = p1dog3;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                                else if (activeDog1.name == p1dog3.name)
                                {
                                    if (p2dog3.currentStamina >= attacks.StaminaCost(p2dog3.attackSpecial))
                                    {
                                        attacks.DoDamage(p2dog3, p1dog3, p2dog3.attackSpecial);
                                        if (p1dog3.currentHealth <= 0)
                                        {
                                            Console.WriteLine(p1dog3 + " ha caido en batalla!");
                                            p1dog3.life = 0;
                                            if (p1dog1.life == 1)
                                            {
                                                activeDog1 = p1dog1;
                                            }
                                            else if (p1dog2.life == 1)
                                            {
                                                activeDog1 = p1dog2;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(p2dog3.name + " no tiene la stamina necesaria para realizar este ataque...");
                                        continue;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Elige un ataque válido...");
                            continue;
                        }

                    }
                    else if (decision == 2)
                    {
                        Console.WriteLine("¿Seguro que deseas que tu Gladiadog descanse? (1) Si - (2) No");
                        int confirmacion = Int32.Parse(Console.ReadLine());
                        if (confirmacion == 1)
                        {
                            if (activeDog2.name == p2dog1.name)
                            {
                                p2dog1.RegStamina();
                            }
                            else if (activeDog2.name == p2dog2.name)
                            {
                                p2dog2.RegStamina();
                            }
                            else if (activeDog2.name == p2dog3.name)
                            {
                                p2dog3.RegStamina();
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (decision == 3)
                    {
                        Console.WriteLine("¿Seguro que deseas cambiar a tu Gladiadog? (1) Si - (2) No");
                        int confirmacion = Int32.Parse(Console.ReadLine());
                        if (confirmacion == 1)
                        {
                            Console.WriteLine("Tu Gladiadog en batalla es: " + activeDog2.name);

                            if (activeDog2.name == p2dog1.name)
                            {
                                if (p2dog2.life == 1 && p2dog3.life == 1)
                                {
                                    Console.WriteLine("¿Por cuál deseas cambiarlo?");
                                    Console.WriteLine("(1) " + p2dog2.name + " (2) " + p2dog3.name);
                                    int decision1 = Int32.Parse(Console.ReadLine());
                                    if (decision1 == 1)
                                    {
                                        activeDog2 = p2dog2;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog2.name);
                                        break;
                                    }
                                    else if (decision1 == 2)
                                    {
                                        activeDog2 = p2dog3;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog3.name);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese no es una de las opciones...");
                                        continue;
                                    }
                                }
                                else if (p2dog2.life == 1 && p2dog3.life == 0)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p2dog2.name);
                                    activeDog2 = p2dog2;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog2.name);
                                    break;
                                }
                                else if (p2dog2.life == 0 && p2dog3.life == 1)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p2dog3.name);
                                    activeDog2 = p2dog3;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog3.name);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No te quedan más Gladiadogs vivos...");
                                    continue;
                                }
                            }
                            else if (activeDog2.name == p2dog2.name)
                            {
                                if (p2dog1.life == 1 && p2dog3.life == 1)
                                {
                                    Console.WriteLine("¿Por cuál deseas cambiarlo?");
                                    Console.WriteLine("(1) " + p2dog1.name + " (2) " + p2dog3.name);
                                    int decision1 = Int32.Parse(Console.ReadLine());
                                    if (decision1 == 1)
                                    {
                                        activeDog2 = p2dog1;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog1.name);
                                        break;
                                    }
                                    else if (decision1 == 2)
                                    {
                                        activeDog2 = p2dog3;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog3.name);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese no es una de las opciones...");
                                        continue;
                                    }
                                }
                                else if (p2dog1.life == 1 && p2dog3.life == 0)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p2dog1.name);
                                    activeDog2 = p2dog1;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog1.name);
                                    break;
                                }
                                else if (p2dog1.life == 0 && p2dog3.life == 1)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p2dog3.name);
                                    activeDog2 = p2dog3;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog3.name);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No te quedan más Gladiadogs vivos...");
                                    continue;
                                }
                            }
                            else if (activeDog2.name == p2dog3.name)
                            {
                                if (p2dog1.life == 1 && p2dog2.life == 1)
                                {
                                    Console.WriteLine("¿Por cuál deseas cambiarlo?");
                                    Console.WriteLine("(1) " + p2dog1.name + " (2) " + p2dog2.name);
                                    int decision1 = Int32.Parse(Console.ReadLine());
                                    if (decision1 == 1)
                                    {
                                        activeDog2 = p2dog1;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog1.name);
                                        break;
                                    }
                                    else if (decision1 == 2)
                                    {
                                        activeDog2 = p2dog2;
                                        Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog2.name);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese no es una de las opciones...");
                                        continue;
                                    }
                                }
                                else if (p2dog1.life == 1 && p2dog2.life == 0)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p2dog1.name);
                                    activeDog2 = p2dog1;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog1.name);
                                    break;
                                }
                                else if (p2dog1.life == 0 && p2dog2.life == 1)
                                {
                                    Console.WriteLine("Solo puedes cambiar a: " + p2dog2.name);
                                    activeDog2 = p2dog2;
                                    Console.WriteLine("Tu nuevo Gladiadog en batalla es " + p2dog2.name);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No te quedan más Gladiadogs vivos...");
                                    continue;
                                }
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Elige una opción válida...");
                    }
                }

                Console.WriteLine("Fin del turno de " + jug2 + ". Los Gladiadogs se encuentran en el siguiente estado: ");

            }

            //Condiciones finales del ganador

            if (p1dog1.life == 0 && p1dog2.life == 0 && p1dog3.life == 0)
            {
                Console.WriteLine("¡El rey de la arena de Gladiadogs es " + jug2 + "! ¡Felicitaciones, has ganado!");
            }
            else if (p2dog1.life == 0 && p2dog2.life == 0 && p2dog3.life == 0)
            {
                Console.WriteLine("¡El rey de la arena de Gladiadogs es " + jug1 + "! ¡Felicitaciones, has ganado!");
            }
            else
            {
                Console.WriteLine("Debug, debió haber ganado un jugador si lees esto... arreglalo!");
            }


            Console.WriteLine("El juego ha terminado");
            Console.ReadLine();
        }
    }
}
