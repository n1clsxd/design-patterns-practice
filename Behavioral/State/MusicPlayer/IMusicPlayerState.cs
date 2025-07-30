namespace DesignPatternsPractice.Behavioral.State.MusicPlayer
{
    internal interface IMusicPlayerState
    {
        void Play();
        void Stop();
        void Pause();
    }
}