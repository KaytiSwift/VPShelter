using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee
    {
        public Manager()
        {
            //default constructor
        }
        
        //properties
        public double Salary
        {
            get; set;
        }

        //Methods
        public override void CleanCages() //displays a message for cleancages option
        {
            Console.WriteLine("Better call a volunteer to clean the cages!");
            Console.WriteLine("You had a volunteer clean the cages.");
        }

        public override void Menu() //displays menu with options for user input
        {
            Console.WriteLine("Hello Manager at the Pet Shelter.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter 1 to view the pets status.");
            Console.WriteLine("Enter 2 to play with a pet.");
            Console.WriteLine("Enter 3 to clean the cages.");
            Console.WriteLine("Enter 4 to adopt a pet.");
            Console.WriteLine("Enter 5 to quit.");
        }

        public void Adopt() //loops, prints pets and descriptions and takes user input
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Which pet would you like to adopt?");
                Loop();
                int input = int.Parse(Console.ReadLine().ToLower());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("You have adopted {0}!", VirtualPetShelter.petnames[0]);
                        loop = false;
                        break;
                    case 2:
                        Console.WriteLine("You have adopted {0}!", VirtualPetShelter.petnames[1]);
                        loop = false;
                        break;
                    case 3:
                        Console.WriteLine("You have adopted {0}!", VirtualPetShelter.petnames[2]);
                        loop = false;
                        break;
                    default:
                        break;
                }
            } while (loop == true);
        }

        private void Loop() //loops through two lists and displays user input options
        {
            for (int i = 0; i < VirtualPetShelter.petnames.Count(); i++)
            {
                string valueOne = VirtualPetShelter.petnames[i];
                string valueTwo = VirtualPetShelter.descriptions[i];
                int valueThree = i + 1;
                Console.WriteLine("Press {0} for {1} {2} ", valueThree, valueOne, valueTwo);
            }
        }

        public void ViewStats() //loops through petnames list and displays status
        {
            foreach (string name in VirtualPetShelter.petnames)
            {
                Console.WriteLine("Here is the current status of {0}:", name);
                Console.WriteLine("Hunger level is at 6");
                Console.WriteLine("Thirst level is at 2");
                Console.WriteLine("Potty level is at 5");
                Console.WriteLine("Boredom level is at 4");
            }//These are hard coded because I wasn't sure what the best way was to update them.
            //This method could have been in Employee class but is here for assignment requirements
        }

        public void Play() //loops through petnames list, displays available pets and accepts user input
                           //This method could have been in Employee class but is here for assignment requirements
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
