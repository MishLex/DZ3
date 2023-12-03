namespace Decorator.StatProviders
{
    public class DecoratorStatsProvider : IStatProvider
    {
        private readonly IStatProvider _decorated;

        private readonly Stat _int = new();
        private readonly Stat _str = new();
        private readonly Stat _dex = new();

        public DecoratorStatsProvider(IStatProvider decorated, int intOffset, int strOffset, int dexOffset)
        {
            _decorated = decorated;

            _int.Value = _decorated.Intelect.Value + intOffset;
            _str.Value = _decorated.Strength.Value + strOffset;
            _dex.Value = _decorated.Dexterity.Value + dexOffset;
        }

        public IStat Intelect => _int;
        public IStat Strength => _str;
        public IStat Dexterity => _dex;
    }
}
