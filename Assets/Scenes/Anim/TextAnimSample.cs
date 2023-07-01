using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class TextAnimSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;

    void Start()
    {
        _titleText.text = "";

        // DOTweenを使ったアニメーション
        _titleText.DOText("DOTween", 1.0f).SetEase(Ease.Linear);
    }
}
