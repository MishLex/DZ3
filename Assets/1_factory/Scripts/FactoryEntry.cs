using System.Linq;
using UnityEngine;

namespace Factory
{
    public class FactoryEntry : MonoBehaviour
    {
        [SerializeField] private FactoryTypes _factoryTargetType;
        [SerializeField] private IconSpawner _iconSpawner;
        [SerializeField] private IconFactory[] _factories;

        private void Awake()
        {
            var targetFactory = _factories.First(f => f.Type == _factoryTargetType);

            _iconSpawner.Setup(targetFactory);

            _iconSpawner.Spawn();
        }
    }
}
