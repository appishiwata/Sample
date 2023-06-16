using System;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AsyncSample : MonoBehaviour
{
    [SerializeField] Button _closeButton;
    [SerializeField] Button _openButton;
    [SerializeField] Button _cancelButton;

    [SerializeField] TextMeshProUGUI _titleText;

    async void Start()
    {
        //_cancelButtonを押すまで待つ
        await _cancelButton.OnClickAsync();
        //_titleTextを削除する
        Destroy(_titleText.gameObject);

        //_closeButtonを3回押すまで待つ(while文)
        int count = 0;
        while (count < 3)
        {
            await _closeButton.OnClickAsync();
            count++;
        }
        Debug.Log("close 3 times while");

        //_closeButtonを3回押すまで待つ(for文)
        for (int i = 0; i < 3; i++)
        {
            await _closeButton.OnClickAsync();
        }
        Debug.Log("close 3 times for");

        //cancelTokenを使ってボタンが押されるまで待つ
        var cancelToken = this.GetCancellationTokenOnDestroy();
        await _closeButton.OnClickAsync(cancelToken);
        Debug.Log("close cancelToken");

        //cancelTokenを使って1秒待つ
        await UniTask.Delay(TimeSpan.FromSeconds(1f), cancellationToken: cancelToken);
        Debug.Log("1 second wait cancelToken");
        
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
