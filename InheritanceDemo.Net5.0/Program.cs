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
            
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Timothy Axford", "https://images.com/shoes", true);

            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
