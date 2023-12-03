using System;
using System.Linq;

namespace Spawner
{
    public class CoinSpawner
    {
        public event Action<Coin> CoinSpawned;

        private readonly SpawnPoint[] _spawnPoints;
        private readonly CoinFactory _factory;

        public CoinSpawner(SpawnPoint[] spawnPoints, CoinFactory factory)
        {
            _spawnPoints = spawnPoints;
            _factory = factory;
        }

        public bool TrySpawn()
        {
            SpawnPoint spawnPoint = _spawnPoints.FirstOrDefault(p => p.IsOccupied == false);

            if (spawnPoint != null)
            {
                var coin = _factory.Create();

                coin.transform.position = spawnPoint.transform.position;

                spawnPoint.Occupy(coin);

                CoinSpawned?.Invoke(coin);
            }

            return spawnPoint != null;
        }
    }
}
