using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;
    [SerializeField] TextMeshProUGUI _countText;
    [SerializeField] Image _image;

    void Start()
    {
        _titleText.text = "";

        // DOTweenを使ったアニメーション
        _titleText.DOText("DOTween", 1.0f).SetEase(Ease.Linear);

        // _countTextをDOCounterでアニメーション
        _countText.DOCounter(0, 100, 2.0f).SetEase(Ease.Linear);

        // _imageをDOFillAmountでアニメーション
        _image.DOFillAmount(1.0f, 2.0f).SetEase(Ease.Linear);
    }
}
