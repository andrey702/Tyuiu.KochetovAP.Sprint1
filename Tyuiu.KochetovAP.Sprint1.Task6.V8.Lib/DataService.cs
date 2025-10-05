using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KochetovAP.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            if (string.IsNullOrEmpty(word) || word.Length == 1)
                return word;

            return word.Substring(1) + word[0];
        }

        public static string TransformText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = MoveLetterToEnd(words[i]);
            }

            return string.Join(" ", words);
        }
    }
}
