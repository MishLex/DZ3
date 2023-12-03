namespace Decorator.Characters
{
    public class Character : ICharacter
    {
        public RaceTypes Race { get; set; }
        public SpecializationTypes Specialization { get; set; }
        public IStatProvider Stats { get; set; }

        public override string ToString()
        {
            return
                $"Character - Race - {Race}\n" +
                $"Specialization - {Specialization} " +
                $"INT - {Stats.Intelect.Value}, STR - {Stats.Strength.Value}, DEX - {Stats.Dexterity.Value}";
        }
    }
}
