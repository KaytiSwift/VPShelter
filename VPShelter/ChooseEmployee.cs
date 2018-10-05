using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    static public class ChooseEmployee
    {
        static public string emp;
        static public bool play = true;

        static public void ChooseEmp(int input) //displays options for employee type, accepts user input, displays choice 
        {
            bool loop = true;
            do
            {
                //Console.WriteLine("Please choose what type of employee you'd like to be.");
                //Console.WriteLine("Enter 1 for Volunteer.");
                //Console.WriteLine("Enter 2 for Manager");
                //int input = int.Parse(Console.ReadLine());
                if (input == 1 || input == 2)
                {
                    loop = false;
                    if (input == 1)
                    {
                        Console.WriteLine("You chose Volunteer!");
                        Employee employee = Volunteer;
                        //this doesn't work. How do I get them employee type to change to the specific employee?
                        IfVolunteer(employee);
                    }
                    else
                    {
                        Console.WriteLine("You chose Manager!");
                        emp = "man";
                        IfManager(employee);
                    }
                }
            } while (loop == true);
        }
        static void IfVolunteer(Employee employee) //Displays menu, accepts user input and calls methods based on input for volunteer
        {
            bool loop = true;
            do
            {
                employee.Menu();
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        employee.ViewStats();
                        //IfVolunteer();
                        loop = false;
                        break;
                    case 2:
                        employee.Feed();
                        //IfVolunteer();
                        loop = false;
                        break;
                    case 3:
                        employee.Water();
                        //IfVolunteer();
                        loop = false;
                        break;
                    case 4:
                        employee.Play();
                        //IfVolunteer();
                        loop = false;
                        break;
                    case 5:
                        employee.CleanCages();
                        //IfVolunteer();
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

        static void IfManager(Employee employee) //Displays menu, accepts user input and calls methods based on input for manager
        {
            bool loop = true;
            do
            {
                employee.Menu();
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        employee.ViewStats();
                        //IfManager();
                        loop = false;
                        break;
                    case 2:
                        employee.Play();
                        //IfManager();
                        loop = false;
                        break;
                    case 3:
                        employee.CleanCages();
                        //IfManager();
                        loop = false;
                        break;
                    case 4:
                        employee.Adopt();
                        //IfManager();
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
    }
}
