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
        
        _icon.sprite = cardData.Icon;
        _name.text = cardData.Name;
    }
}

public class CardData
{
    public Sprite Icon;
    public string Name;

    public int SelectedCount { get; private set; }
    
    public void IncrementSelectedCount()
    {
        SelectedCount++;
    }
}
