﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Program
    {
        //Instantiates instances of the classes
        static PetInfo petInfo = new PetInfo();
        static Manager manager = new Manager();
        static Volunteer volunteer = new Volunteer();
        
        //variables
        static string emp;
        static bool play = true;

        //methods
        static void ChooseEmployee() //displays options for employee type, accepts user input, displays choice 
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
                        emp = "vol";
                        IfVolunteer();
                    }
                    else
                    {
                        Console.WriteLine("You chose Manager!");
                        emp = "man";
                        IfManager();
                    }
                }
            } while (loop == true);
        }

        static void IfVolunteer() //Displays menu, accepts user input and calls methods based on input for volunteer
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
                        IfVolunteer();
                        loop = false;
                        break;
                    case 2:
                        volunteer.Feed();
                        IfVolunteer();
                        loop = false;
                        break;
                    case 3:
                        volunteer.Water();
                        IfVolunteer();
                        loop = false;
                        break;
                    case 4:
                        volunteer.Play();
                        IfVolunteer();
                        loop = false;
                        break;
                    case 5:
                        volunteer.CleanCages();
                        IfVolunteer();
                        loop = false;
                        break;
                    case 6:
                        Console.WriteLine("Thanks for playing!");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect response.");
                        break;
                }
            } while (loop == true);
        }

        static void IfManager() //Displays menu, accepts user input and calls methods based on input for manager
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
                        IfManager();
                        loop = false;
                        break;
                    case 2:
                        manager.Play();
                        IfManager();
                        loop = false;
                        break;
                    case 3:
                        manager.CleanCages();
                        IfManager();
                        loop = false;
                        break;
                    case 4:
                        manager.Adopt();
                        IfManager();
                        loop = false;
                        break;
                    case 5:
                        Console.WriteLine("Thank you for playing!");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect response.");
                        break;
                }
            } while (loop == true);
        }
        static void Main(string[] args)
        {
            //adds names to petnames list in static class
            VirtualPetShelter.petnames.Add("Macy");
            VirtualPetShelter.petnames.Add("Magoo");
            VirtualPetShelter.petnames.Add("Barney");

            //adds descriptions to descriptions list in static class
            VirtualPetShelter.descriptions.Add("Miniture Pincher");
            VirtualPetShelter.descriptions.Add("Great Dane");
            VirtualPetShelter.descriptions.Add("Mutt");

            do //loops the game until user wants to exit
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

        
    }
}
