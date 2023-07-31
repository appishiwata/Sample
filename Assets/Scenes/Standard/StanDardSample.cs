using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        // ランダムな値をDebug.Logで表示する
        Debug.Log(Random.Range(0, 100));
        
        // 色をつけてDebug.Logで表示する
        Debug.Log("<color=red>赤色</color>");
    }
}
