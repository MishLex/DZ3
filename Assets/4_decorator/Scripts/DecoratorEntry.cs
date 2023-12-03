using Decorator.Characters;
using Decorator.Data;
using UnityEngine;

namespace Decorator
{
    public class DecoratorEntry : MonoBehaviour
    {
        [SerializeField] private DefaultStatsConfig _defStats;
        [SerializeField] private StatsOffsetsConfig _statOffsets;
        [SerializeField] private RaceTypes _race;
        [SerializeField] private SpecializationTypes _specialization;

        private void Awake()
        {
            var charBuilder = new CharacterBulder(_statOffsets, _defStats);

            var character = charBuilder
                .BuildRace(_race)
                .BuildSpecialization(_specialization)
                .GetResult();

            Debug.Log(character.ToString());
        }
    }
}
