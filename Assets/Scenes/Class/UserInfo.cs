using UniRx;
using UnityEngine;

public class UserInfo
{
    public int ID;
    public string Name;
    public int Gold { get => GoldObservable.Value; set => GoldObservable.Value=value; }
    public ReactiveProperty<int> GoldObservable = new ReactiveProperty<int>(0);
    
    public int GoldWithTax { get => (int)(Gold * 1.1f); }

    // 端末に保存
    public void Save()
    {
        PlayerPrefs.SetInt("ID", this.ID);
        PlayerPrefs.SetString("Name", this.Name);
        PlayerPrefs.SetInt("Gold", this.Gold);
    }
    
    // 端末から読み込み
    public void Load()
    {
        this.ID = PlayerPrefs.GetInt("ID");
        this.Name = PlayerPrefs.GetString("Name");
        this.Gold = PlayerPrefs.GetInt("Gold");
    }
}