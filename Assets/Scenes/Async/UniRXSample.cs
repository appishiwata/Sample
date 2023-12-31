using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

public class UniRXSample : MonoBehaviour
{
    [SerializeField] Button _button;
    [SerializeField] Button _strikeButton;
    [SerializeField] Button _waitButton;
    [SerializeField] Button[] _buttons;
    [SerializeField] Button _pressButton;
    [SerializeField] Button _pressContinueButton;

    async void Start()
    {
        // UniRXのサンプル
        // 1秒後に実行
        Observable.Timer(TimeSpan.FromSeconds(1f))
            .Subscribe(_ =>
            {
                Debug.Log("1秒後に実行");
            });

        // _buttonのクリックイベントを登録
        _button.OnClickAsObservable()
            .Subscribe(_ =>
            {
                Debug.Log("ボタンがクリックされた");
            });

        // _strikeButtonのクリックイベントを登録 連打防止
        _strikeButton.OnClickAsObservable()
            .ThrottleFirst(TimeSpan.FromSeconds(1f))
            .Subscribe(_ =>
            {
                Debug.Log("ボタンがクリックされた");
            });

        // UniTaskのサンプル
        //await Sample();

        // UniTaskのサンプル
        //await WaitButtonClick();

        // 全てのボタンが押されるまで待機
        Observable.WhenAll(_buttons.Select(button => button.OnClickAsObservable().First().AsUnitObservable()))
            .Subscribe(_ =>
            {
                Debug.Log("すべてのボタンが押されました！");
            })
            .AddTo(this);

        // _pressButtonが長押しされたら実行
        _pressButton.OnPointerDownAsObservable()
            .SelectMany(_ => Observable.Timer(TimeSpan.FromSeconds(1f)).AsUnitObservable())
            .RepeatUntilDestroy(this)
            .Subscribe(_ =>
            {
                Debug.Log("長押しされた");
            });

        // 長押ししている間2秒ごとに実行
        _pressContinueButton.OnPointerDownAsObservable()
            .SelectMany(_ => Observable.Timer(TimeSpan.FromSeconds(0.5)))
            .SelectMany(_ => Observable.Interval(TimeSpan.FromSeconds(2)))
            .TakeUntil(_pressContinueButton.OnPointerUpAsObservable())
            .RepeatUntilDestroy(this.gameObject)
            .Subscribe(_ => 
            {
                Debug.Log("長押しされた" + _);
            });
    }

    // UniTaskの関数
    async UniTask Sample()
    {
        // 1秒後に実行
        await UniTask.Delay(TimeSpan.FromSeconds(2f));
        Debug.Log("2秒後に実行");
    }

    // UniTaskの関数
    async UniTask WaitButtonClick()
    {
        using(_waitButton.OnClickAsObservable().Subscribe(_ => {
            // _buttonがクリックされたら非表示にする
            _waitButton.gameObject.SetActive(false);
        }))
        {
            await UniTask.WaitUntil(() => _waitButton.gameObject.activeSelf == false);
            // _buttonが非表示になったら実行
            Debug.Log("ボタンが非表示になった");
        }
    }
}
