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

        //2秒待ってからテキストを変更する
        await UniTask.Delay(TimeSpan.FromSeconds(2f));
        text.text = "Start";
        Debug.Log("Start");

        //2秒待ってからテキストの色を変更する
        await UniTask.Delay(TimeSpan.FromSeconds(2f));
        text.color = Color.red;
        Debug.Log("Color.red");
    }
}
