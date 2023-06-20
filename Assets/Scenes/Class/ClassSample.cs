using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSample : MonoBehaviour
{
    void Start()
    {
        // Playerクラスの変数を宣言してインスタンスを代入
        Player myPlayer = new Player();
        // Playerクラスのメンバ変数にアクセスして値を代入
        myPlayer.hp = 100;
        myPlayer.power = 50;
        // Playerクラスのメンバ関数にアクセスして実行
        myPlayer.Attack();
        myPlayer.Damage(30);

        // moneyは静的メンバ変数なのでクラス名でアクセスする
        // myPlayer.money = 200; > エラーになる
        Player.money = 200;
        Player.GetMoney();
                
        // Playerクラスの変数を宣言してインスタンスを代入
        Player myPlayer2 = new Player();

        // Playerクラスの変数を宣言してインスタンスを代入
        Player myPlayer3 = new Player(200, 100);

        // SuperPlayerクラスの変数を宣言してインスタンスを代入
        SuperPlayer mySuperPlayer = new SuperPlayer();
        // SuperPlayerクラスのメンバ変数にアクセスして値を代入
        mySuperPlayer.hp = 100;
        mySuperPlayer.power = 50;
        // SuperPlayerクラスのメンバ関数にアクセスして実行
        mySuperPlayer.Attack();
        mySuperPlayer.Damage(30);
        mySuperPlayer.SpecialAttack();
    }
}

// Classを作成する
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

// Playerクラスを継承したSuperPlayerクラスを作成する
public class SuperPlayer : Player
{
    // コンストラクタ
    public SuperPlayer()
    {
        Debug.Log("SuperPlayerクラスのコンストラクタが実行されました");
    }

    // コンストラクタ 引数あり
    public SuperPlayer(int hp, int power) : base(hp, power)
    {
        Debug.Log("SuperPlayerクラスのコンストラクタが実行されました 引数あり");
    }

    // メンバ関数
    public void SpecialAttack()
    {
        Debug.Log(this.power * 2 + "のダメージを与えた 特殊攻撃");
    }
}