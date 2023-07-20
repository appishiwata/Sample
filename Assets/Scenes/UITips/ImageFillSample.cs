using UnityEngine;
using UnityEngine.UI;

public class ImageFillSample : MonoBehaviour
{
    [SerializeField] Image _hpFillImage;

    void Start()
    {
        _hpFillImage.fillAmount = 0.5f;
    }
}