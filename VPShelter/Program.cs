using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Program
    {
        static PetInfo petInfo = new PetInfo();
        static Manager manager = new Manager();
        static Volunteer volunteer = new Volunteer();
        
        static void Main(string[] args)
        {
            bool play = true;
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
            bool loop = true;
            do
            {
                Console.WriteLine("Please choose what type of employee you'd like to be.");
                Console.WriteLine("Enter 1 for Volunteer.");
                Console.WriteLine("Enter 2 for Manager");
                int input = int.Parse(Console.ReadLine());
                if (input == 1 || input == 2)
                {
                    loop = false;
                    if (input == 1)
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
            } while (loop == true);
        }

        static void IfVolunteer()
        {
            bool loop = true;
            do
            {
                volunteer.Menu();
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        volunteer.ViewStats();
                        loop = false;
                        break;
                    case 2:
                        volunteer.Feed();
                        loop = false;
                        break;
                    case 3:
                        volunteer.Water();
                        loop = false;
                        break;
                    case 4:
                        volunteer.Play();
                        loop = false;
                        break;
                    case 5:
                        volunteer.Play();
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect response.");
                        break;
                }
            } while (loop == true); 
        }

        static void IfManager()
        {
            bool loop = true;
            do
            {
                manager.Menu();
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        manager.ViewStats();
                        loop = false;
                        break;                 
                    case 2:
                        manager.Play();
                        loop = false;
                        break;
                    case 3:
                        manager.CleanCages();
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect response.");
                        break;
                }
            } while (loop == true);
        }        
    }
}
