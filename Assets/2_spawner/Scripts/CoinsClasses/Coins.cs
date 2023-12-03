using System;
using System.Collections.Generic;

namespace Spawner
{
    public class Coins
    {
        public event Action<Coin> CoinCollected;

        private readonly List<Coin> _coins = new();

        public void Add(Coin coin) => _coins.Add(coin);

        public void CollectRandomCoin()
        {
            if(_coins.Count > 0)
            {
                int index = UnityEngine.Random.Range(0, _coins.Count);

                var coin = _coins[index];
               
                coin.Collect();

                _coins.Remove(coin);

                CoinCollected?.Invoke(coin);
            }
        }
    }
}
