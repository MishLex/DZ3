using UnityEngine;

namespace Visiter
{
    public class EnemySpawner
    {
        private readonly ThreatWeight _threatWeight;
        private readonly CharacterFactory _factory;

        public EnemySpawner(ThreatWeight threatWeight, CharacterFactory factory)
        {
            _threatWeight = threatWeight;
            _factory = factory;
        }

        public void Spawn()
        {
            if(_threatWeight.Value < _threatWeight.MaxValue)
            {
                Character character = Random.Range(0, 3) switch
                {
                    0 => _factory.CreateHuman(),
                    1 => _factory.CreateOrc(),
                    2 => _factory.CreateElf(),

                    _ => throw new System.NotImplementedException(),
                };

                _threatWeight.EnemySpawned(character);               
            }
            else
            {
                Debug.LogWarning($"To many creatures on scene. Weight to high {_threatWeight.Value}. Please KILL someone");
            }
        }
    }
}

