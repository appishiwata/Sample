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
                // _cardImageUpperと_cardImageLowerのDoTweenを同時に実行する
                DOTween.Sequence()
                    .Append(_cardImageUpper.transform.DOMove(new Vector3(-100f, 800f, 0f), 1.5f))
                    .Join(_cardImageLower.transform.DOMove(new Vector3(100f, -800f, 0f), 1.5f))
                    .SetDelay(0.5f)
                    .SetRelative()
                    // 上記の処理が始まったら
                    .OnStart(() =>
                    {
                        _characterImage.DOFade(1f, 0.3f)
                            .SetDelay(0.5f);
                        _characterImage.transform.DOShakePosition(1f, 10f, 10, 90f, false, true)
                            .SetDelay(0.5f);
                        _characterImage.transform.DOScale(0.7f, 0.1f)
                            .SetDelay(1.5f);                        
                    });
            });
    }
}
