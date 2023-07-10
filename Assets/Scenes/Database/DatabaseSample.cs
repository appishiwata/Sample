using UnityEngine;

public class DatabaseSample : MonoBehaviour
{
    //public PlayerData playerData;
    public PlayerDatas playerDatas;    
    
    public MonsterDataContainer monsterDataContainer;
    
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
        
        /*
        // Monsterデータの追加
        Monster monster1 = new Monster();
        monster1.name = "Monster 1";
        monster1.health = 100;

        Monster monster2 = new Monster();
        monster2.name = "Monster 2";
        monster2.health = 150;

        monsterDataContainer.monsters.Add(monster1);
        monsterDataContainer.monsters.Add(monster2);
        */
        
        // Monsterデータの表示
        foreach (Monster monster in monsterDataContainer.monsters)
        {
            Debug.Log(monster.name);
            Debug.Log(monster.health);
        }
    }
}
