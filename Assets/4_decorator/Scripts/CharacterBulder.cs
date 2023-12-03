using Decorator.Characters;
using Decorator.Data;
using Decorator.StatProviders;
using System.Linq;

namespace Decorator
{
    public class CharacterBulder
    {
        private readonly StatsOffsetsConfig _config;
        private readonly DefaultStatsConfig _defaultStatConfig;
        private Character _character;
        private IStatProvider _statProvider;

        public CharacterBulder(StatsOffsetsConfig offsetsConfig, DefaultStatsConfig defaultStatConfig)
        {
            _config = offsetsConfig;
            _defaultStatConfig = defaultStatConfig;
            _character = new Character();

            _statProvider = new DefaultStatsProvider(_defaultStatConfig.Intelect, _defaultStatConfig.Strength, _defaultStatConfig.Dexterety);
        }

        public CharacterBulder BuildRace(RaceTypes race)
        {
            _character.Race = race;

            RaceOffset statOffset = GetRaceOffset(race);
            _statProvider = new DecoratorStatsProvider(_statProvider, statOffset.INT, statOffset.STR, statOffset.DEX);

            return this;
        }

        public CharacterBulder BuildSpecialization(SpecializationTypes specialization)
        {
            _character.Specialization = specialization;

            SpecOffset offset = GetSpecOffset(specialization);
            _statProvider = new DecoratorStatsProvider(_statProvider, offset.INT, offset.STR, offset.DEX);

            return this;
        }

        public ICharacter GetResult()
        {
            _character.Stats = _statProvider;

            return _character;
        }

        private RaceOffset GetRaceOffset(RaceTypes race) => _config.RaceOffsets.First(s => s.Race == race);
        private SpecOffset GetSpecOffset(SpecializationTypes spec) => _config.SpecOffsets.First(s => s.Spec == spec);
    }
}
