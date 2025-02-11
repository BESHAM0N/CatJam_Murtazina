﻿using UnityEngine;
using Zenject;

namespace CatJam
{
    public sealed class UIInstaller : MonoInstaller
    {
        [SerializeField] private EntitiesView _entitiesView;
        public override void InstallBindings()
        {
            Container.Bind<IGameUI>().FromComponentInHierarchy().AsSingle().NonLazy();
            Container.BindInterfacesTo<EntitisPresenter>().AsSingle().NonLazy();
            ScoreInstaller.Install(Container, _entitiesView);
        }
    }
}