namespace DesignPatternsPractice.Behavioral.Strategy.EnemyMovementAI
{
    internal class ChasePlayerStrategy : IMovementStrategy
    {
        public void Move() => Console.WriteLine("Chasing the player.");
    }
}
