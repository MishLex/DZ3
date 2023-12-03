using Decorator.Characters;
using System;
using UnityEngine;

namespace Decorator.Data
{
    [CreateAssetMenu(fileName = "New StatsOffsetsConfig", menuName = "Decorator/StatsOffsetsConfig")]
    public class StatsOffsetsConfig : ScriptableObject
    {
        [field: SerializeField] public RaceOffset[] RaceOffsets { get; private set; }
        [field: SerializeField] public SpecOffset[] SpecOffsets { get; private set; }
    }

    [Serializable]
    public class RaceOffset
    {
        [field: SerializeField] public RaceTypes Race { get; private set; }
        [field: SerializeField] public int INT { get; private set; }
        [field: SerializeField] public int STR { get; private set; }
        [field: SerializeField] public int DEX { get; private set; }
    }

    [Serializable]
    public class SpecOffset
    {
        [field: SerializeField] public SpecializationTypes Spec { get; private set; }
        [field: SerializeField] public int INT { get; private set; }
        [field: SerializeField] public int STR { get; private set; }
        [field: SerializeField] public int DEX { get; private set; }
    }
}
