using UnityEngine;

namespace Factory
{
    [CreateAssetMenu(fileName = "New IconFactory", menuName = "Icons/IconFactory")]
    public class IconFactory : ScriptableObject, IIconFactory
    {
        [field: SerializeField] public FactoryTypes Type { get; private set; }
        [SerializeField] private Icon IconPrefab;

        public Icon Create()
        {
            return Instantiate(IconPrefab);
        }
    }
}
