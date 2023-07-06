using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        var children = _parent.GetComponentsInChildren<Transform>().Skip(1); // 親を含まないように
        foreach (var child in children)
        {
            _sphere.transform.position = child.position;
        }
        var childFirst = _parent.GetComponentsInChildren<Transform>().Where(x => x.name.StartsWith("Cube")).FirstOrDefault(); // 1個目の子
        _sphere.transform.position = childFirst.position;
    }
}
