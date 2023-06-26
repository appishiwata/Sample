using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CardAnimSample : MonoBehaviour
{

    [SerializeField] Image _cardImage;

    void Start()
    {
        _cardImage.transform.DOMoveY(400f, 2f)
            .SetRelative()
            .SetEase(Ease.OutBounce)
            .SetDelay(0.5f)
            .OnComplete(() =>
            {
                DOTween.Sequence()
                    .AppendInterval(1f)
                    .Append(_cardImage.transform.DOScale(1.1f, 1f))
                    .Append(_cardImage.transform.DOScale(1f, 1f))
                    .SetLoops(-1);
            });
    }
}
