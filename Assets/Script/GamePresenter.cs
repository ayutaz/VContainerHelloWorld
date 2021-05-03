using System;
using UniRx;
using VContainer.Unity;

namespace MyGame
{
    public class GamePresenter : IStartable,IDisposable
    {
        private readonly HelloWorldService _helloWorldService;
        private readonly IHelloScreen _helloScreen;
        private readonly CompositeDisposable _compositeDisposable = new CompositeDisposable();

        public GamePresenter(HelloWorldService helloWorldService,HelloScreen helloScreen)
        {
            _helloWorldService = helloWorldService;
            _helloScreen = helloScreen;
        }

        void IStartable.Start()
        {
            _helloScreen.OnClickButton().Subscribe(_=>_helloWorldService.Hello()).AddTo(_compositeDisposable);
        }

        public void Dispose()
        {
            _compositeDisposable?.Dispose();
        }
    }
}