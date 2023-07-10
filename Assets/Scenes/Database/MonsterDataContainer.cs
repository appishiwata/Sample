using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "MonsterDataContainer", menuName = "Create Monster Data Container")]
public class MonsterDataContainer : ScriptableObject
{
    public List<Monster> monsters = new List<Monster>();
}