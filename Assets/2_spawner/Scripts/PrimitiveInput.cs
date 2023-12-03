using System;
using UnityEngine;

namespace Spawner
{
    public class PrimitiveInput
    {
        public event Action CollectInputReceived;

        public void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
                CollectInputReceived?.Invoke();
        }
    }
}