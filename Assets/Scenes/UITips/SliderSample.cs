using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;
    [SerializeField] Slider _hpSlider;
    
    [SerializeField] Slider _cubeSizeSlider;
    [SerializeField] GameObject _cube;
    
    [SerializeField] Slider _hpSliderWholeNumber;
    [SerializeField] TextMeshProUGUI _hpText;
    
    void Start()
    {
        _titleText.text = "UITips";
        // _sliderの値を0.5にする
        //_hpSlider.value = 0.5f;
        // _sliderの値をDOTWeenで1秒かけて1にする
        _hpSlider.DOValue(1f, 2f);
        
        // _cubeSizeSliderの値を0.5にして初期値にする
        _cubeSizeSlider.value = 0.5f;
        _cube.transform.localScale = Vector3.one * _cubeSizeSlider.value;
        
        // _cubeSizeSliderの値と_cubeのScaleを連動させる
        _cubeSizeSlider.onValueChanged.AddListener(value =>
        {
            _cube.transform.localScale = Vector3.one * value;
        });
        
        // _hpSliderWholeNumberの値を0にする
        int hp = 0;
        int maxHp = 100;
        _hpSliderWholeNumber.value = hp;
        // _hpTextのテキストを0にする
        _hpText.text = hp + "/" + maxHp;

        // _hpSliderWholeNumberの値をDOTWeenで1秒かけて1にする
        _hpSliderWholeNumber.DOValue(maxHp, 2f)
            .OnComplete(() =>
            {
                _hpSliderWholeNumber.DOValue(hp, 2f);
            });

        // _hpSliderWholeNumberの値と_hpTextのテキストを連動させる
        _hpSliderWholeNumber.onValueChanged.AddListener(value =>
        {
            _hpText.text = value + "/" + maxHp;
        });
    }
}