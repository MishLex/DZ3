using UnityEngine;

namespace Factory
{
    public class IconSpawner : MonoBehaviour
    {
        [SerializeField] private RectTransform _parent;

        private IIconFactory _iconFactory;

        public void Setup(IIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public void Spawn()
        {
            Icon icon = _iconFactory.Create();

            icon.transform.SetParent(_parent);
            icon.RectTransform.anchoredPosition = Vector3.zero;
        }
    }
}
