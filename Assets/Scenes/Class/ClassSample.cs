using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClassSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _userIDText;
    [SerializeField] TextMeshProUGUI _userNameText;
    [SerializeField] TextMeshProUGUI _userGoldText;
    
    [SerializeField] Button _getGoldButton;
        
    void Start()
    {
        //Sample();
        //Sample2();
        //CreateUser();
        
        // myUserInfoをLoadする
        UserInfo myUserInfo = new UserInfo();
        myUserInfo.Load();
        _userIDText.text = myUserInfo.ID.ToString();
        _userNameText.text = myUserInfo.Name;
        _userGoldText.text = myUserInfo.Gold.ToString();

        // _getGoldButtonを押したらGoldを増やす
        _getGoldButton.onClick.AddListener(() =>
        {
            myUserInfo.Gold += 10;
            myUserInfo.Save();
            _userGoldText.text = myUserInfo.Gold.ToString();
        });
    }

    void CreateUser()
    {
        // UserInfoクラスの変数を宣言してインスタンスを代入
        UserInfo myUserInfo = new UserInfo();
        // UserInfoクラスのメンバ変数にアクセスして値を代入
        myUserInfo.ID = 1;
        myUserInfo.Name = "Taro";
        myUserInfo.Gold = 20;
        // UserInfoクラスのメンバ関数にアクセスして実行
        myUserInfo.Save();
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

    void Sample2()
    {
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

        // 要素としてIDと名前とGoldを持つDictionaryを作成
        var playerDict = new Dictionary<int, string>();
        playerDict.Add(1, "tanaka");
        playerDict.Add(2, "suzuki");
        playerDict.Add(3, "yamada");

        // Enemyクラスに変換
        var enemyList = playerDict.Select(player => new Enemy(player)).ToList();
        foreach (var enemy in enemyList)
        {
            Debug.Log(enemy.ID + " " + enemy.Name + " " + enemy.Gold);
        }
    }
}

public class Enemy
{
    public string ID;
    public string Name;
    public int Gold;

    public Enemy(string id, string name, int Gold)
    {
        this.ID = id;
        this.Name = name;
        this.Gold = Gold;
    }

    public Enemy(KeyValuePair<int, string> player)
    {
        this.ID = Convert.ToString(player.Key);
        this.Name = player.Value;
        this.Gold = 20 * player.Key;
    }
}