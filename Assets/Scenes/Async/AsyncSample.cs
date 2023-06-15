using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class AsyncSample : MonoBehaviour
{
    async void Start()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(3f));
        Debug.Log("Hello");
    }
}
