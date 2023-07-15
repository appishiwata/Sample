using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITipsSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;
    [SerializeField] Slider _slider;
    
    void Start()
    {
        _titleText.text = "UITips";
        // _sliderの値を0.5にする
        //_slider.value = 0.5f;
        // _sliderの値をdotweenで1秒かけて1にする
        _slider.DOValue(1f, 2f);
    }
}
