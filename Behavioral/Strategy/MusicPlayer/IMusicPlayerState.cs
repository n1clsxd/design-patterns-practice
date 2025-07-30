namespace DesignPatternsPractice.Behavioral.Strategy.MusicPlayer
{
    internal interface IMusicPlayerState
    {
        void Play();
        void Stop();
        void Pause();
    }
}