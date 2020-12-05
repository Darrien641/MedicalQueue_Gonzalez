using System;

namespace MedicalQueue_Gonzalez
{
    class Program
    {
        static void Main(string[] args)
        {
            ERQueue MedQueue = new ERQueue();
            string input = "";
            while (input.ToUpper() != "Q")
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine(MedQueue.Menu());
                input = Console.ReadLine();
                if (input.ToUpper() == "A")
                {
                    string name;
                    int priority;
                    Console.WriteLine("What is the patients first name?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the patients priority?");
                    priority = int.Parse(Console.ReadLine());
                    Console.WriteLine($"There are now {MedQueue.Enqueue(name, priority)} Patient(s) in the ERQueue\n");
                }
                if (input.ToUpper() == "P")
                {

                    Console.WriteLine($"\n{MedQueue.Dequeue()}");

                }
                if (input.ToUpper() == "L")
                {
                    Console.WriteLine($"\n{MedQueue.ToString()}");
                }

            }
        }
    }
}
