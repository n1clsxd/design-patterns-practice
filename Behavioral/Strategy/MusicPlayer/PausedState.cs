namespace DesignPatternsPractice.Behavioral.Strategy.MusicPlayer
{
    internal class PausedState : IMusicPlayerState
    {
        private MusicPlayer musicPlayer;
        public PausedState(MusicPlayer player)
        {
            musicPlayer = player;
        }
        public void Play()
        {
            Console.WriteLine("Resuming music.");
            musicPlayer.SetState(new PlayingState(musicPlayer));
        }
        public void Stop()
        {
            Console.WriteLine("Stopping music.");
            musicPlayer.SetState(new StoppedState(musicPlayer));
        }
        public void Pause()
        {
            Console.WriteLine("Already paused.");
        }
    }
}
