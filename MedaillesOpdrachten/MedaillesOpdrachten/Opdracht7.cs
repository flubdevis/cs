using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht7
    {
        int howMany;
        public void Start()
        {
            Console.WriteLine("Hoeveel dobbelsteenworpen wil je simuleren?");
            String choice = Console.ReadLine();
            if (Int32.TryParse(choice, out howMany))
            {
                Console.WriteLine("\n"+howMany+ " Worpen!\n");
                Worp worp = new Worp(howMany);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("vul alleen een getal in!\n");
                Start();
            }
        }

        public class Worp
        {
            int repeat;
            int[] numbers;
            Random rnd = new Random();
            public Worp(int Repeat)
            {
                repeat = Repeat;
                numbers = new int[repeat];
                NewWorp();
            }

            public void NewWorp()
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(1, 7);
                    //Console.WriteLine(numbers[i]);
                }
                Calc();
            }

            public void Calc()
            {
                Console.WriteLine("Berekenen hoevaak elk getal voorkomt...\n");
                int[] count = new int[6];
                double[] percentage = new double[6];
                int highest = count[0];
                int MostThrown = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    count[numbers[i] - 1]++;
                }

                for (int i = 0; i < count.Length; i++)
                {
                   if(count[i] > highest)
                    {
                        highest = count[i];
                        MostThrown = i + 1;
                    }
                }

                for (int i = 0; i < count.Length; i++)
                {
                    percentage[i] = (double)count[i] / repeat * 100;
                }

                for (int i = 0; i < count.Length; i++)
                {
                    Console.WriteLine((i + 1) + " komt " + count[i] +
        " keer voor (" + percentage[i] + "%)");
                }
                Console.WriteLine("\nJe meest gegooide getal is "+MostThrown+" (" + highest +" keer!)\n");
            }
        }
    }
}
