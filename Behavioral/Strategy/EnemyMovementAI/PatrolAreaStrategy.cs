namespace DesignPatternsPractice.Behavioral.Strategy.EnemyMovementAI
{
    internal class PatrolAreaStrategy : IMovementStrategy
    {
        public void Move() => Console.WriteLine("Patroling the area.");
    }
}
