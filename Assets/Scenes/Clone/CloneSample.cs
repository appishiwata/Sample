using System.Linq;
using DG.Tweening;
using UnityEngine;

public class CloneSample : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _parent;
    [SerializeField] Transform[] _positions;

    private void Start()
    {
        // _positionsの位置を確認する あらかじめ入れておく
        _positions.Select(x => x.position).ToList().ForEach(x => Debug.Log(x));
        
        // 5個生成する
        for (int i = 0; i < 5; i++)
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
    }
}