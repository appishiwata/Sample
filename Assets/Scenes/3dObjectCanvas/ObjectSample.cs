using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSample : MonoBehaviour
{
    [SerializeField] GameObject _object;
    
    void Start()
    {
        _object.layer = 1;
    }
}
