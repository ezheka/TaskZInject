using System.Collections.Generic;
using UnityEngine;
using Zenject;


namespace Pages
{
    public class SpawnerPage : MonoInstaller
    {
        [SerializeField] private Page _prefabPage;
        public Page PrefabPage => _prefabPage;

        [SerializeField] private List<PageInfo> _listPageInfo;
        public List<PageInfo> ListPageInfo => _listPageInfo;

        private List<Page> _tempListPages = new List<Page>();

        public Page SpawnPages()
        {
            Page page = Instantiate(_prefabPage);
            _tempListPages.Add(page);
            page.ChangeVisibility(_tempListPages.Count == 1);

            return page;
        }

        public void SwitchPage(Page includePage)
        {
            foreach (var page in _tempListPages)
                page.ChangeVisibility(false);

            includePage.ChangeVisibility(true);
        }
    }
}
