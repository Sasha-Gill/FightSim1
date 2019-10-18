using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class fighter
    {
        private int hp = 100;//Gör int:en privat så att man inte kan ändra HP värdet.
        public string Name;//
        private int minDmg = 10;//minsta mängden en fighter gör
        private int maxDmg = 20;//största mängden en fighter gör
        static Random generator = new Random();//Denna random gör jag till static så att alla använder sig utav samma generator.
    
        public int Attack()
        {
            int amount = generator.Next(minDmg, maxDmg);//amount är mängden damage dom gör
            return amount;//returnerar amount
        }
        
        public void Hurt(int amount)
        {
            hp -= amount;//hp blir hp - mängden damage.
        }

        public bool IsAlive()
        {
            return hp > 0;//den returnerar så länge hp är större än 0.
        }

        public int GetHp()
        {
            return hp;//Den returnerar det nuvarande HP som kämpen har.
        }
    }
}
