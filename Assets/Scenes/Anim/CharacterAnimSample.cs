using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAnimSample : MonoBehaviour
{
    [SerializeField] Image _image;
    [SerializeField] Sprite[] _sprites;
    [SerializeField] Button _smileButton;

    async void Start()
    {
        // DOTweenでスケールを繰り返し変更
        _image.transform.DOScale(0.61f, 1.5f)
            .SetLoops(-1, LoopType.Yoyo);
        
        // Unitaskでボタンを押すまで待つ
        await _smileButton.OnClickAsync();
        _image.gameObject.SetActive(false);
    }
}
