namespace DesignPatternsPractice.Behavioral.Strategy.MusicPlayer
{
    internal class PlayingState : IMusicPlayerState
    {
        private MusicPlayer musicPlayer;
        public PlayingState(MusicPlayer player) {
            musicPlayer = player;
        }
        public void Play()
        {
            Console.WriteLine("Already playing.");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping music.");
            musicPlayer.SetState(new StoppedState(musicPlayer));
        }
        public void Pause()
        {
            Console.WriteLine("Pausing music");
            musicPlayer.SetState(new PausedState(musicPlayer));
        }

    }
}
