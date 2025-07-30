namespace DesignPatternsPractice.Behavioral.Strategy.MusicPlayer
{
    internal class StoppedState(MusicPlayer player) : IMusicPlayerState
    {
        public void Play()
        {
            Console.WriteLine("Playing music.");
            player.SetState(new PlayingState(player));
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
