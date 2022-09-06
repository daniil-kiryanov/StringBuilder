
using System.Text.RegularExpressions;
namespace StringBuilder
{
    internal class Program1
    {
        public static void Main()
        {
            //string[] delimiterChars = { " ", ",", ".", ":", ", "}; 
            //char[] delimiterChars = { ' ', ',', '.', ':' };

            string text = "зачем? прикол ты?!будешь0ульии бегать\tприберись";
            Console.WriteLine($"Original text: \n{text}");

            string[] words = Regex.Split(text, @"\W+");
            Console.WriteLine($"{words.Length} words in text:");

            foreach (var word in words)
            {
                ToTrimStartEnd(word);
                //Console.WriteLine($"<{word}>");
                
            }
        }
        public static string ToTrimStartEnd(string s2)
        {
            char[] charsToTrimStart = { 'п', 'р', 'и' };
            char[] charsToTrimEnd = { 'и', 'и' };
            s2 = s2.TrimStart(charsToTrimStart);
            s2 = s2.TrimEnd(charsToTrimEnd);
            //Console.Write(s2.TrimStart(charsToTrimStart).TrimEnd(charsToTrimEnd));
            Console.Write(s2);
            return s2;
            
        }
    }
}
