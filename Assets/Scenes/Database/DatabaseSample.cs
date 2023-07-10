using UnityEngine;

public class DatabaseSample : MonoBehaviour
{
    //public PlayerData playerData;
    public PlayerDatas playerDatas;    
    void Start()
    {
        // 値を設定
        /*
        playerData.playerName = "Player2";
        playerData.playerLevel = 2;
        playerData.health = 200;
        playerData.score = 0;
        */
        
        // 値を取得
        /*
        Debug.Log("Player Name: " + playerData.playerName);
        Debug.Log("Player Level: " + playerData.playerLevel);
        Debug.Log("Player Health: " + playerData.health);
        Debug.Log("Player Score: " + playerData.score);
        */
        
        // PlayerDatasの中身を表示
        foreach (PlayerData data in playerDatas.playerDatas)
        {
            Debug.Log(data.playerName);
        }
    }
}
