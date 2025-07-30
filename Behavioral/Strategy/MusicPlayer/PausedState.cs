namespace DesignPatternsPractice.Behavioral.Strategy.MusicPlayer
{
    internal class PausedState(MusicPlayer player) : IMusicPlayerState
    {
        public void Play()
        {
            Console.WriteLine("Resuming music.");
            player.SetState(new PlayingState(player));
        }
        public void Stop()
        {
            Console.WriteLine("Stopping music.");
            player.SetState(new StoppedState(player));
        }
        public void Pause()
        {
            Console.WriteLine("Already paused.");
        }
    }
}
