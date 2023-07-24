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
    }
}
