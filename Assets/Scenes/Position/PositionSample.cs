using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSample : MonoBehaviour
{
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _target;
    [SerializeField] GameObject _parent;


    void Start()
    {
        //_sphere.transform.position = new Vector3(0, 0, 0);
        //_sphere.transform.position = _target.transform.position;
        //_parentの子オブジェクトを取得
        var children = _parent.GetComponentsInChildren<Transform>();
        foreach (var child in children)
        {
            Debug.Log(child.name);
            _sphere.transform.position = child.position;
        }
    }
}
