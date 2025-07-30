namespace DesignPatternsPractice.Behavioral.Strategy.MusicPlayer
{
    internal class PlayingState(MusicPlayer player) : IMusicPlayerState
    {
        public void Play()
        {
            Console.WriteLine("Already playing.");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping music.");
            player.SetState(new StoppedState(player));
        }
        public void Pause()
        {
            Console.WriteLine("Pausing music");
            player.SetState(new PausedState(player));
        }

    }
}
