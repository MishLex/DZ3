using UnityEngine;

namespace Spawner
{
    public class CoinFactory
    {
        private readonly Coin _coinPrefab;

        public CoinFactory(Coin coinPrefab)
        {
            _coinPrefab = coinPrefab;
        }

        public Coin Create()
        {
            return Object.Instantiate(_coinPrefab);
        }
    }
}
