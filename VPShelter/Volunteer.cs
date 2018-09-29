using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        public string PropVol
        {
            get; set;
        }

        public override void CleanCages()
        {
            Console.WriteLine("The boss says it's time to clean the cage!");
            Console.WriteLine("You cleaned the cages. Gross!");
        }

        public override void Menu()
        {
            Console.WriteLine("Thank you for volunteering at the Pet Shelter.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter 1 to view the pets status.");
            Console.WriteLine("Enter 2 to feed all the pets.");
            Console.WriteLine("Enter 3 to give all the pets water.");
            Console.WriteLine("Enter 4 to play with a pet.");
            Console.WriteLine("Enter 5 to clean the cages.");
            Console.WriteLine("Enter 6 to quit.");
        }

        public void Feed()
        {
            Console.WriteLine("You have fed all of the pets!");
        }

        public void Water()
        {
            Console.WriteLine("You have given all of the pets water!");
        }

        public void ViewStats()
        {
            foreach (string name in VirtualPetShelter.petnames)
            {
                Console.WriteLine("Here is the current status of {0}:", name);
                Console.WriteLine("Hunger level is at 6");
                Console.WriteLine("Thirst level is at 2");
                Console.WriteLine("Potty level is at 5");
                Console.WriteLine("Boredom level is at 4");
            }
        }

        public void Play()
        {
            Console.WriteLine("Pick a pet to play with.");
            bool loop = true;
            do
            {
                int i = 1;
                foreach (string name in VirtualPetShelter.petnames)
                {
                    Console.WriteLine("Enter {0} for {1}.", i, name);
                    i = i + 1;
                }
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("You chose {0}.", VirtualPetShelter.petnames[0]);
                        Console.WriteLine("{0} is so happy!", VirtualPetShelter.petnames[0]);
                        loop = false;
                        break;
                    case 2:
                        Console.WriteLine("You chose {0}.", VirtualPetShelter.petnames[1]);
                        Console.WriteLine("{0} is so happy!", VirtualPetShelter.petnames[1]);
                        loop = false;
                        break;
                    case 3:
                        Console.WriteLine("You chose {0}.", VirtualPetShelter.petnames[2]);
                        Console.WriteLine("{0} is so happy!", VirtualPetShelter.petnames[2]);
                        loop = false;
                        break;                    
                    default:
                        Console.WriteLine("Incorrect response. Please try again.");
                        break;
                }
            } while (loop == true);
        }
    }
}
