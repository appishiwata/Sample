using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class TextAnimSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;
    [SerializeField] TextMeshProUGUI _countText;

    void Start()
    {
        _titleText.text = "";

        // DOTweenを使ったアニメーション
        _titleText.DOText("DOTween", 1.0f).SetEase(Ease.Linear);

        // _countTextをDOCounterでアニメーション
        _countText.DOCounter(0, 100, 2.0f).SetEase(Ease.Linear);
    }
}
