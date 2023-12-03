namespace Visiter
{
    public class CharacterFactory
    {
        public Human CreateHuman() => new Human();
        public Orc CreateOrc() => new Orc();
        public Elf CreateElf() => new Elf();
    }
}
