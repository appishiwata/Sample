using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class AnimSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _sampleText;

    void Start()
    {
        _sampleText.text = "Sample";

        // dotweenでアニメーションを作成
        DOTween.To(() => _sampleText.color, x => _sampleText.color = x, Color.red, 1f);
    }
}
