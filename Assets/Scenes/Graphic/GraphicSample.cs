using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicSample : MonoBehaviour
{
    [SerializeField] GameObject _sphereObject;
    [SerializeField] Material _sphereMaterial;

    void Start()
    {
        _sphereObject.GetComponent<Renderer>().material = _sphereMaterial;
    }
}
