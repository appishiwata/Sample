using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CardAnimSample : MonoBehaviour
{

    [SerializeField] Image _cardImage;
    [SerializeField] Image _cardImageUpper;
    [SerializeField] Image _cardImageLower;
    [SerializeField] Image _characterImage;

    void Start()
    {
        // _cardImageをdotweenで上に移動させる 終わったら左上に移動させる
        _cardImage.transform.DOMoveY(400f, 2f)
            .SetRelative()
            .SetEase(Ease.OutBounce)
            .OnComplete(() =>
            {
                //_cardImageのalphaを0にする
                _cardImage.DOFade(0f, 0.1f);
                // _cardImageUpperと_cardImageLowerを上下にアニメーションさせる
                _cardImageUpper.transform.DOMove(new Vector3(-100f, 800f, 0f), 1.5f)
                    .SetDelay(0.5f)
                    .SetRelative();
                _cardImageLower.transform.DOMove(new Vector3(100f, -800f, 0f), 1.5f)
                    .SetDelay(0.5f)
                    .SetRelative();
            });
    }
}
