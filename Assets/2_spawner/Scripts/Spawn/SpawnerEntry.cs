using UnityEngine;

namespace Spawner
{
    public class SpawnerEntry : MonoBehaviour
    {
        [SerializeField] private SpawnPoint[] _spawnPoints;
        [SerializeField] private Coin _coinPrefab;
        [SerializeField] private float _spawnTime = 1f;

        private ExcerciseMediator _mediator;
        private PrimitiveInput _input;
        private Timer _timer;

        private void Awake()
        {
            _timer = new Timer(_spawnTime);
            _input = new PrimitiveInput();

            var coins = new Coins();
            var factory = new CoinFactory(_coinPrefab);
            var spawner = new CoinSpawner(_spawnPoints, factory);

            _mediator = new ExcerciseMediator(spawner, coins, _input, _timer);
        }

        private void Update()
        {
            _input.Update();
            _timer.Update(Time.deltaTime);
        }
    }
}
