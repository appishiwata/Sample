using System.Linq;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class PositionSample : MonoBehaviour
{
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _parent;
    
    [SerializeField] TextMeshProUGUI _textForTransform;
    [SerializeField] TextMeshProUGUI _textForRectTransform;

    async void Start()
    {
        //_sphere.transform.position = new Vector3(0, 0, 0);
        //_sphere.transform.position = _target.transform.position;
        //_parentの子オブジェクトを取得
        var children = _parent.GetComponentsInChildren<Transform>().Skip(1); // 親を含まないように
        foreach (var child in children)
        {
            _sphere.transform.position = child.position;
        }
        var childFirst = _parent.GetComponentsInChildren<Transform>().FirstOrDefault(x => x.name.StartsWith("Cube")); // 1個目の子
        _sphere.transform.position = childFirst!.position;
        
        // UIの位置を調整 > これはどちらも同じ左下に表示される
        //_textForTransform.transform.position = new Vector3(0, 0, 0);
        //_textForRectTransform.rectTransform.position = new Vector3(0, 0, 0);
        
        // UIの位置を調整 > これはどちらも同じ真ん中に表示される
        //_textForTransform.transform.localPosition = new Vector3(0, 0, 0);
        //_textForRectTransform.rectTransform.localPosition = new Vector3(0, 0, 0);
        
        // UIの位置を調整 anchoredPosition
        //_textForRectTransform.rectTransform.anchoredPosition = new Vector3(0, 0, 0);
        
        // Utility.WorldToScreenPointを使って座標変換をする sphereの位置の上にUIを表示する
        //var screenPoint = Camera.main.WorldToScreenPoint(_sphere.transform.position);
        // _shpereの位置をy座標をプラスして取得する
        var screenPoint = Camera.main!.WorldToScreenPoint(_sphere.transform.position + new Vector3(0, 2, 0));
        _textForRectTransform.rectTransform.position = screenPoint;
        
        // 1秒待つ
        await UniTask.Delay(1000);

        // dotweenを使って移動する DomoveとDoLocalMoveの違いを確認する
        // _textForRectTransformを左下に移動 
        //_textForRectTransform.rectTransform.DOMove(new Vector3(0, 0, 0), 1f);
        // _textForRectTransformを真ん中に移動
        _textForRectTransform.rectTransform.DOLocalMove(new Vector3(0, 0, 0), 1f);
    }
}
