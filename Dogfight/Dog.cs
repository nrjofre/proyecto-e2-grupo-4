using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dogfight
{
    class Dog
    {
        public string name;
        public string clase;

        public float currentHealth;
        public float currentStamina;
        private float maxHealth;
        private float maxStamina;
        float regStamina;

        public string attack1;
        public string attack2;
        public string attack3;
        public string attackSpecial;

        public float life = 1;
        public float stunStatus = 0;

        public Dog(string dogName)
        {
            StreamReader sr = new StreamReader("../../" + dogName + ".txt");
            this.name = sr.ReadLine();
            this.maxHealth = Int32.Parse(sr.ReadLine());
            this.maxStamina = Int32.Parse(sr.ReadLine());
            this.regStamina = Int32.Parse(sr.ReadLine());
            this.clase = sr.ReadLine();
            this.attack1 = sr.ReadLine();
            this.attack2 = sr.ReadLine();
            this.attack3 = sr.ReadLine();
            this.attackSpecial = sr.ReadLine();
            this.currentHealth = maxHealth;
            this.currentStamina = maxStamina;
            sr.Close();
            UpdateDogFile(dogName);
        }

        private void UpdateDogFile(string dogName)
        {
            StreamWriter sw = new StreamWriter("Play" + dogName + ".txt");
            sw.WriteLine(name);
            sw.WriteLine(clase);
            sw.WriteLine(currentHealth);
            sw.WriteLine(currentStamina);
            sw.WriteLine(maxHealth);
            sw.WriteLine(maxStamina);
            sw.WriteLine(regStamina);
            sw.WriteLine(attack1);
            sw.WriteLine(attack2);
            sw.WriteLine(attack3);
            sw.WriteLine(attackSpecial);
            sw.WriteLine(life);
            sw.WriteLine(stunStatus);
            sw.Close();
        }

        public void ShowStats()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Clase: " + clase);
            Console.WriteLine("Health: " + currentHealth);
            Console.WriteLine("Stamina: " + currentStamina);
            Console.WriteLine("Stamina Regen: " + regStamina);
            if (stunStatus == 0)
            {
                Console.WriteLine(name + " no está aturdido.");
            }
            else
            {
                Console.WriteLine(name + " está aturdido.");
            }
            if (life == 1)
            {
                Console.WriteLine(name + " está vivo.");
            }
            else
            {
                Console.WriteLine(name + " está muerto.");
            }
            Console.WriteLine("----------------------------------------------------------");
        }

        public void RegStamina()
        {
            if (regStamina < (maxStamina - currentStamina))
            {
                currentStamina += regStamina;
                Console.WriteLine(name + " ha regenerado " + regStamina + " stamina.");
            }

            else
            {
                currentStamina = maxStamina;
                Console.WriteLine(name + " ha regenerado " + (maxStamina-currentStamina) + " stamina.");
            }
        }

        public void checkAlive()
        {
            if (currentHealth <= 0)
            {
                life = 0;
            }
        }

        public void Attack(Dog dog2, float staminaCost, float attackDamage)
        {
            if (stunStatus == 1)
            {
                Console.WriteLine(name + " no puede atacar, porque está aturdido.");
                return;
            }

            else if (stunStatus == 0)
            {
                if (staminaCost > currentStamina)
                {
                    Console.WriteLine("¡Tu Gladiadog no tiene suficiente stamina para este ataque!");
                }
                else
                {
                    dog2.currentHealth -= attackDamage;
                    currentStamina -= staminaCost;
                    if (dog2.currentHealth < 0)
                    {
                        dog2.currentHealth = 0;
                    }
                    Console.WriteLine(name + " ha atacado a " + dog2.name + " dejandolo con " + dog2.currentHealth + " de vida.");
                }
            }
        }
    }
}
