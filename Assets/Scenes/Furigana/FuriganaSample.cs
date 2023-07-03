using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FuriganaSample : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleText;

    void Start()
    {
        // NameAndFuriganaクラス3人分のリストを作成
        var nameAndFuriganaList = new List<NameAndFurigana>()
        {
            new NameAndFurigana("発電所", "はつでんしょ"),
            new NameAndFurigana("風", "かぜ"),
            new NameAndFurigana("回復", "かいふく"),
        };

        // リストの要素をランダムに取得
        var nameAndFurigana = nameAndFuriganaList[Random.Range(0, nameAndFuriganaList.Count)];

        // furiganaの文字数を取得
        int furiganaLength = nameAndFurigana.Furigana.Length;

        // NameとFuriganaをTextMeshProUGUIに設定
        _titleText.text = $"{nameAndFurigana.Name}<style=p{furiganaLength}>{nameAndFurigana.Furigana}</style>";
    }
}


// NameとFuriganaを持つクラス
public class NameAndFurigana
{
    public string Name { get; set; }
    public string Furigana { get; set; }

    public NameAndFurigana(string name, string furigana)
    {
        Name = name;
        Furigana = furigana;
    }
}