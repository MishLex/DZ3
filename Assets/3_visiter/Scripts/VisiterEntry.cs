using Spawner;
using UnityEngine;

namespace Visiter
{
    public class VisiterEntry : MonoBehaviour
    {
        private const int MAX_WEIGHT = 10;
        private const float SPAWN_TIME = 1f;

        private VisiterMediator _mediator;
        private Timer _timer;

        private void Awake()
        {
            _timer = new Timer(SPAWN_TIME);

            var factory = new CharacterFactory();
            var threatWeight = new ThreatWeight(MAX_WEIGHT);
            var spawner = new EnemySpawner(threatWeight, factory);

            _mediator = new VisiterMediator(spawner, _timer);
        }

        private void Update()
        {
            _timer.Update(Time.deltaTime);
        }
    }
}
