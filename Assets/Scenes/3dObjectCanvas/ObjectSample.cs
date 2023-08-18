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
        _objectParentChild.layer = 1;
        foreach (Transform child in _objectParentChild.transform)
        {
            child.gameObject.layer = 1;
        }
    }
}
