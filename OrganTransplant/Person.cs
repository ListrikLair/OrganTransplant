using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Person
    {
        public string Name;
        public int NrOfKidneys;
        public string BloodType;

        public Person(string name, int nrOfKidneys, string bloodType)
        {
            Name = name;
            NrOfKidneys = nrOfKidneys;
            BloodType = bloodType;
        }
    }
}
