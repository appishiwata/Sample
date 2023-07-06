using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSample : MonoBehaviour
{
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _target;

    void Start()
    {
        //_sphere.transform.position = new Vector3(0, 0, 0);
        _sphere.transform.position = _target.transform.position;
    }
}
