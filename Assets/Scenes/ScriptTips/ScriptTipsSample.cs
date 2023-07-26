using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ScriptTipsSample : MonoBehaviour
{
    [SerializeField] Image _image;
    void Start()
    {
        // LoadAssetAtPathのサンプル
        var buttonSprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Textures/UI/button_square.png");
        _image.sprite = buttonSprite;
    }
}
