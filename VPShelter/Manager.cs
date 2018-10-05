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

        

        
           
               
    }
}
