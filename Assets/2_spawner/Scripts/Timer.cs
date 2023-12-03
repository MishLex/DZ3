using System;

namespace Spawner
{
    public class Timer
    {
        public event Action TimeHasCome; //что бы это не значило))

        private readonly float _countTime;
        private float _counter;

        public Timer(float countTime)
        {
            _countTime = countTime;
        }

        public void Update(float deltaTime)
        {
            _counter += deltaTime;

            if( _counter >= _countTime )
            {
                TimeHasCome?.Invoke();
                _counter = 0;
            }
        }
    }
}
