using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Threading.Tasks;
using System.Security.Policy;

namespace WindowsFormsApp3.Forms
{
    public class SongPlayer
    {
        static string SONG = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\phonk_house.mp3";

        MediaPlayer mediaPlayer = new MediaPlayer();
        private string way;

        public void playSong(string way)
        {
            this.way = way;
            mediaPlayer.Open(new Uri(way));
            mediaPlayer.Play();
        }

        public bool isSongMain()
        {
            if (way == SONG)
                return true;
            return false;
        }

        public void Stop()
        {
            mediaPlayer.Close();
        }

        public void SetVolume(double volume)
        {
            mediaPlayer.Volume = volume;
        }
    }
}
