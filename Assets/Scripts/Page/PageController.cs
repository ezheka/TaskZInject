using UnityEngine.SceneManagement;
using Zenject;

namespace Pages
{
    public class PageController
    {
        [Inject]
        public PageController(Menu menu, SpawnerPage spawnerPage)
        {
            Scene scene = SceneManager.CreateScene("Scene Pages");

            foreach (var info in spawnerPage.ListPageInfo)
            {
                Page page = spawnerPage.SpawnPages();
                page.SetInfo(info);

                menu.SpawnButton(info.SpriteLogo).onClick.AddListener(() => spawnerPage.SwitchPage(page));

                SceneManager.MoveGameObjectToScene(page.gameObject, scene);
            }
        }
    }
}
