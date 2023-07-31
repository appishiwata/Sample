using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StanDardSample : MonoBehaviour
{
    void Start()
    {
        // ランダムな値をDebug.Logで表示する
        Debug.Log(Random.Range(0, 100));
        
        // 色をつけてDebug.Logで表示する
        Debug.Log("<color=red>赤色</color>");
        
        // 検索しやすいDebug.Logで表示する
        Debug.Log("【エラー】");
        
        // 配列定義 > リスト変換 > ForEachで表示
        string[] list = {"A", "B", "C"};
        list.ToList().ForEach(Debug.Log);
        
        // リスト定義 > ForEachで表示
        List<string> list2 = new List<string>() {"A", "B", "C"};
        list2.ForEach(Debug.Log);
    }
}
