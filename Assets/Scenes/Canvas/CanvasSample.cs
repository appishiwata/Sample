using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSample : MonoBehaviour
{
    [SerializeField] Canvas _canvas;
    [SerializeField] Canvas _subCanvas;

    void Start()
    {
        // subcanvasにはインスペクター上からはrenderModeは見れないが、親のものを継承している。
        Debug.Log("Canvas RenderMode: " + _canvas.renderMode);
        Debug.Log("SubCanvas RenderMode: " + _subCanvas.renderMode);
        
        // canvasのoverrideSortingは子キャンバスにのみ存在する。
        Debug.Log("Canvas overrideSorting: " + _canvas.overrideSorting);
        Debug.Log("SubCanvas overrideSorting: " + _subCanvas.overrideSorting);
    }
}
