using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ImageFillSample : MonoBehaviour
{
    [SerializeField] Image _hpFillImage;
    [SerializeField] Image _circleFillImage;
    
    void Start()
    {
        _hpFillImage.fillAmount = 0.5f;
        _circleFillImage.fillAmount = 0.5f;
        
        // 0.5秒後にHPを1にする DOTWeenを使う
        _hpFillImage.DOFillAmount(1f, 0.5f).SetDelay(0.5f);
        _circleFillImage.DOFillAmount(1f, 0.5f).SetDelay(0.5f);
    }
}