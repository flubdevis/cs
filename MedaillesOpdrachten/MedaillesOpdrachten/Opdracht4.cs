using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht4
    {
        public void Start()
        {
            Console.WriteLine("Wat is je geboortejaar?");
            string temp = Console.ReadLine();
            int i;
            if (Int32.TryParse(temp, out i))
            {
                int j = 2026 - i;
                
                if (j >= 18 && j < 22)
                {
                  Console.WriteLine("je bent " + j + " jaar oud! Je bent oud genoeg om te stemmen.");
                }
                else if (j >= 22 && j < 65)
                {
                  Console.WriteLine("je bent " + j + " jaar oud! Je bent oud genoeg om te stemmen en je bent een volwassene");
                }
                else if (j >= 65)
                {
                  Console.WriteLine("u bent " + j + " jaar oud. Zo, dat is oud! U bent oud genoeg om te stemmen en je bent bejaard");
                }
                else
                {
                  Console.WriteLine("je bent " + j + " jaar oud! Je bent niet oud genoeg om te stemmen");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("vul alleen een getal in!\n");
                Start();
            }
        }
    }
}
