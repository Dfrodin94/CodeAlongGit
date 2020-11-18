using System;
using System.Linq;

namespace CodeAlongGit
{
    class Program
    {
        static void Main(string[] args)
        {

            // galen kod ? == CTRL + k, CTRL + d

            int[] coolArray = new int[5];

            coolArray[0] = 13;
            coolArray[1] = 25;
            coolArray[2] = 22;
            coolArray[3] = 7;
            coolArray[4] = 1;

            Console.WriteLine("Did you pick a lucky number today? ");
            string nr = Console.ReadLine();
            int myNr = Convert.ToInt32(nr);

            for (int i = 0; i < coolArray.Length; i++)
            {
                if (myNr == coolArray[i])
                {
                    Console.WriteLine("Grattis, coolt!");
                    break;
                }
                else
                {
                    Console.WriteLine("Bättre lycka nästa gång");
                }
            }

            Console.WriteLine(coolArray.Contains(1)); // bra metod, equlas.true 

        }
    }
}
