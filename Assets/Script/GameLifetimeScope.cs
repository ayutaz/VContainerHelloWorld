﻿using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace MyGame
{
    public class GameLifetimeScope : LifetimeScope
    {
        [SerializeField] private HelloScreen helloScreen;
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<HelloWorldService>(Lifetime.Singleton);
            builder.RegisterEntryPoint<GamePresenter>();
            builder.RegisterComponent(helloScreen);
        }
    }
}