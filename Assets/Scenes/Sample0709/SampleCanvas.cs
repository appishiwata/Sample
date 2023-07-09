using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;

public class SampleCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;

    async void Start()
    {   
        _titleText.text = "Hello World";
        // UniTaskで１秒待つ
        await UniTask.Delay(1000);
        _titleText.text = "Hello World2";
    }
}
