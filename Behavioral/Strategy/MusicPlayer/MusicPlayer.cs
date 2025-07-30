namespace DesignPatternsPractice.Behavioral.Strategy.MusicPlayer
{
    internal class MusicPlayer
    {
        private IMusicPlayerState currentState;
        public MusicPlayer()
        {
            this.currentState = new StoppedState(this);
        }
        public void SetState(IMusicPlayerState state)
        {
            currentState = state;
        }

        public void Play()
        {
            currentState.Play();
        }
        public void Stop()
        {
            currentState.Stop();
        }

        public void Pause()
        {
            currentState.Pause();
        }
        

    }
}
