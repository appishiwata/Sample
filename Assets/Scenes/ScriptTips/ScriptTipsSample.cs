using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class ScriptTipsSample : MonoBehaviour
{
    [SerializeField] Image _image1;
    [SerializeField] Image _image2;

    void Start()
    {
        // LoadAssetAtPathのサンプル
        var buttonSprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Textures/UI/button_square.png");
        _image1.sprite = buttonSprite;
        
        // Addressableのサンプル
        Addressables.LoadAssetAsync<Sprite>("Assets/Textures/UI/button_square.png")
            .Completed += handle =>
            {
                _image2.sprite = handle.Result;
            };
    }
}
