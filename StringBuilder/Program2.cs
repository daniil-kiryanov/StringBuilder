/*
using System.Text.RegularExpressions;

namespace StringBuilder
{
    internal class Program2
    {
        static void Main()
        {
            const string text = "Hello,/* my friend;!, please, go away, now";
            string[] words = Regex.Split(text, @"\W+");
            foreach (string word in words)
            {
                Console.WriteLine("Word: " + word);
            }
            //RandomString();
            
            //Console.WriteLine();
        }
        /*
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //
    }
}
*/