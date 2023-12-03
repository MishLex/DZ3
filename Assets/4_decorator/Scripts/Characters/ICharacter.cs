namespace Decorator.Characters
{
    public interface ICharacter
    {
        RaceTypes Race { get; }
        SpecializationTypes Specialization { get; }
        IStatProvider Stats { get; }

        string ToString();
    }
}