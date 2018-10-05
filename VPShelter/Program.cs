using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Program
    {
        //Instantiates instances of the classes
        PetInfo petInfo = new PetInfo();
        Manager manager = new Manager();
        Volunteer volunteer = new Volunteer();
        
        
        //variables
        private string emp;
        private bool play = true;
               
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
                Console.WriteLine("Please choose what type of employee you'd like to be.");
                Console.WriteLine("Enter 1 for Volunteer.");
                Console.WriteLine("Enter 2 for Manager");
                int input = int.Parse(Console.ReadLine());
                //ChooseEmployee chooseEmployee = new ChooseEmployee();
                ChooseEmployee.ChooseEmp(input);
                //This doesn't work. How do I call this when the user input is defined within the method itself?
                Console.WriteLine("Do you want to play again? Press enter to continue or \"no\" to quit.");
                string input2 = Console.ReadLine().ToLower();
                if (input2 == "no")
                {
                    play = false;
                }
            } while (play == true);


            
        }

        
    }
}
