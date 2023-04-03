using System;

namespace InheritanceDemo.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object of Post class
            Post post1= new Post("Thanks for the birthday wished", true, "Timothy Axford");
            Console.WriteLine(post1.ToString());
            Console.ReadLine();
        }
    }
}
