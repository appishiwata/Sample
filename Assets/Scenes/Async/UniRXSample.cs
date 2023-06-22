using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class UniRXSample : MonoBehaviour
{
    [SerializeField] Button _button;
    [SerializeField] Button _strikeButton;

    void Start()
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
    }
}
