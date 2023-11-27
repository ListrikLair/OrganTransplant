using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Data
    {
        public static List<Person> peopleList = new List<Person>();

        public void GenerateData()
        {
            peopleList.Add(new Person("Bernt", 0, "B+"));
            peopleList.Add(new Person("Berit", 1, "B-"));
            peopleList.Add(new Person("Arne", 2, "AB-"));
            peopleList.Add(new Person("Kåre", 2, "O+"));
            peopleList.Add(new Person("Karl Bertil", 1, "AB+"));
        }

        public void ComparePeopleList()
        {
            foreach (var person in peopleList)
            {
                if (person.Name == "Bernt")
                {
                    continue;
                }
                if (!CheckIfCompatible(person))
                {
                    Console.WriteLine($"{person.Name} is not compatible with Bernt.");
                }
                else
                {
                    Console.WriteLine($"{person.Name} is compatible with Bernt!");
                }
            }
        }
        static bool CheckIfCompatible(Person person)
        {
            bool trueOrFalse = true;
            Console.WriteLine();
            if (!CheckNrOfKidneys(person))
            {
                Console.WriteLine($"{person.Name} has only {person.NrOfKidneys} kidneys, they can't give up one for him!");
                trueOrFalse = false;
            } if (!CheckBloodType(person))
            {
                Console.WriteLine($"{person.Name}'s blood type ({person.BloodType}) does not match with Bernt's({peopleList[0].BloodType}).");
                trueOrFalse = false;
            }
            return trueOrFalse;
        }

        static bool CheckNrOfKidneys(Person person)
        {
            if (person.NrOfKidneys < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool CheckBloodType(Person person)
        {
            switch (person.BloodType)
            {
                case "B+":
                    return true;
                    break;
                case "B-":
                    return true;
                    break;
                case "O+":
                    return true;
                    break;
                case "O-":
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }
    }
}
