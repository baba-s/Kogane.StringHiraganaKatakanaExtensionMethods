using System.Text;

namespace Kogane
{
    /// <summary>
    /// 文字列中のひらがなとカタカナを変換する拡張メソッド
    /// </summary>
    public static class StringHiraganaKatakanaExtensionMethods
    {
        //================================================================================
        // 定数
        //================================================================================
        private const char HIRAGANA_BEGIN = 'ぁ';
        private const char HIRAGANA_END   = 'ゖ';
        private const char KATAKANA_BEGIN = 'ァ';
        private const char KATAKANA_END   = 'ヶ';
        private const int  OFFSET         = KATAKANA_BEGIN - HIRAGANA_BEGIN;

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// ひらがなをカタカナに変換して返します
        /// </summary>
        public static string ToKatakana( this string self )
        {
            var stringBuilder = new StringBuilder( self.Length );

            foreach ( var c in self )
            {
                // ReSharper disable once MergeIntoPattern
                // 条件式をパターンに置き換えると正常に動作しなくなるので注意
                stringBuilder.Append( HIRAGANA_BEGIN <= c && c <= HIRAGANA_END ? ( char )( c + OFFSET ) : c );
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// カタカナをひらがなに変換して返します
        /// </summary>
        public static string ToHiragana( this string self )
        {
            var stringBuilder = new StringBuilder( self.Length );

            foreach ( var c in self )
            {
                // ReSharper disable once MergeIntoPattern
                // 条件式をパターンに置き換えると正常に動作しなくなるので注意
                stringBuilder.Append( KATAKANA_BEGIN <= c && c <= KATAKANA_END ? ( char )( c - OFFSET ) : c );
            }

            return stringBuilder.ToString();
        }
    }
}