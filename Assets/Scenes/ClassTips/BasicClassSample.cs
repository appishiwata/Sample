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
    }
}

// Itemクラスを作成
public class Item
{
    // メンバ変数を宣言
    public int ID;
    public string Name;

    // 読み取り専用のメンバ変数を宣言
    public int Price { get; private set; }
    
    // コンストラクタを定義
    public Item()
    {
        // メンバ変数に初期値を代入
        ID = 0;
        Name = null;
        Price = 0;
    }
    
    // コンストラクタを定義
    public Item(int id, string name, int price)
    {
        // メンバ変数に引数の値を代入
        ID = id;
        Name = name;
        Price = price;
    }
}