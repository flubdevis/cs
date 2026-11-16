using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht5
    {
        int tafel;
        int hoever;
        public void Start()
        {
            
            Console.WriteLine("Welke tafel wil je berekenen?");
            string tafelinput = Console.ReadLine();

            if (Int32.TryParse(tafelinput, out tafel))
            {
                HoeVer();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("vul alleen een getal in!\n");
                Start();
            }


        }

        public void HoeVer()
        {
            Console.WriteLine("Hoever wil je rekenen");
            string hoeverinput = Console.ReadLine();
        
            if (Int32.TryParse(hoeverinput, out hoever))
            {
                Bereken();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("vul alleen een getal in!\n");
                HoeVer();
            }
        }

        public void Bereken()
        {
            for(int i = 1; i <= hoever; i++)
            {
                Console.WriteLine(tafel+" x "+i+" = "+i*tafel);
            }

        }
    }
}
