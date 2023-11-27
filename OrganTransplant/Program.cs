namespace OrganTransplant
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            Init();
            void Init()
            {
                
                data.GenerateData();
                Story();
            }

            void Story()
            {
                Console.WriteLine("Oh no! Bernt has been in a horrific accident and is rushing towards the hospital.");
                Console.ReadKey();
                Console.WriteLine("His best friend and partner Kåre is on his way the moment he hears about this tragedy.");
                Console.ReadKey();
                Console.WriteLine("At the hospital, Kåre is told the only thing that could save Bernt is if there is someone with a compatible kidney in the building right now.");
                Console.ReadKey();
                data.ComparePeopleList();
                Console.WriteLine("\nKåre momentarily decides to give his own kidney to save Bernt!");
                Console.ReadKey();
                Console.WriteLine("3 hours later...");
                Console.ReadKey();
                Console.WriteLine("The doctor wakes Kåre up and tells him: \"He will survive! We managed to save his life thanks to you!\"");
                Console.ReadKey();
                Console.WriteLine("And everyone lived happily ever after!");
            }
        }
    }
}