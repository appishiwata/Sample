using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FuriganaSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;

    void Start()
    {
        _titleText.text = "Furigana";
    }
}
