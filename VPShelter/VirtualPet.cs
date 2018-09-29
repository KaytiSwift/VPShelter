using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPet
    {
        //Constructors
        public VirtualPet()
        {
            //default constructor
        }

        public VirtualPet(string name, string description)
        {
            Name = name;
            Description = description;
        }
        
        public VirtualPet(string name, string description, int hunger, int potty, int thirst, int boredom)
        {
            Name = name;
            Description = description;
            Hunger = hunger;
            Potty = potty;
            Thirst = thirst;
            Boredom = boredom;
        }

        //Properties
        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public int Hunger
        {
            get; set; 
        }

        public int Potty
        {
            get; set;
        }

        public int Thirst
        {
            get; set;
        }

        public int Boredom
        {
            get; set;
        }

    }
}
