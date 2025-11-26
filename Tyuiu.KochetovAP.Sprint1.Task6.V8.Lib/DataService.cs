using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KochetovAP.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] words = value.Split(' ');
            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    result += words[i].Substring(1) + words[i][0] + " ";
                }
                else
                {
                    result += words[i] + " ";
                }
            }

            return result.Trim();
        }
    }
}
