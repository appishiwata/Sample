using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSample : MonoBehaviour
{
    [SerializeField] GameObject _object;
    
    [SerializeField] GameObject _objectParentChild;
    
    void Start()
    {

        _object.layer = 1;
        
        // 子供のレイヤーも変更
        Debug.Log(_objectParentChild.layer);
        _objectParentChild.layer = 1;
        Debug.Log(_objectParentChild.layer);
        foreach (Transform child in _objectParentChild.transform)
        {
            child.gameObject.layer = 1;
        }
    }
}
