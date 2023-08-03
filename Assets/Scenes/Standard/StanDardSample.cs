using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Scenes.Standard
{
    public class StandardSample : MonoBehaviour
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
            
            // ランダムな文字列を生成する
            Debug.Log(System.Guid.NewGuid().ToString());
            
            // ランダムな文字列を生成する
            Debug.Log(System.Guid.NewGuid().ToString("N"));
            
            // ランダムな文字列を生成する
            Debug.Log(System.Guid.NewGuid().ToString("D"));
            
            // ランダムな文字列を生成する 文字数5文字
            Debug.Log(System.Guid.NewGuid().ToString("N").Substring(0, 5));
            
            // Actionを使ってDebug.Logで表示する
            Action action = () => Debug.Log("Action");
            action();
            
            // Funcを使ってDebug.Logで表示する
            Func<string> func = () => "Func";
            Debug.Log(func());
        }
    }
}