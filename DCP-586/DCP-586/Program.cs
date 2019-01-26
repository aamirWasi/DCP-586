using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_586
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            //for test case
            for(int t = 0; t < T; t++)
            {
                //Accepted Code
                string line = Console.ReadLine();
                string[] space = line.Split(' ');
                int BronzeMedalCount = int.Parse(space[0]);
                int SilverMedalCount = int.Parse(space[1]);
                int GoldMedalCount = int.Parse(space[2]);

                int totalMedals = BronzeMedalCount * 10 + SilverMedalCount * 50 + GoldMedalCount * 100;
                Console.WriteLine($"{totalMedals}");
            }
        }
    }
}
