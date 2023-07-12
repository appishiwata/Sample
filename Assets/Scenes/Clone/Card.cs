using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] Image _icon;
    [SerializeField] TextMeshProUGUI _name;
    
    public void SetCardData(CardData cardData)
    {
        _icon.sprite = cardData.icon;
        _name.text = cardData.name;
    }
}

public class CardData
{
    public Sprite icon;
    public string name;
}
