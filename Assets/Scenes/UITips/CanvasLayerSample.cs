using TMPro;
using UnityEngine;

public class CanvasLayerSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;
    
    void Start()
    {
        _titleText.text = "CanvasLayerSample";
    }
}
