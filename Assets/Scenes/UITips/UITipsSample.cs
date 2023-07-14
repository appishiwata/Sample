using TMPro;
using UnityEngine;

public class UITipsSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;
    
    void Start()
    {
        _titleText.text = "UITips";
    }
}
