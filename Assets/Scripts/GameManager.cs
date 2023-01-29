using Pages;
using UnityEngine;
using Zenject;

public class GameManager : MonoInstaller
{
    [SerializeField] private SpawnerPage _pageController;
    [SerializeField] private Menu _menu;

    public override void InstallBindings()
    {
        Container.Bind<SpawnerPage>().FromInstance(_pageController).AsSingle();
        Container.Bind<Menu>().FromInstance(_menu).AsSingle();

        Container.Bind<PageController>().AsSingle().NonLazy();
    }
}
