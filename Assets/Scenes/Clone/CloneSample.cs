using System.Linq;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CloneSample : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _parent;
    // Vector3の配列を5個用意する
    [SerializeField] Transform[] _positions = new Transform[5];

    async void Start()
    {
        // プレハブを5個生成する
        await AddCloneAsync();
        
        // _parentの子要素をすべて削除
        foreach (Transform child in _parent)
        {
            Destroy(child.gameObject);
        }
        
        // _parentのgridLayoutGroupを無効にする
        _parent.GetComponent<GridLayoutGroup>().enabled = false;
        
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

    async UniTask AddCloneAsync()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject obj = Instantiate(_prefab, _parent);

            // レイアウトの調整を待つ
            await UniTask.Yield();

            // 位置情報を取得
            _positions[i] = obj.transform;
            Debug.Log(_positions[i].position);
        }
    }
    
}