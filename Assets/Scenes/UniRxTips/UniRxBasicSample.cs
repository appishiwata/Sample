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
        
        // オペレータの使用
        // Selectでイベントを加工する
        var subject3 = new Subject<string>();
        subject3.Select(x => x + "!")
            .Subscribe(x => Debug.Log(x));
        subject3.OnNext("Hello World");
        
        // Whereでイベントをフィルタリングする
        var subject4 = new Subject<int>();
        subject4.Where(x => x % 2 == 0)
            .Subscribe(x => Debug.Log(x));
        subject4.OnNext(1);
        subject4.OnNext(2); // これだけ表示される
        subject4.OnNext(3);
        
        // Takeでイベントを指定した数だけ取得する
        var subject5 = new Subject<int>();
        subject5.Take(3)
            .Subscribe(x => Debug.Log(x));
        subject5.OnNext(1);
        subject5.OnNext(2);
        subject5.OnNext(3); // ここまで表示される
        subject5.OnNext(4);
        subject5.OnNext(5);
    }
}
