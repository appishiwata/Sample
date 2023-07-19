using UnityEngine;

public class UserInfo
{
    public int ID;
    public string Name;
    public int Age;
    
    // 端末に保存
    public void Save()
    {
        PlayerPrefs.SetInt("ID", this.ID);
        PlayerPrefs.SetString("Name", this.Name);
        PlayerPrefs.SetInt("Age", this.Age);
    }
    
    // 端末から読み込み
    public void Load()
    {
        this.ID = PlayerPrefs.GetInt("ID");
        this.Name = PlayerPrefs.GetString("Name");
        this.Age = PlayerPrefs.GetInt("Age");
    }
}