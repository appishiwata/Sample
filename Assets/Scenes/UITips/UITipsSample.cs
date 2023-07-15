using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITipsSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;
    [SerializeField] Slider _hpSlider;
    
    [SerializeField] Slider _cubeSizeSlider;
    [SerializeField] GameObject _cube;
    
    void Start()
    {
        _titleText.text = "UITips";
        // _sliderの値を0.5にする
        //_hpSlider.value = 0.5f;
        // _sliderの値をdotweenで1秒かけて1にする
        _hpSlider.DOValue(1f, 2f);
        
        // _cubeSizeSliderの値を0.5にする
        _cubeSizeSlider.value = 0.5f;
        
        // _cubeのscaleの初期値を_sliderの値にする
        _cube.transform.localScale = Vector3.one * _cubeSizeSlider.value;
        
        // _cubeSizeSliderの値と_cubeのScaleを連動させる
        _cubeSizeSlider.onValueChanged.AddListener(OnCubeSizeSliderValueChanged);
    }

    private void OnCubeSizeSliderValueChanged(float arg0)
    {
        _cube.transform.localScale = Vector3.one * arg0;
    }
}
