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
            Debug.Assert(title.Length <= 100 && title != null, "Jumlah kata melebihi batas");
            this.title = title;
            id = random.idRandom();
            playcount = 0;

        }

        public void increasePlaycount(int playcount)
        {
            this.playcount += playcount;

            Debug.Assert(playcount <= 10000000, "Error: Jumlah playcount melebihi batas");
            try
            {
                checked
                {
                    this.playcount = playcount;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada penambahan play count.");
            }

        }
        public void printVideoDetail()
        {
            Console.WriteLine($"id :  {this.id}");
            Console.WriteLine($"id :  {id}");
            Console.WriteLine($"judul : {this.title}");
            Console.WriteLine($"Play count : {this.playcount} ");
        }

    }
    private static void Main(string[] args)
    {

        sayaTubeVideo video = new sayaTubeVideo("Tutorial Design by contract - Rifqi Alghifari");
        video.increasePlaycount(2223028);
        video.printVideoDetail();

    }
}