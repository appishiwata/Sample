using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class UniRXSample : MonoBehaviour
{
    void Start()
    {
        // UniRXのサンプル
        // 1秒後に実行
        Observable.Timer(TimeSpan.FromSeconds(1f))
            .Subscribe(_ =>
            {
                Debug.Log("1秒後に実行");
            });
    }

}
