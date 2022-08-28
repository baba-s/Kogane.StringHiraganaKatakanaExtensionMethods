# Kogane String Hiragana Katakana Extension Methods

文字列中のひらがなとカタカナを変換できる拡張メソッド

## 使用例

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        Debug.Log( "あいうえお".ToKatakana() ); // アイウエオ
        Debug.Log( "アイウエオ".ToHiragana() ); // あいうえお
    }
}
```

## 備考

* 本リポジトリは以下のサイト様のプログラムを使用させていただいております
    * https://hacchi-man.hatenablog.com/entry/2021/11/15/220000