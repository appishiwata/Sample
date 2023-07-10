using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Create Player Data")]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public int playerLevel;
    public float health;
    public int score;
    
    // 任意のメソッドやプロパティを追加できます
}
