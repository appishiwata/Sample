using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSample : MonoBehaviour
{
    [SerializeField] GameObject _sphere;

    void Start()
    {
        _sphere.transform.position = new Vector3(0, 0, 0);
    }
}
