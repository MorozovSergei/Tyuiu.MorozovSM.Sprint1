using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MorozovSM.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string[] words = value.Trim().Split(' '); 
            string res = "";
            foreach (string word in words)
            {
                res += word[word.Length - 1];
            }
            return res;
        }
    }
}
