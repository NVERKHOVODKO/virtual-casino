using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    internal class Player
    {
        static System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();

        public static void Play(string fileName)
        {
            try
            {
                soundPlayer.SoundLocation = fileName;
                soundPlayer.Play();
            }
            catch
            {
                MessageBox.Show("Can't find music" + fileName);
            }            
        }

        public static void Stop()
        {
            soundPlayer.Stop();
        }
        
    }
}
