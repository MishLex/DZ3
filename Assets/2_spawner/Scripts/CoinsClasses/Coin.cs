using System;
using UnityEngine;

namespace Spawner
{
    public class Coin : MonoBehaviour, ISpawnedObject
    {
        public event Action Released;

        public void Collect()
        {            
            Released?.Invoke(); //можно было бы подписать на это событие пул
                                //и он бы помещал данный объект в "свободные"
                                //для дальнейшей передачи в фабрику

            Destroy(gameObject); // и не уничтожать объект, а выключать
        }
    }
}
