using UnityEngine;

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