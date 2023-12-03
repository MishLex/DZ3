namespace Decorator.StatProviders
{
    public class DefaultStatsProvider : IStatProvider
    {
        private readonly Stat _int = new();
        private readonly Stat _str = new();
        private readonly Stat _dex = new();

        public DefaultStatsProvider(int intelect, int strength, int dexterity)
        {
            _int.Value = intelect;
            _str.Value = strength;
            _dex.Value = dexterity;
        }

        public IStat Intelect => _int;
        public IStat Strength => _str;
        public IStat Dexterity => _dex;
    }
}
