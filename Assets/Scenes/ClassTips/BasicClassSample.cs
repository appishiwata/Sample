using UnityEngine;

public class BasicClassSample : MonoBehaviour
{
    private void Start()
    {
        // Itemクラスの変数を宣言してインスタンスを代入
        Item myItem = new Item();
        Debug.Log(myItem.ID); // 0
        Debug.Log(myItem.Name); // null
        
        // Itemクラスのメンバ変数にアクセスして値を代入
        myItem.ID = 1;
        myItem.Name = "Sword";
        Debug.Log(myItem.ID); // 1
        Debug.Log(myItem.Name); // Sword
    }
}

// Itemクラスを作成
public class Item
{
    // メンバ変数を宣言
    public int ID;
    public string Name;
}