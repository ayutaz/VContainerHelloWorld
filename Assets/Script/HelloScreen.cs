using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace MyGame
{
    public class HelloScreen : MonoBehaviour,IHelloScreen
    {
        [SerializeField] private Button helloButton;


        public IObservable<Unit> OnClickButton()
        {
            return helloButton.OnClickAsObservable();
        }
    }

    public interface IHelloScreen
    {
        IObservable<Unit> OnClickButton();
    }
}

