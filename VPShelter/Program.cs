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
