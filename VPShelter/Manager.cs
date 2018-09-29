using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee
    {
        public string PropMan
        {
            get; set;
        }

        public override void CleanCages()
        {
            Console.WriteLine("Better call a volunteer to clean the cages!");
            Console.WriteLine("You had a volunteer clean the cages.");
        }

        public override void Menu()
        {
            throw new NotImplementedException();
        }

        public void Adopt()
        {
            Console.WriteLine("Which pet would you like to adopt?");
            for (int i = 0; i < VirtualPetShelter.petnames.Count(); i++)
            {
                string valueOne = VirtualPetShelter.petnames[i];
                string valueTwo = VirtualPetShelter.descriptions[i];
                int valueThree = i + 1;
                Console.WriteLine("Press {0} for {1} {2} ", valueThree, valueOne, valueTwo);
            }
            int input = int.Parse(Console.ReadLine().ToLower());
            switch (input)
            {
                case 1:
                    Console.WriteLine("You have adopted {0}!", VirtualPetShelter.petnames[0]);
                    break;
                case 2:
                    Console.WriteLine("You have adopted {0}!", VirtualPetShelter.petnames[1]);
                    break;
                case 3:
                    Console.WriteLine("You have adopted {0}!", VirtualPetShelter.petnames[2]);
                    break;
                default:
                    Console.WriteLine("You have not adopted a pet.");
                    break;
            }
        }

        public void ViewStat()
        {

        }

        public void Play()
        {

        }

    }
}
