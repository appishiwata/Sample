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
    }
}

// Classを作成する
public class Player
{
    // メンバ変数
    public int hp = 100;
    public int power = 50;

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
}