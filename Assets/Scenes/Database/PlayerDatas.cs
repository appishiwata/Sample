using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "PlayerDatas", menuName = "Create Player Datas")]
public class PlayerDatas : ScriptableObject
{
    public List<PlayerData> playerDatas = new List<PlayerData>();
}