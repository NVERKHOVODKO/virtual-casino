using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;



namespace WindowsFormsApp3
{
    internal class SoundPlayer
    {
        static MediaPlayer player = new MediaPlayer();
   
        public static void Play(string fileName)
        {
            try
            {
                player.Open(new Uri(fileName));
                player.Play();
            }
            catch
            {
                MessageBox.Show("Can't find music" + fileName);
            }            
        }

        public static void Stop()
        {
            player.Stop();
        }
        
    }
}
