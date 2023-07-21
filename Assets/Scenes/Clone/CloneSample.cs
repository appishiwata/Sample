using System.Linq;
using DG.Tweening;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class CloneSample : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _parent;
    [SerializeField] Transform[] _positions;
    [SerializeField] Button _cloneButton;
    
    [SerializeField] Image _selectedIconImage;
    [SerializeField] TextMeshProUGUI _selectedNameText;

    private async void Start()
    {
        // _positionsの位置を確認する あらかじめ入れておく
        _positions.Select(x => x.position).ToList().ForEach(x => Debug.Log(x));

        // 5個生成する
        for (int i = 0; i < 10; i++)
        {
            GameObject obj = Instantiate(_prefab, _parent);
            Card card = obj.GetComponent<Card>();
            card.SetCardData(new CardData()
            {
                icon = Resources.Load<Sprite>("FaceIcons/boy_0" + (i+1)),
                name = "Card" + (i+1)
            });
            // 生成したオブジェクトを_positionsの位置に移動させる
            obj.transform.DOMove(_positions[i].transform.position, 1f)
                .SetEase(Ease.OutBack)
                .SetDelay(0.5f);
        }

        // _closeButtonが押されたらこのusingブロックを抜ける
        using (Card.OnClickedSelectButton.Subscribe(data =>
        {
            Debug.Log(data.name);
            _selectedIconImage.sprite = data.icon;
            _selectedNameText.text = data.name;
        }))
        {
            // _closeButtonが押されるまで待機する
            await _cloneButton.OnClickAsObservable().First();
            Debug.Log("CloneButton Clicked");
        }
    }
}