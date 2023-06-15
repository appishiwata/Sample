using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class AsyncSample : MonoBehaviour
{
    [SerializeField] Button _closeButton;
    [SerializeField] Button _openButton;

    async void Start()
    {
        //3秒待つ
        //await UniTask.Delay(TimeSpan.FromSeconds(3f));

        //ボタンが押されるまで待つ
        await _closeButton.OnClickAsync();
        Debug.Log("close");

        //ボタンが押されるまで待つ
        await _openButton.OnClickAsync();
        Debug.Log("open");

        //すべての処理が終わるまで待つ
        await UniTask.WhenAll(
            _closeButton.OnClickAsync(),
            _openButton.OnClickAsync()
        );
        Debug.Log("close and open");

        //指定した秒数待機する3,4,5秒
        await UniTask.WhenAll(
            WaitAsync(3f),
            WaitAsync(4f),
            WaitAsync(5f)
        );
        Debug.Log("3,4,5 seconds wait");
    }

    //指定した秒数待機する
    async UniTask WaitAsync(float seconds)
    {
        await UniTask.Delay(TimeSpan.FromSeconds(seconds));
        Debug.Log($"Wait {seconds} seconds");
    }
}
