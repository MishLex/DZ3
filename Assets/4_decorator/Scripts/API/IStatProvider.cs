namespace Decorator
{
    public interface IStatProvider
    {
        IStat Intelect { get; }
        IStat Strength { get; }
        IStat Dexterity { get; }
    }
}
