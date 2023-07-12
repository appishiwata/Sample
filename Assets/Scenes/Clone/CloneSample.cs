using UnityEngine;

public class CloneSample : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _parent;

    private void Start()
    {
        // 1個だけ生成する
        //Instantiate(_prefab, _parent);

        // 3個生成する
        for (int i = 0; i < 3; i++)
        {
            // 生成したオブジェクトを変数に入れる
            GameObject obj = Instantiate(_prefab, _parent);
            // 生成したオブジェクトのCardコンポーネントを取得する
            Card card = obj.GetComponent<Card>();
            // CardコンポーネントのSetCardDataメソッドを呼び出す
            card.SetCardData(new CardData()
            {
                icon = Resources.Load<Sprite>("FaceIcons/boy_0" + (i+1)),
                name = "Card" + (i+1)
            });
        }
    }
}
