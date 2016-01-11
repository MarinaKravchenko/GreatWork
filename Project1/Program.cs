using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {

        static void Main(string[] args)
        {
            Context context = new Context();
            List<Song> songs = new List<Song>();
            songs = FindSongs(context, "Andrew Peters");
            if (songs.Count != 0)
            {
                Console.WriteLine(songs[0].Name);
            }
        }

        static List<Song> FindSongs(Context context, string SingerName)
        {
            var rezult = context.Songs.Where(e => e.Singer.Name == SingerName);
            return rezult.OrderBy(e => e.Name).ToArray().ToList();
        }
    }
}
