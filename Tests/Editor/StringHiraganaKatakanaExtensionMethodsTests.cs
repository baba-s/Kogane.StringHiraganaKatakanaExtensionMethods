using NUnit.Framework;

namespace Kogane.Test
{
    internal sealed class StringHiraganaKatakanaExtensionMethodsTest
    {
        private const string HIRAGANA = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよらりるれろわをんがぎぐげござじずぜぞだぢづでどばびぶべぼぱぴぷぺぽぁぃぅぇぉっゃゅょゔ";
        private const string KATAKANA = "アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲンガギグゲゴザジズゼゾダヂヅデドバビブベボパピプペポァィゥェォッャュョヴ";

        [Test]
        public void ToKatakana()
        {
            Assert.IsTrue( HIRAGANA.ToKatakana() == KATAKANA );
        }

        [Test]
        public void ToHiragana()
        {
            Assert.IsTrue( KATAKANA.ToHiragana() == HIRAGANA );
        }
    }
}