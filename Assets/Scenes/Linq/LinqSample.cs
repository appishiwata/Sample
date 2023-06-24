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
            Debug.Log(i);
        }
    }
}
