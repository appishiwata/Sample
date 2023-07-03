using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FuriganaSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;

    void Start()
    {
        _titleText.text = "発電所<style=p6>はつでんしょ</style>";
    }
}
