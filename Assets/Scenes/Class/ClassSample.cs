using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ClassSample : MonoBehaviour
{
    void Start()
    {
        //Sample();

        //Playerクラスのリストを作成
        var playerList = new List<Player>();
        //Playerクラスのインスタンスを作成
        var player1 = new Player(200, 50);
        var player2 = new Player(300, 100);
        var player3 = new Player(400, 150);
        playerList.Add(player1);
        playerList.Add(player2);
        playerList.Add(player3);

        var playerList2 = playerList.Where(player => player.hp > 300);

        // 要素としてIDと名前とAgeを持つDictionaryを作成
        var playerDict = new Dictionary<int, string>();
        playerDict.Add(1, "tanaka");
        playerDict.Add(2, "suzuki");
        playerDict.Add(3, "yamada");

        // Enemyクラスに変換
        var enemyList = playerDict.Select(player => new Enemy(player)).ToList();
        foreach (var enemy in enemyList)
        {
            Debug.Log(enemy.ID + " " + enemy.Name + " " + enemy.Age);
        }
    }

    void Sample()
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

public class Enemy
{
    public string ID;
    public string Name;
    public int Age;

    public Enemy(string id, string name, int age)
    {
        this.ID = id;
        this.Name = name;
        this.Age = age;
    }

    public Enemy(KeyValuePair<int, string> player)
    {
        this.ID = Convert.ToString(player.Key);
        this.Name = player.Value;
        this.Age = 20 * player.Key;
    }
}