using UnityEngine;

public class BasicClassSample : MonoBehaviour
{
    private void Start()
    {
        // Itemクラスの変数を宣言してインスタンスを代入
        Item myItem = new Item();
        Debug.Log(myItem.ID); // 0
        Debug.Log(myItem.Name); // null
        Debug.Log(myItem.Price);
        
        // Itemクラスのメンバ変数にアクセスして値を代入
        myItem.ID = 1;
        myItem.Name = "Sword";
        //myItem.Price = 100; // Error
        Debug.Log(myItem.ID); // 1
        Debug.Log(myItem.Name); // Sword
        Debug.Log(myItem.Price); // 0
        
        // Itemクラスをコンストラクタを使ってインスタンス化
        // Priceは読み取り専用なのでコンストラクタで初期値を代入。書き換えは出来ないが初期値を入れられる。
        Item myItem2 = new Item(2, "Shield", 200);
        Debug.Log(myItem2.ID); // 2
        Debug.Log(myItem2.Name); // Shield
        Debug.Log(myItem2.Price); // 200
        
        // 追加：Priceの2倍を返すプロパティを使う
        Debug.Log(myItem2.DoublePrice); // 400
        // 追加：Priceの2倍を代入しようとするとエラーになる
        //myItem2.DoublePrice = 100; // Error
        
        // Itemクラスをコンストラクタを使ってインスタンス化
        // enumを使ってみる
        Item myItem3 = new Item(3, "Accessory", 300, Item.ItemType.Accessory);
        Debug.Log(myItem3.ID); // 3
        Debug.Log(myItem3.Name); // Accessory
        Debug.Log(myItem3.Price); // 300
        Debug.Log(myItem3.Type); // Accessory
        
        // enumはstaticなのでクラス名でアクセスできる
        Debug.Log(myItem3.Type == Item.ItemType.Accessory); // true
        
        // enumはintにキャストできる
        Debug.Log((int)myItem3.Type); // 2
        
        // enumは文字列にキャストできる
        Debug.Log(myItem3.Type.ToString()); // Accessory
        
        // enumは文字列からキャストできる
        Debug.Log((Item.ItemType)System.Enum.Parse(typeof(Item.ItemType), "Accessory")); // Accessory
        
        // enumはforeachで回せる
        foreach (Item.ItemType type in System.Enum.GetValues(typeof(Item.ItemType)))
        {
            Debug.Log(type);
        }
        
        // enumはswitch文で使える
        switch (myItem3.Type)
        {
            case Item.ItemType.Weapon:
                Debug.Log("Weapon");
                break;
            case Item.ItemType.Shield:
                Debug.Log("Shield");
                break;
            case Item.ItemType.Accessory:
                Debug.Log("Accessory");
                break;
        }
    }
}

public class Item
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Price { get; }

    // 追加：価格（Price）の2倍を返すプロパティ
    // setを書かなければ読み取り専用になる
    public int DoublePrice => Price * 2;

    public Item() { }

    public Item(int id, string name, int price)
    {
        ID = id;
        Name = name;
        Price = price;
    }
    
    // enumを使ってみる
    public enum ItemType
    {
        Weapon,
        Shield,
        Accessory,
    }
    
    // enumを使ってみる
    public ItemType Type;
    
    // 追加：enumを使ってみる
    public Item(int id, string name, int price, ItemType type)
    {
        ID = id;
        Name = name;
        Price = price;
        Type = type;
    }
}