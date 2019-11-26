using System;
using System.Collections.Generic;
using System.Text;

namespace NOVEMBERPROJECT_ERIK_SVEEN_TE17B
{
    class Båt
    {
        public string name;
        public int hp;
        public int firepower;
        public bool alive;
        //items

        public Båt(int _hp, int _firepower, string _name) //gör båt med stats så att man kan kalla på klassen via metoder i main och skapa dem där
        {
            hp = _hp;
            firepower = _firepower;
            name = _name;
        }

        public void hurts(int dmg)    //metoder för om jag skulle hinna med fighting delen av spelet, som nu inte finns med finns grund för
        {
            hp -= dmg;
            if (hp < 0)
            {
                hp = 0;
            }
        }

        public bool alivecheck() //lever? ja/nej
        {
            if (hp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int doDmg()
        {
            //math stuff
            return firepower;
        }

        public static Random Båtrullare = new Random(); // static så att man inte ska få samma båt varje gång


        public void printstats () // skriver ut alla stats med mellanrumm i slutet så att man kan se när det blir en ny båt.
        {
            Console.WriteLine(name);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("Firepower: " + firepower);
            Console.WriteLine();
        }



    }


}
