using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    internal class ProceduraTXT
    {
        static public void Procedura()
        {
            string path = @"Primer.txt";

            string str = File.ReadAllText(path);
            string word = "";
            List<string> wordsList = new List<string>();
            foreach (char item in str)
            {

                if (item == '!' || item == ',' || item == ' ' || item == '.' || item == '?')
                {
                    wordsList.Add(word);
                    word = "";
                }
                else
                {
                    word += item;
                }
            }
            foreach (string item in wordsList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static string FilesList(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            try
            {
                if (di.Exists)
                {
                    foreach (var item in di.GetDirectories())
                    {
                        Console.WriteLine(item);
                        FilesList(item.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return "good";
        }
    }
}
