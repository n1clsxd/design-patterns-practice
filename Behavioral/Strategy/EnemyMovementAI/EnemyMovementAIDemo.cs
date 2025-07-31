namespace DesignPatternsPractice.Behavioral.Strategy.EnemyMovementAI
{
    internal class EnemyMovementAIDemo : Demo
    {
        public override void Run()
        {
            Enemy enemy = new();
            Console.WriteLine("zombie spawned");
            enemy.Movement = new PatrolAreaStrategy();
            enemy.ExecuteMovement();
            enemy.Movement = new ChasePlayerStrategy();
            enemy.ExecuteMovement();
            enemy.ExecuteMovement();
            enemy.Movement = new PatrolAreaStrategy();
            enemy.ExecuteMovement();
            enemy.Movement = new RandomWanderStrategy();
            enemy.ExecuteMovement();
        }
    }
}
