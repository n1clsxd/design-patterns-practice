namespace DesignPatternsPractice.Behavioral.Strategy.MusicPlayer
{
    internal class StoppedState : IMusicPlayerState
    {
        private MusicPlayer musicPlayer;
        public StoppedState(MusicPlayer player)
        {
            musicPlayer = player;
        }
        public void Play()
        {
            Console.WriteLine("Playing music.");
            musicPlayer.SetState(new PlayingState(musicPlayer));
        }
        public void Stop()
        {
            Console.WriteLine("Already stopped.");
        }
        public void Pause()
        {
            Console.WriteLine("Can't pause. Nothing is playing.");
        }
    }
}
