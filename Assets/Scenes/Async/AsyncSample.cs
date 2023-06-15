using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class AsyncSample : MonoBehaviour
{
    [SerializeField] Button _closeButton;

    async void Start()
    {
        //3秒待つ
        //await UniTask.Delay(TimeSpan.FromSeconds(3f));

        //ボタンが押されるまで待つ
        await _closeButton.OnClickAsync();
        Debug.Log("Hello");
    }
}
