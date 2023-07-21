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
                Icon = Resources.Load<Sprite>("FaceIcons/boy_0" + (i+1)),
                Name = "Card" + (i+1)
            });
            // 生成したオブジェクトを_positionsの位置に移動させる
            obj.transform.DOMove(_positions[i].transform.position, 1f)
                .SetEase(Ease.OutBack)
                .SetDelay(0.5f);
        }

        // _closeButtonが押されたらこのusingブロックを抜ける
        using (Card.OnClickedSelectButton.Subscribe(async data =>
        {
            Debug.Log(data.Name);
            _selectedIconImage.sprite = data.Icon;
            _selectedNameText.text = data.Name;
            
            // 1秒待機
            await Observable.Timer(System.TimeSpan.FromSeconds(1f));
            data.IncrementSelectedCount();
            Debug.Log(data.SelectedCount);
        }))
        {
            // _closeButtonが押されるまで待機する
            await _cloneButton.OnClickAsObservable().First();
            Debug.Log("CloneButton Clicked");
        }
    }
}