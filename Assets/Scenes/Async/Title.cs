using System;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;

public class Title : MonoBehaviour
{
    async void Start()
    {
        //TextMeshProUGUIのテキストを変更する
        var text = GetComponent<TextMeshProUGUI>();
        text.text = "Title";
        Debug.Log("Title");

        //以下全ての待機処理をcancelTokenを使ってキャンセルできるようにする
        var cancelToken = this.GetCancellationTokenOnDestroy();

        //2秒待ってからテキストを変更する
        //try-catchでUniTask.Delayの例外をキャッチする
        try
        {
            await UniTask.Delay(TimeSpan.FromSeconds(2f), cancellationToken: cancelToken);
        }
        catch (Exception e)
        {
            Debug.Log(e);
            return;
        }
        text.text = "Start";
        Debug.Log("Start");

        //2秒待ってからテキストの色を変更する
        //try-catchでUniTask.Delayの例外をキャッチする
        try
        {
            await UniTask.Delay(TimeSpan.FromSeconds(2f), cancellationToken: cancelToken);
        }
        catch (Exception e)
        {
            Debug.Log(e);
            return;
        }
        text.color = Color.red;
        Debug.Log("Color.red");

        //5秒待ってからテキストのサイズを変更する
        //try-catchでUniTask.Delayの例外をキャッチする
        try
        {
            await UniTask.Delay(TimeSpan.FromSeconds(5f), cancellationToken: cancelToken);
        }
        catch (Exception e)
        {
            Debug.Log(e);
            return;
        } 
        text.fontSize = 100;
        Debug.Log("fontSize 100");
    }
}
