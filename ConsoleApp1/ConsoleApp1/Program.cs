using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            fighter A = new fighter();//skapar en ny fighter
            fighter B = new fighter();//skapar en till

            Console.WriteLine("NAME FOR FIGHTER A:");

            A.Name = Console.ReadLine();//det man skriver in blir nmanet på A
            Console.WriteLine("FIGHTER A's NAME IS NOW: "+A.Name+".");
            Console.ReadLine();

            Console.WriteLine("NAME FOR FIGHTER B:");

            B.Name = Console.ReadLine();//det man skriver in blir nmanet på A
            Console.WriteLine("FIGHTER B's NAME IS NOW: " + B.Name + ".");
            Console.ReadLine();
            Console.Clear();

            while (A.IsAlive() && B.IsAlive())//så länge a och b lever så körs loopen
            {
                B.Hurt(A.Attack());//B.Hurt tar in A.attacks int amount som dess skada tagen
                A.Hurt(B.Attack());//Samma sak fast tvärt om

                Console.WriteLine(A.Name+" HP är: "+A.GetHp());//skriver ut det uppdaterade HP:t
                Console.WriteLine(B.Name + " HP är: "+B.GetHp());//skriver ut det uppdaterade HP:t
                Console.ReadLine();
                Console.Clear();
            }

            if (A.IsAlive()==false)//Ifall A icke lever så vinner B
            {
                Console.WriteLine("CONGRATULATIONS "+B.Name+"!"+
                    " YOU WON!");
                Console.ReadLine();
            }
            else//Om a lever & B inte så körs denna
            {
                Console.WriteLine("CONGRATULATIONS " + A.Name +"!" +
                    " YOU WON!");
                Console.ReadLine();
            }
        }
    }
}
