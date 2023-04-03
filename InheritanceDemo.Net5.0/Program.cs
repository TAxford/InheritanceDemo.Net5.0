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

            VideoPost videoPost1 = new VideoPost("FailVideo","Timothy Axford",
                "https://video.com/failvideo", true, 10);
            
            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());
            

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            


            Console.ReadLine();
        }
    }
}
