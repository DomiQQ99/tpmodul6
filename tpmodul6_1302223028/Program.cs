using System.Diagnostics;
using System.Reflection;
using System.Text;

internal class Program
{

    class random
    {
        public int idRandom()
        {
            Random id = new Random();
            return id.Next(10000, 99999);
        }
    }
    class sayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;

        public sayaTubeVideo(string title)

        {
            random random = new random();
            this.title = title;
            id = random.idRandom();
            playcount = 0;

        }

        public void increasePlaycount(int playcount)
        {
            this.playcount += playcount;

        }
        public void printVideoDetail()
        {
            Console.WriteLine($"ID :  {this.id}");
            Console.WriteLine($"JUDUL : {this.title}");
            Console.WriteLine($"Play Count : {this.playcount} ");
        }

    }
    private static void Main(string[] args)
    {

        sayaTubeVideo video = new sayaTubeVideo("Tutorial Design by contract - Rifqi Alghifari");
        video.increasePlaycount(2223028);
        video.printVideoDetail();

    }
}