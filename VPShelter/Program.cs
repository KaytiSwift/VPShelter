using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            PetInfo petInfo = new PetInfo();
            Manager manager = new Manager();
            Volunteer volunteer = new Volunteer();

            VirtualPetShelter.petnames.Add("Macy");
            VirtualPetShelter.petnames.Add("Magoo");
            VirtualPetShelter.petnames.Add("Barney");

            VirtualPetShelter.descriptions.Add("Miniture Pincher");
            VirtualPetShelter.descriptions.Add("Great Dane");
            VirtualPetShelter.descriptions.Add("Mutt");

            do
            {
                Console.WriteLine("Welcome to the Pet Shelter!");
                ChooseEmployee();
                
                Console.WriteLine("Do you want to play again? Press enter to continue or \"no\" to quit.");
                string input = Console.ReadLine().ToLower();
                if (input == "no")
                {
                    play = false;
                }
            } while (play == true);


            
        }

        static void ChooseEmployee()
        {
            Console.WriteLine("Please choose what type of employee you'd like to be.");
            Console.WriteLine("Enter 1 for Volunteer.");
            Console.WriteLine("Enter 2 for Manager");
            int input = int.Parse(Console.ReadLine());
            if (input == 1 || input == 2)
            { if  (input == 1 )
                {
                    Console.WriteLine("You chose Volunteer!");
                    IfVolunteer();                   
                }
              else
                {
                    Console.WriteLine("You chose Manager!");
                    IfManager();
                }
            }
            else
            {
                Console.WriteLine("You did not make a valid selection.");
            }

        }

        static void IfVolunteer()
        {

        }

        static void IfManager()
        {

        }
    }
}
