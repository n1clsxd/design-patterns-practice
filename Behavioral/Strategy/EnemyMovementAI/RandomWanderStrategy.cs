namespace DesignPatternsPractice.Behavioral.Strategy.EnemyMovementAI
{
    internal class RandomWanderStrategy : IMovementStrategy
    {
        public void Move() => Console.WriteLine("Wandering...");
    }
}
