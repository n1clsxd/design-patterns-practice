namespace DesignPatternsPractice.Behavioral.Strategy.EnemyMovementAI
{
    internal class Enemy
    {
        public IMovementStrategy Movement { private get; set; }
        public void ExecuteMovement() => Movement.Move();
    }
}
