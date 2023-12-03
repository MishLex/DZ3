using UnityEngine;

namespace Visiter
{
    public class ThreatWeight
    {
        public int Value => _visitor.Weight;
        public int MaxValue { get; }

        private readonly EnemyVisitor _visitor;

        public ThreatWeight(int maxValue)
        {
            MaxValue = maxValue;
            _visitor = new();
        }

        public void EnemySpawned(Character character)
        {
            _visitor.Visit(character);
        }

        private class EnemyVisitor
        {
            public int Weight { get; private set; }
            public void Visit(Character character) => Visit((dynamic) character);
            public void Visit(Human human)
            {
                Weight += 1;
                Debug.Log("Human added" + " Weight " + Weight);
            }

            public void Visit(Orc orc)
            {
                Weight += 3;
                Debug.Log("Orc added" + " Weight " + Weight);
            }

            public void Visit(Elf elf)
            {
                Weight += 2;
                Debug.Log("Elf added" + " Weight " + Weight);
            }
        } 
    }
}
