using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LinqSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] _texts;
    [SerializeField] Button[] _buttons;

    // classの定義
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    void Start()
    {
        //GetLinqSample();
        //GetListSample();
        //GetArraySample();
        //GetDictionarySample();
        //GetLinqSampleMethods();

        // PersonクラスのListを作成
        var persons = new List<Person>
        {
            new Person { Id = 1, Name = "A", Age = 10 },
            new Person { Id = 2, Name = "B", Age = 20 },
            new Person { Id = 3, Name = "C", Age = 30 },
            new Person { Id = 4, Name = "D", Age = 40 },
            new Person { Id = 5, Name = "E", Age = 50 },
        };
        // Whereメソッドで条件に合うものを抽出
        var persons2 = persons.Where(p => p.Age >= 30).ToList();

        // PersonクラスのArrayを作成
        var persons3 = new Person[]
        {
            new Person { Id = 1, Name = "A", Age = 10 },
            new Person { Id = 2, Name = "B", Age = 20 },
            new Person { Id = 3, Name = "C", Age = 30 },
            new Person { Id = 4, Name = "D", Age = 40 },
            new Person { Id = 5, Name = "E", Age = 50 },
        };
        // Whereメソッドで条件に合うものを抽出
        var persons4 = persons3.Where(p => p.Age <= 30).ToArray();

        // PersonクラスのDictionaryを作成
        var persons5 = new Dictionary<int, Person>
        {
            { 1, new Person { Id = 1, Name = "A", Age = 10 } },
            { 2, new Person { Id = 2, Name = "B", Age = 20 } },
            { 3, new Person { Id = 3, Name = "C", Age = 30 } },
            { 4, new Person { Id = 4, Name = "D", Age = 40 } },
            { 5, new Person { Id = 5, Name = "E", Age = 50 } },
        };
        // Whereメソッドで条件に合うものを抽出
        var persons6 = persons5.Where(p => p.Value.Age >= 40).ToDictionary(p => p.Key, p => p.Value);


        // LinQのサンプル Array型
        var array = new int[] { 1, 2, 3, 4, 5 };
        var array2 = array.Where(i => i % 2 == 0).ToArray();
        // LinQのサンプル List型
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var list2 = list.Where(i => i % 2 == 0).ToList();
        // LinQのサンプル Dictionary型
        var dictionary = new Dictionary<int, string>
        {
            { 1, "1" },
            { 2, "2" },
            { 3, "3" },
        };
        var dictionary2 = dictionary.Where(i => i.Key % 2 == 0).ToDictionary(i => i.Key, i => i.Value);

        // 以下すべてToarrayしてるけどしなくてもループできる
        // Debugで確認するときはToArrayしておくとループせずに中身確認できる
        // _textsの要素をすべて取得
        var texts = _texts.Select(text => text.text).ToArray();

        // _buttonsの要素をすべて取得
        var buttons = _buttons.Select(button => button.gameObject).ToArray();

        // _buttonsの要素のTextをすべて取得
        var buttonsTexts = _buttons.Select(button => button.GetComponentInChildren<TextMeshProUGUI>().text).ToArray();

        // _buttonsのinteractableがfalseの要素をすべて取得
        var interactableButtons = _buttons.Where(button => button.interactable == false).ToArray();
    }

    void GetLinqSampleMethods()
    {
        /*
         * 要素の取得（単一）
         */
        // LinqのFirstのサンプル
        var list = new List<int> { 3, 2, 1, 4, 5, 5 };
        var first = list.First();
        // LinqのFirst 条件付きのサンプル
        var first2 = list.First(i => i % 2 == 0);
        // LinqのFirst 条件に合わない場合は例外が発生する
        // try catchで囲むか、FirstOrDefaultを使う
        try
        {
            var first3 = list.First(i => i > 6);
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }
        // LinqのFirstOrDefaultのサンプル
        var firstOrDefault = list.FirstOrDefault();
        // LinqのFirstOrDefault 条件付きのサンプル
        var firstOrDefault2 = list.FirstOrDefault(i => i % 2 == 0);
        // LinqのFirstOrDefault 条件に合わない場合はデフォルト値が返る
        var firstOrDefault3 = list.FirstOrDefault(i => i > 6);

        // LinqのLastのサンプル
        var last = list.Last();
        // LinqのLast 条件付きのサンプル
        var last2 = list.Last(i => i % 2 == 0);
        // LinqのLast 条件に合わない場合は例外が発生する
        // try catchで囲むか、LastOrDefaultを使う
        try
        {
            var last3 = list.Last(i => i > 6);
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }
        // LinqのLastOrDefaultのサンプル
        var lastOrDefault = list.LastOrDefault();
        // LinqのLastOrDefault 条件付きのサンプル
        var lastOrDefault2 = list.LastOrDefault(i => i % 2 == 0);
        // LinqのLastOrDefault 条件に合わない場合はデフォルト値が返る
        var lastOrDefault3 = list.LastOrDefault(i => i > 6);


        /*
         * 要素の取得（複数）
         */
        // LinqのWhereのサンプル
        var where = list.Where(i => i % 2 == 0).ToArray();
        // LinqのWhere 条件に合わない場合は空の配列が返る
        var where2 = list.Where(i => i > 6).ToArray();

        // LinqのDistinctのサンプル
        var distinct = list.Distinct().ToArray();
    
        /*
         * 集計系
         */
        // LinqのMaxのサンプル
        var max = list.Max();
        // LinqのMinのサンプル
        var min = list.Min();
        // LinqのSumのサンプル
        var sum = list.Sum();
        // LinqのAverageのサンプル
        var average = list.Average();
        // LinqのCountのサンプル
        var count = list.Count();

        /*
         * 判定系
         */
        // LinqのAllのサンプル
        var all = list.All(i => i > 0);
        // LinqのAll 条件に合わない場合はfalseが返る
        var all2 = list.All(i => i > 6);

        // LinqのAnyのサンプル
        var any = list.Any(i => i > 0);
        // LinqのAny 条件に合う場合はtrueが返る
        var any2 = list.Any(i => i > 2);
        // LinqのAny 条件に合わない場合はfalseが返る
        var any3 = list.Any(i => i > 6);

        // LinqのContainsのサンプル
        var contains = list.Contains(1);
        // LinqのContains 条件に合う場合はtrueが返る
        var contains2 = list.Contains(2);
        // LinqのContains 条件に合わない場合はfalseが返る
        var contains3 = list.Contains(6);

        /*
         * 並び替え系
         */
        // LinqのOrderByのサンプル
        var orderBy = list.OrderBy(i => i).ToArray();
        // LinqのOrderByDescendingのサンプル
        var orderByDescending = list.OrderByDescending(i => i).ToArray();
    }

    void GetDictionarySample()
    {
        // Dictionaryのサンプル
        var dictionary = new Dictionary<int, string>
        {
            { 1, "aa" },
            { 2, "bb" },
            { 3, "cc" },
            { 4, "dd" },
            { 5, "ee" },
        };
        // Dictionaryの要素を変更
        dictionary = dictionary.ToDictionary(x => x.Key, x => x.Value + x.Value);
        // Dictionaryのメソッドサンプル
        dictionary.Add(6, "6");
        dictionary.Remove(1);
        dictionary.Clear();
    }

    void GetArraySample()
    {
        // Arrayのサンプル
        var array = new[] { 1, 2, 3, 4, 5 };
        // Arrayの要素をすべて2倍にする
        array = array.Select(i => i * 2).ToArray();
        // Arrayのメソッドサンプル
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;
        array = array.Where(i => i % 2 == 0).ToArray();
    }

    void GetListSample()
    {
        // Listのサンプル
        var list = new List<int> { 1, 2, 3, 4, 5 };
        // Listの要素をすべて2倍にする
        list = list.Select(i => i * 2).ToList();
        // Listのメソッドサンプル
        list.Add(6);
        list.Remove(1);
        list.RemoveAt(0);
        list.Insert(0, 1);
        list.Sort();
        list.Reverse();
        list.Clear();
    }

    void GetLinqSample()
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
