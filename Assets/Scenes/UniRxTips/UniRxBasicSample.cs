using System;
using UniRx;
using UnityEngine;

public class UniRxBasicSample : MonoBehaviour
{
    void Start()
    {
        // UniRxの基本的な使い方
        // Subjectを使ってイベントを発行する
        var subject = new Subject<string>();
        // Subscribeでイベントを購読する
        subject.Subscribe(x => Debug.Log(x));
        // OnNextでイベントを発行する
        subject.OnNext("Hello World");
        
        // OnNext , OnError , OnCompletedの3つのイベントを発行する
        var subject2 = new Subject<string>();
        subject2.Subscribe(
            x => Debug.Log("Next" + x),
            x => Debug.Log("Error" + x),
            onCompleted:() => Debug.Log("Completed"));
        subject2.OnNext("Hello World1");
        subject2.OnCompleted();
        subject2.OnNext("Hello World2");

        subject2.OnNext("Hello World3");
        subject2.OnError(new Exception("Error!"));
        subject2.OnNext("Hello World4");
    }
}
