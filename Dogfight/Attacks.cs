using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogfight
{
    class Attacks
    {
        public Attacks() {}

        public void DoDamage(Dog dog1, Dog dog2, string attackNumber)
        {
            //Ataques Genericos
            //Tackle
            if (attackNumber == "001")
            {
                float attackDamage = 30;
                float staminaCost = 10;
                dog1.Attack(dog2, staminaCost, attackDamage);
            }
            //Push
            else if (attackNumber == "002")
            {
                float attackDamage = 30;
                float staminaCost = 10;
                dog1.Attack(dog2, staminaCost, attackDamage);
            }
            //Bite
            else if (attackNumber == "003")
            {
                float attackDamage = 30;
                float staminaCost = 10;
                dog1.Attack(dog2, staminaCost, attackDamage);
            }
            //Dash
            else if (attackNumber == "004")
            {
                float attackDamage = 30;
                float staminaCost = 10;
                dog1.Attack(dog2, staminaCost, attackDamage);
            }
            //Stone Throw
            else if (attackNumber == "005")
            {
                float attackDamage = 30;
                float staminaCost = 10;
                dog1.Attack(dog2, staminaCost, attackDamage);
            }
            //Instant Spell
            else if (attackNumber == "006")
            {
                float attackDamage = 30;
                float staminaCost = 10;
                dog1.Attack(dog2, staminaCost, attackDamage);
            }
            //Slam
            else if (attackNumber == "007")
            {
                float attackDamage = 30;
                float staminaCost = 10;
                dog1.Attack(dog2, staminaCost, attackDamage);
            }
            //Claw
            else if (attackNumber == "008")
            {
                float attackDamage = 30;
                float staminaCost = 10;
                dog1.Attack(dog2, staminaCost, attackDamage);
            }

            //Ataques de Clase
            //Warrior
            //Cut
            else if (attackNumber == "009")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Thrust
            else if (attackNumber == "010")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Side Stab
            else if (attackNumber == "011")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Double Strike
            else if (attackNumber == "012")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Blade Flurry
            else if (attackNumber == "013")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Cleave
            else if (attackNumber == "014")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Ranged
            //Fireball
            else if (attackNumber == "015")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Holy Bolt
            else if (attackNumber == "016")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Ice Shard
            else if (attackNumber == "017")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Flaming Arrow
            else if (attackNumber == "018")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Cold Arrow
            else if (attackNumber == "019")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Lightning Arrow
            else if (attackNumber == "020")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Tank
            //Reckless Attack
            else if (attackNumber == "021")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Shield Bash
            else if (attackNumber == "022")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Shield Charge
            else if (attackNumber == "023")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Heavy Strike
            else if (attackNumber == "024")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Cyclone
            else if (attackNumber == "025")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Brutal Swing
            else if (attackNumber == "026")
            {
                float attackDamage = 50;
                float staminaCost = 20;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }

            //Ataques Especiales
            //Warrior
            //Judgement
            else if (attackNumber == "027")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Assassination
            else if (attackNumber == "028")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Sword Whirl
            else if (attackNumber == "029")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Blade Havoc
            else if (attackNumber == "030")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Blade Surge
            else if (attackNumber == "031")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Ranged
            //Rapid Fire
            else if (attackNumber == "032")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Grand Arrow
            else if (attackNumber == "033")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Life Drain
            else if (attackNumber == "034")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Inferno
            else if (attackNumber == "035")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Divine Storm
            else if (attackNumber == "036")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Tank
            //Tectonic Strike
            else if (attackNumber == "037")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Grand Challenge
            else if (attackNumber == "038")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Crippling Strike
            else if (attackNumber == "039")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Decimate
            else if (attackNumber == "040")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }
            //Leap Slam
            else if (attackNumber == "041")
            {
                float attackDamage = 80;
                float staminaCost = 40;
                dog1.Attack(dog2, staminaCost, GetClase(dog1, dog2, attackDamage));
            }


        }

        public void AttackStats(string attackNumber)
        {
            if (attackNumber == "001")
            {
                Console.WriteLine("Tackle - Daño: 30 - Costo de Stamina: 10");
            }
            else if (attackNumber == "002")
            {
                Console.WriteLine("Push - Daño: 30 - Costo de Stamina: 10");
            }
            else if (attackNumber == "003")
            {
                Console.WriteLine("Bite - Daño: 30 - Costo de Stamina: 10");
            }
            else if (attackNumber == "004")
            {
                Console.WriteLine("Dash - Daño: 30 - Costo de Stamina: 10");
            }
            else if (attackNumber == "005")
            {
                Console.WriteLine("Stone Throw - Daño: 30 - Costo de Stamina: 10");
            }
            else if (attackNumber == "006")
            {
                Console.WriteLine("Instant Spell - Daño: 30 - Costo de Stamina: 10");
            }
            else if (attackNumber == "007")
            {
                Console.WriteLine("Slam - Daño: 30 - Costo de Stamina: 10");
            }
            else if (attackNumber == "008")
            {
                Console.WriteLine("Claw - Daño: 30 - Costo de Stamina: 10");
            }
            else if (attackNumber == "009")
            {
                Console.WriteLine("Cut - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "010")
            {
                Console.WriteLine("Thrust - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "011")
            {
                Console.WriteLine("Side Stab - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "012")
            {
                Console.WriteLine("Double Strike - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "013")
            {
                Console.WriteLine("Blade Flurry - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "014")
            {
                Console.WriteLine("Cleave - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "015")
            {
                Console.WriteLine("Fireball - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "016")
            {
                Console.WriteLine("Holy Bolt - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "017")
            {
                Console.WriteLine("Ice Shard - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "018")
            {
                Console.WriteLine("Flaming Arrow - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "019")
            {
                Console.WriteLine("Cold Arrow - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "020")
            {
                Console.WriteLine("Lightning Arrow - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "021")
            {
                Console.WriteLine("Reckless Attack - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "022")
            {
                Console.WriteLine("Shield Bash - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "023")
            {
                Console.WriteLine("Shield Charge - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "024")
            {
                Console.WriteLine("Heavy Strike - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "025")
            {
                Console.WriteLine("Cyclone - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "026")
            {
                Console.WriteLine("Brutal Swing - Daño: 50 - Costo de Stamina: 20");
            }
            else if (attackNumber == "027")
            {
                Console.WriteLine("Judgement - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "028")
            {
                Console.WriteLine("Assassination - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "029")
            {
                Console.WriteLine("Sword Whirl - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "030")
            {
                Console.WriteLine("Blade Havoc - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "031")
            {
                Console.WriteLine("Blade Surge - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "032")
            {
                Console.WriteLine("Rapid Fire - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "033")
            {
                Console.WriteLine("Grand Arrow - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "034")
            {
                Console.WriteLine("Life Drain - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "035")
            {
                Console.WriteLine("Inferno - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "036")
            {
                Console.WriteLine("Divine Storm - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "037")
            {
                Console.WriteLine("Tectonic Strike - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "038")
            {
                Console.WriteLine("Grand Challenge - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "039")
            {
                Console.WriteLine("Crippling Strike - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "040")
            {
                Console.WriteLine("Decimate - Daño: 80 - Costo de Stamina: 40");
            }
            else if (attackNumber == "041")
            {
                Console.WriteLine("Leap Slam - Daño: 80 - Costo de Stamina: 40");
            }
        }

        public float StaminaCost(string attackNumber)
        {
            if (attackNumber == "001")
            {
                return 10;
            }
            else if (attackNumber == "002")
            {
                return 10;
            }
            else if (attackNumber == "003")
            {
                return 10;
            }
            else if (attackNumber == "004")
            {
                return 10;
            }
            else if (attackNumber == "005")
            {
                return 10;
            }
            else if (attackNumber == "006")
            {
                return 10;
            }
            else if (attackNumber == "007")
            {
                return 10;
            }
            else if (attackNumber == "008")
            {
                return 10;
            }
            else if (attackNumber == "009")
            {
                return 20;
            }
            else if (attackNumber == "010")
            {
                return 20;
            }
            else if (attackNumber == "011")
            {
                return 20;
            }
            else if (attackNumber == "012")
            {
                return 20;
            }
            else if (attackNumber == "013")
            {
                return 20;
            }
            else if (attackNumber == "014")
            {
                return 20;
            }
            else if (attackNumber == "015")
            {
                return 20;
            }
            else if (attackNumber == "016")
            {
                return 20;
            }
            else if (attackNumber == "017")
            {
                return 20;
            }
            else if (attackNumber == "018")
            {
                return 20;
            }
            else if (attackNumber == "019")
            {
                return 20;
            }
            else if (attackNumber == "020")
            {
                return 20;
            }
            else if (attackNumber == "021")
            {
                return 20;
            }
            else if (attackNumber == "022")
            {
                return 20;
            }
            else if (attackNumber == "023")
            {
                return 20;
            }
            else if (attackNumber == "024")
            {
                return 20;
            }
            else if (attackNumber == "025")
            {
                return 20;
            }
            else if (attackNumber == "026")
            {
                return 20;
            }
            else if (attackNumber == "027")
            {
                return 40;
            }
            else if (attackNumber == "028")
            {
                return 40;
            }
            else if (attackNumber == "029")
            {
                return 40;
            }
            else if (attackNumber == "030")
            {
                return 40;
            }
            else if (attackNumber == "031")
            {
                return 40;
            }
            else if (attackNumber == "032")
            {
                return 40;
            }
            else if (attackNumber == "033")
            {
                return 40;
            }
            else if (attackNumber == "034")
            {
                return 40;
            }
            else if (attackNumber == "035")
            {
                return 40;
            }
            else if (attackNumber == "036")
            {
                return 40;
            }
            else if (attackNumber == "037")
            {
                return 40;
            }
            else if (attackNumber == "038")
            {
                return 40;
            }
            else if (attackNumber == "039")
            {
                return 40;
            }
            else if (attackNumber == "040")
            {
                return 40;
            }
            else if (attackNumber == "041")
            {
                return 40;
            }
            else
            {
                return 0;
            }
        }

        public float GetClase(Dog doggo1, Dog doggo2, float atk)
        {
            if (doggo1.clase == "Tank")
            {
                if (doggo2.clase == "Warrior")
                {
                    Console.WriteLine(doggo1.name + " tiene ventaja sobre " + doggo2.name);
                    return atk * 1.25f;
                }
                if (doggo2.clase == "Ranged")
                {
                    Console.WriteLine(doggo1.name + " tiene desventaja sobre " + doggo2.name);
                    return atk * 0.75f;
                }
                return atk;
            }
            if (doggo1.clase == "Ranged")
            {
                if (doggo2.clase == "Tank")
                {
                    Console.WriteLine(doggo1.name + " tiene ventaja sobre " + doggo2.name);
                    return atk * 1.25f;
                }
                if (doggo2.clase == "Warrior")
                {
                    Console.WriteLine(doggo1.name + " tiene desventaja sobre " + doggo2.name);
                    return atk * 0.75f;
                }
                return atk;

            }
            if (doggo1.clase == "Warrior")
            {
                if (doggo2.clase == "Ranged")
                {
                    Console.WriteLine(doggo1.name + " tiene ventaja sobre " + doggo2.name);
                    return atk * 1.25f;
                }
                if (doggo2.clase == "Tank")
                {
                    Console.WriteLine(doggo1.name + " tiene desventaja sobre " + doggo2.name);
                    return atk * 0.75f;
                }
                return atk;
            }
            return atk;
        }
    }
}
