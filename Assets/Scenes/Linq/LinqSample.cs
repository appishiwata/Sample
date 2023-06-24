using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqSample : MonoBehaviour
{
    void Start()
    {
        // Linqのサンプル
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var result = list.Where(i => i % 2 == 0);
        foreach (var i in result)
        {
            Debug.Log("result: " + i);
        }

        // Linqのサンプル
        var list2 = new List<int> { 1, 2, 3, 4, 5 };
        var result2 = list2.Where(i => i % 2 == 0).Select(i => i * 2);
        foreach (var i in result2)
        {
            Debug.Log("result2: " + i);
        }

        // Linqのサンプル
        var list3 = new List<int> { 1, 2, 3, 4, 5 };
        var result3 = list3.Where(i => i % 2 == 0).Select(i => i * 2).ToList();
        foreach (var i in result3)
        {
            Debug.Log("result3: " + i);
        }

        // Linqのサンプル
        var list4 = new List<int> { 1, 2, 3, 4, 5 };
        var result4 = list4.Where(i => i % 2 == 0).Select(i => i * 2).ToArray();
        foreach (var i in result4)
        {
            Debug.Log("result4: " + i);
        }

        // Linqのサンプル
        var list5 = new List<int> { 1, 2, 3, 4, 5 };
        var result5 = list5.Where(i => i % 2 == 0).Select(i => i * 2).ToDictionary(i => i);
        foreach (var i in result5)
        {
            Debug.Log("result5: " + i);
        }
    }
}
