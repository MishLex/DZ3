using UnityEngine;

namespace Spawner
{
    public class SpawnPoint : MonoBehaviour
    {
        public bool IsOccupied => _spawned != null;

        private ISpawnedObject _spawned;

        public void Occupy(ISpawnedObject spawned)
        {
            _spawned = spawned;
            _spawned.Released += SpawnedReleased;
        }

        private void SpawnedReleased()
        {
            _spawned.Released -= SpawnedReleased;
            _spawned = null;
        }
    }
}
