
using System;
namespace Project_7_StaticQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

            //StaticQueueExample();
            StaticPriorityQueueExample();

            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        } //Main

        private static void StaticQueueExample()
        {
            //Create queue
            StaticQueue<string> qNames = new StaticQueue<string>();

            //Enqueue some test data
            qNames.Enqueue("Mike");
            qNames.Enqueue("Thabo");
            qNames.Clear();
            qNames.Enqueue("Lily");
            qNames.Enqueue("Susan");
            qNames.Enqueue("Mary");
            qNames.Dequeue();
            qNames.Enqueue("John");
            qNames.Enqueue("Peter");
            qNames.Enqueue("Hendrik");

            //Peek first element
            Console.WriteLine("\tFirst name: " + qNames.Peek());
            Console.WriteLine();

            Console.WriteLine("\tContains 'Mary': " + qNames.Contains("Mary"));
            Console.WriteLine();

            //Dequeue and print names
            Console.WriteLine("\tList names:");
            Console.Write("\t");
            while (qNames.Count > 0)
                Console.Write(qNames.Dequeue() + ", ");
            Console.WriteLine(); Console.WriteLine();
        } //StaticQueueExample

        private static void StaticPriorityQueueExample()
        {
            //Create queue
            StaticPriorityQueue<string> qNames = new StaticPriorityQueue<string>();

            //Enqueue some test data
            qNames.Enqueue("Mike", 2);
            qNames.Enqueue("Thabo", 3);
            qNames.Enqueue("Lily", 5);
            qNames.Enqueue("Susan", 1);
            qNames.Enqueue("Mary", 1);
            qNames.Dequeue();
            qNames.Enqueue("John",2);
            qNames.Enqueue("Peter", 4);
            qNames.Enqueue("Hendrik", 2);
            qNames.Enqueue("Kgomotso", 3);

            //Peek first element
            Console.WriteLine("\tFirst name: " + qNames.Peek());
            Console.WriteLine();

            if (qNames.Contains("Peter"))
                Console.WriteLine("\tPosition of 'Peter': " + qNames.Position("Peter"));
            else
                Console.WriteLine("\t'Peter' is not in the queue.");
            Console.WriteLine();

            //Dequeue and print names
            Console.Write("\tList names: ");
            while (qNames.Count > 0)
                Console.Write(qNames.Dequeue() + ", ");
            Console.WriteLine();
        } //StaticPriorityQueueExample


    } //class
} //namespace
