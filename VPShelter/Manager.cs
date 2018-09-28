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

        public override void MethodTwo()
        {
            throw new NotImplementedException();
        }

        public void Adopt()
        {

        }

        public void ViewStat()
        {

        }

        public void Play()
        {

        }

    }
}
