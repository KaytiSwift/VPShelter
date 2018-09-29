using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        public string PropVol
        {
            get; set;
        }

        public override void CleanCages()
        {
            Console.WriteLine("The boss says it;s time to clean the cage!");
            Console.WriteLine("You cleaned the cages. Gross!");
        }

        public override void MethodTwo()
        {
            throw new NotImplementedException();
        }

        public void Feed()
        {

        }

        public void Water()
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
