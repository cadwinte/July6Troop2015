using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                
            player.SoundLocation = "http://www.wavsource.com/snds_2015-07-05_1837925197659629/movies/cool_hand_luke/failure2_x.wav";
            

            player.SoundLocation = "http://www.wavsource.com/snds_2015-07-05_1837925197659629/movie_stars/misc/gibson_braveheart_freedom.wav";
            

            player.SoundLocation = "http://www.wavsource.com/snds_2015-07-05_1837925197659629/movies/misc/bring_it_on_x.wav";
            

            Random rand = new Random();
            int taco = rand.Next(3);


        }
    }
}
