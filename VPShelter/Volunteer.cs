using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        public Volunteer()
        {
            //default constructor
        }

        //Properties
        public int VolunteerDuration 
        {
            get; set;
        }

        //Methods
        public override void CleanCages() //displays a message for cleancages option
        {
            Console.WriteLine("The boss says it's time to clean the cage!");
            Console.WriteLine("You cleaned the cages. Gross!");
        }

        public override void Menu() //displays menu with options for user input
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

        

        
        
    }
}
