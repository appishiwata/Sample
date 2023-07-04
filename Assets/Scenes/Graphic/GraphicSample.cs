using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicSample : MonoBehaviour
{
    [SerializeField] GameObject _sphereObject;
    [SerializeField] Material _redMaterial;
    [SerializeField] Material _blueMaterial;
    [SerializeField] Button _button;

    void Start()
    {
        _sphereObject.GetComponent<Renderer>().material = _redMaterial;

        // _buttonを押したら_sphereObjectのマテリアルを_blueMaterialに変更する
        _button.onClick.AddListener(() =>
        {
            _sphereObject.GetComponent<Renderer>().material = _blueMaterial;
        });
    }
}
