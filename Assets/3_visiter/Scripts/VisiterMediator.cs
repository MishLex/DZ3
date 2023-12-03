using Spawner;

namespace Visiter
{
    public class VisiterMediator
    {
        private readonly EnemySpawner _enemySpawner;
        private readonly Timer _timer;

        public VisiterMediator(EnemySpawner enemySpawner, Timer timer)
        {
            _enemySpawner = enemySpawner;
            _timer = timer;

            _timer.TimeHasCome += TimeHasCome;
        }

        private void TimeHasCome()
        {
            _enemySpawner.Spawn();
        }
    }
}
