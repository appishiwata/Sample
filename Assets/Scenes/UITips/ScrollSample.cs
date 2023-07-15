using UnityEngine;

public class ScrollSample : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _parent;
    [SerializeField] Transform _parentWithContentSizeFitter;
    
    void Start()
    {
        // _prefabを_parentの子に5個生成する
        // ContentSizeFitterがついていないので、5個以上だとはみ出る
        for (int i = 0; i < 5; i++)
        {
            GameObject instance = Instantiate(_prefab, _parent);
            instance.transform.localPosition = Vector3.zero;
        }
        
        // _prefabを_parentWithContentSizeFitterの子に5個生成する
        // ContentSizeFitterがついているので、5個以上でもはみ出ない
        for (int i = 0; i < 6; i++)
        {
            GameObject instance = Instantiate(_prefab, _parentWithContentSizeFitter);
            instance.transform.localPosition = Vector3.zero;
        }
    }
}
