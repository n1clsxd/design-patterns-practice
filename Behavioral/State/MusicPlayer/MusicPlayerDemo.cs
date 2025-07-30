using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Behavioral.State.MusicPlayer
{
    internal class MusicPlayerDemo : Demo
    {
        public override void Run()
        {
            MusicPlayer musicPlayer = new();

            //stop to pause
            musicPlayer.Pause();
            //stop to stop
            musicPlayer.Stop();
            //stop to play
            musicPlayer.Play();
            //play to play
            musicPlayer.Play();
            //play to stop
            musicPlayer.Stop();
            //stop to play
            musicPlayer.Play();
            //play to pause
            musicPlayer.Pause();
            //pause to pause
            musicPlayer.Pause();
            //pause to play
            musicPlayer.Play();
            //play to pause
            musicPlayer.Pause();
            //pause to stop
            musicPlayer.Stop();
        }
    }
}
