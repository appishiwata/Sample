using System.Linq;
using TMPro;
using UnityEngine;

public class PositionSample : MonoBehaviour
{
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _parent;
    
    [SerializeField] TextMeshProUGUI _textForTransform;
    [SerializeField] TextMeshProUGUI _textForRectTransform;
    
    void Start()
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
        var screenPoint = Camera.main.WorldToScreenPoint(_sphere.transform.position + new Vector3(0, 2, 0));
        _textForRectTransform.rectTransform.position = screenPoint;
    }
}
