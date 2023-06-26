using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CardAnimSample : MonoBehaviour
{

    [SerializeField] Image _cardImage;

    void Start()
    {
        _cardImage.transform.DOMoveY(400f, 1f).SetRelative().SetDelay(0.5f);
    }
}
