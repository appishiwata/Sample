using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        // ランダムな値をDebug.Logで表示する
        Debug.Log(Random.Range(0, 100));
    }
}
