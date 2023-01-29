using UnityEngine;
using Zenject;

namespace Pages
{
    [CreateAssetMenu(fileName = "PageInfo", menuName = "Installers/PageInfo")]
    public class PageInfo : ScriptableObjectInstaller<PageInfo>
    {
        [SerializeField] private string _stringContent;
        public string StringContent => _stringContent;

        [SerializeField] private Sprite _spriteLogo;
        public Sprite SpriteLogo => _spriteLogo;

        [SerializeField] private Color _backgroundColor;
        public Color BackgroundColor => _backgroundColor;


        public override void InstallBindings()
        {
            Container.BindInstances(StringContent, SpriteLogo, BackgroundColor);
        }
    }
}