using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSample : MonoBehaviour
{
    [SerializeField] Canvas _canvas;
    [SerializeField] Canvas _subCanvas;

    void Start()
    {
        Debug.Log("Canvas RenderMode: " + _canvas.renderMode);
        Debug.Log("SubCanvas RenderMode: " + _subCanvas.renderMode);
    }
}
