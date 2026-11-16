using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht5
    {
        int j;
        int k;
        public void Start()
        {
            
            Console.WriteLine("Welke tafel wil je berekenen?");
            string tafel = Console.ReadLine();

            if (Int32.TryParse(tafel, out j))
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
            string hoever = Console.ReadLine();
        
            if (Int32.TryParse(hoever, out k))
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
            for(int i = 1; i <= k; i++)
            {
                Console.WriteLine(j+" x "+i+" = "+i*j);
            }

        }
    }
}
