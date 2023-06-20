using UnityEngine;

public class Player
{
    // メンバ変数
    public int hp = 100;
    public int power = 50;

    // 静的メンバ変数
    public static int money = 100;

    // コンストラクタ
    public Player()
    {
        Debug.Log("Playerクラスのコンストラクタが実行されました");
    }

    // コンストラクタ 引数あり
    public Player(int hp, int power)
    {
        this.hp = hp;
        this.power = power;
        Debug.Log("Playerクラスのコンストラクタが実行されました 引数あり");
    }

    // 静的コンストラクタ
    static Player()
    {
        Debug.Log("Playerクラスの静的コンストラクタが実行されました");
    }

    // メンバ関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // メンバ関数
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }

    // 静的メンバ関数
    public static void GetMoney()
    {
        Debug.Log(Player.money + "のお金を手に入れた");
    }
}