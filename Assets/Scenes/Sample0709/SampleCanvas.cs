using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SampleCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;
    
    void Start()
    {   
        _titleText.text = "Hello World";
    }
}
