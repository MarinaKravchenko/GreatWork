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
            FindSongs(context, "Andrew Peters");
        }

        static Song[] FindSongs(Context context, string SingerName)
        {
            var rezult = context.Songs.Where(e => e.Singer.Name == SingerName);
            return rezult.OrderBy(e => e.Name).ToArray().ToArray();
        }
    }
}
