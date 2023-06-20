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