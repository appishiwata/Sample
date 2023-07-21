using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] Image _icon;
    [SerializeField] TextMeshProUGUI _name;
    [SerializeField] Button _selectButton;
    
    public static Subject<CardData> OnClickedSelectButton = new();
    
    public CardData CardData { get; private set; }
    
    void Start()
    {
        _selectButton.OnClickAsObservable()
            .Subscribe(_ => OnClickedSelectButton.OnNext(CardData));
    }
    
    public void SetCardData(CardData cardData)
    {
        CardData = cardData;
        
        _icon.sprite = cardData.icon;
        _name.text = cardData.name;
    }
}

public class CardData
{
    public Sprite icon;
    public string name;
}
