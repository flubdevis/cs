using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdrachten
{
    internal class Opdracht4
    {
        int age;
        int year;
        public void Start()
        {
            Console.WriteLine("Wat is je geboortejaar?");
            string temp = Console.ReadLine();
            if (Int32.TryParse(temp, out year))
            {
                age = 2026 - year;
                checkAge();
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("vul alleen een getal in!\n");
                Start();
            }
        }

        public void checkAge()
        {
            if(age >= 18)
            {
                Console.WriteLine("Je bent " + age + " jaar oud! Je bent oud genoeg om te stemmen.");
                msg();
            }
            else
            {
                Console.WriteLine("Je bent " + age + " jaar oud! Je bent niet oud genoeg om te stemmen");
            }
        }

             public void msg()
        {

            if (age >= 18 && age < 25)
            {
                Console.WriteLine("Je hersenen zijn nog niet volgroeid!");
            }
            else if (age >= 25 && age < 45)
            {
                Console.WriteLine("Je bent nu volwassenen");
            }
            else if (age >= 45)
            {
                Console.WriteLine("Zo, dat is oud!");
            }
        }


    }
}
