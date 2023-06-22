using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnimSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _colorText;
    [SerializeField] TextMeshProUGUI _moveText;
    [SerializeField] TextMeshProUGUI _rotateText;
    [SerializeField] TextMeshProUGUI _shakeText;
    [SerializeField] TextMeshProUGUI _sampleText;
    [SerializeField] Image _image;

    [SerializeField] Button[] _buttons;

    void Start()
    {
        // _buttonsのボタンのクリックイベントを登録
        foreach (var button in _buttons)
        {
            button.onClick.AddListener(() =>
            {
                // _imageの位置をdotweenでアニメーション _buttonの位置に移動
                _image.transform.DOMove(button.transform.position, 1f).SetEase(Ease.OutBounce);
            });
        }

        // テキストを設定
        _colorText.text = "Color";
        _moveText.text = "Move";
        _rotateText.text = "Rotate";
        _shakeText.text = "Shake";
        _sampleText.text = "Sample";

        // _colorTextの色をdotweenでアニメーション
        DOTween.To(() => _colorText.color, x => _colorText.color = x, Color.red, 1f).SetEase(Ease.OutBounce);
        // _colorTextの色をdotweenでアニメーション 2秒後に実行
        DOTween.To(() => _colorText.color, x => _colorText.color = x, Color.blue, 1f).SetEase(Ease.OutBounce).SetDelay(2f);

        // _moveTextの移動をdotweenでアニメーション
        _moveText.transform.DOMoveX(100f, 1f).SetRelative();
        // _moveTextの移動をdotweenでアニメーション 2秒後に実行
        _moveText.transform.DOMoveX(-100f, 1f).SetRelative().SetDelay(2f);

        // _rotateTextの回転をdotweenでアニメーション
        _rotateText.transform.DORotate(new Vector3(0f, 0f, 360f), 1f, RotateMode.FastBeyond360).SetRelative();
        // _rotateTextの回転をdotweenでアニメーション 2秒後に実行
        _rotateText.transform.DORotate(new Vector3(0f, 0f, -360f), 1f, RotateMode.FastBeyond360).SetRelative().SetDelay(2f);

        // _shakeTextのシェイクをdotweenでアニメーション
        _shakeText.transform.DOShakePosition(1f, 10f, 10, 90f, false, true);
        // _shakeTextのシェイクをdotweenでアニメーション 2秒後に実行
        _shakeText.transform.DOShakePosition(1f, 10f, 10, 90f, false, true).SetDelay(2f);

        // _sampleTextのアニメーションをdotweenで作成 完了後 徐々に非表示にする
        DOTween.Sequence()
            .AppendInterval(2f)
            .Append(_sampleText.transform.DOScale(1.5f, 0.5f))
            .Append(_sampleText.transform.DOScale(1f, 0.5f))
            .SetLoops(2)
            .OnComplete(() => _sampleText.DOFade(0f, 1f).SetDelay(2f));
    }
}
