using UnityEngine;

namespace Decorator.Data
{
    [CreateAssetMenu(fileName = "New DefaultStatsConfig", menuName = "Decorator/DefaultStatsConfig")]
    public class DefaultStatsConfig : ScriptableObject
    {
        [field: SerializeField, Range(5, 10)] public int Intelect { get; private set; } = 5;
        [field: SerializeField, Range(5, 10)] public int Strength { get; private set; } = 5;
        [field: SerializeField, Range(5, 10)] public int Dexterety { get; private set; } = 5;
    }
}
