using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseSample : MonoBehaviour
{
    public PlayerData playerData;
    
    void Start()
    {
        /* 値を設定
        playerData.playerName = "Player1";
        playerData.playerLevel = 1;
        playerData.health = 100;
        playerData.score = 0;
        */
        
        // 値を取得
        Debug.Log("Player Name: " + playerData.playerName);
        Debug.Log("Player Level: " + playerData.playerLevel);
        Debug.Log("Player Health: " + playerData.health);
        Debug.Log("Player Score: " + playerData.score);
    }
}
