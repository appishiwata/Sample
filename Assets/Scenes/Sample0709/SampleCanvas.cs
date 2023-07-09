using Cysharp.Threading.Tasks;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class SampleCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;

    void Start()
    {   
        _titleText.text = "default";
        Debug.Log("Start");
        
        TextAnimation();
    }

    async void TextAnimation()
    {
        _titleText.text = "Hello World";
        await UniTask.Delay(1000);
        _titleText.text = "Hello World2";
        await UniTask.Delay(1000);
        _titleText.text = "";
        await _titleText.DOText("Hello World3", 1.0f).AsyncWaitForCompletion();
    }
}
