using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    abstract public class Employee //abstract class
    {
        //Properties
        public int EmployeeID
        {
            get; set;
        }

        //abstract methods
        abstract public void CleanCages();
        abstract public void Menu();
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
        public void Feed() //displays message for feed option
        {
            Console.WriteLine("You have fed all of the pets!");
        }

        public void Water() //displays message for water option
        {
            Console.WriteLine("You have given all of the pets water!");
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

        private void ListPets() //loops through two lists and displays user input options
        {
            for (int i = 0; i < VirtualPetShelter.petnames.Count(); i++)
            {
                string valueOne = VirtualPetShelter.petnames[i];
                string valueTwo = VirtualPetShelter.descriptions[i];
                int valueThree = i + 1;
                Console.WriteLine("Press {0} for {1} {2} ", valueThree, valueOne, valueTwo);
            }
        }

        public void Adopt() //loops, prints pets and descriptions and takes user input
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Which pet would you like to adopt?");
                ListPets();
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


    }
}
