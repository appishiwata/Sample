using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSample : MonoBehaviour
{
    [SerializeField] GameObject _floorModel;
    
    void Start()
    {
        _floorModel.transform.position = new Vector3(0, 0, 0);
    }
}
