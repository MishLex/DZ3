namespace Spawner
{
    public class ExcerciseMediator
    {
        private readonly CoinSpawner _spawner;
        private readonly Coins _coins;
        private readonly PrimitiveInput _input;
        private readonly Timer _timer;

        public ExcerciseMediator(CoinSpawner spawner, Coins coins, PrimitiveInput input, Timer timer)
        {
            _spawner = spawner;
            _coins = coins;
            _input = input;
            _timer = timer;

            _spawner.CoinSpawned += CoinSpawned;
            _input.CollectInputReceived += CollectInputReceived;
            _timer.TimeHasCome += TimeHasCome;
        }

        private void TimeHasCome() => _spawner.TrySpawn();
        private void CollectInputReceived() => _coins.CollectRandomCoin();
        private void CoinSpawned(Coin coin) => _coins.Add(coin);
    }
}
