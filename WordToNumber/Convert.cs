using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordToNumber
{
    enum suffixes: long
    { 
        hundred = 100,
        thousand = 1000,
        million = 1000000,
        billion = 1000000000,
        trillion = 1000000000000,
        quadrillion = 1000000000000000
    }

    public static class Convert
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            while (true)
            {
                Console.Write("Input: ");
                string word = Console.ReadLine();
                Console.WriteLine(GetNum(word));
            }
        }

        static string GetWord(long num)
        {
            List<string> numPairs = new List<string>();
            string strum = num.ToString();

            int counter = 0;
            for (int i = strum.Length - 1; i >= 0; i--)
            { 
                
            }
        }

        static long GetNum(string str)
        {
            string[] words = str.ToLower().Replace(" ", "").SplitBeforeAfter(Enum.GetNames(typeof(suffixes)));
            List<long> sums = new List<long>();
            bool lastMult = true;

            foreach (string word in words)
            {
                if (GetMultNumber(word) == 0 && lastMult)
                {
                    sums.Add(GetDoubleDigitWordToNum(word));
                    lastMult = false;
                }
                else if (GetMultNumber(word) == 0 && !lastMult)
                {
                    sums[sums.Count - 1] += GetDoubleDigitWordToNum(word);
                }
                else
                {
                    sums[sums.Count - 1] *= GetMultNumber(word);
                    if (GetMultNumber(word) > 100)
                    {
                        lastMult = true;
                    }
                    else
                    {
                        lastMult = false;
                    }
                }
            }
            return sums.Sum();
        }

        static string[] SplitAfter(this string str, string sub)
        {
            List<string> words = new List<string>();
            int wordStart = 0;

            for (int i = 0; i < str.Length - (sub.Length - 1); i++)
            {
                if (str.Substring(i, sub.Length) == sub)
                {
                    words.Add(str.Substring(wordStart, i + sub.Length - wordStart));
                    wordStart = i + sub.Length;
                }
                else if (i + 1 >= str.Length - (sub.Length - 1))
                {
                    words.Add(str.Substring(wordStart, str.Length - wordStart));
                }
            }

            return words.ToArray();
        }

        static string[] SplitBeforeAfter(this string str, string[] sub)
        {
            List<string> words = new List<string>();

            int lastWordStart;
            int lastWordEnd = 0;
            int wordStart = 0;
            int wordEnd = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for(int y = 0; y < sub.Length; y++)
                {
                    if (i + sub[y].Length <= str.Length && str.Substring(i, sub[y].Length) == sub[y])
                    {
                        lastWordStart = wordStart;
                        wordStart = i;
                        wordEnd = wordStart + sub[y].Length;
                        if (!words.Contains(str.Substring(lastWordStart, wordStart - lastWordStart)))
                        {
                            words.Add(str.Substring(lastWordEnd, wordStart - lastWordEnd));
                        }
                        lastWordEnd = wordStart + sub[y].Length;
                        words.Add(str.Substring(wordStart, sub[y].Length));
                        break;
                    }
                    else if (i + 1 >= str.Length && y + 1 >= sub.Length)
                    {
                        words.Add(str.Substring(wordEnd, str.Length - wordEnd));
                    }
                }
            }

            return words.Where(s => s != string.Empty).ToArray();
        }

        static long GetMultNumber(string word)
        {
            suffixes val = 0;
            foreach (string name in Enum.GetNames(typeof(suffixes)).Where(s => s == word))
            {
                Enum.TryParse(name, true, out val);
            }
            return (long)val;
        }

        static long GetDoubleDigitWordToNum(string str)
        {
            List<int> numsToAdd = new List<int>();

            foreach (string st in str.Replace(" ", "").SplitAfter("ty"))
            {
                str = st.ToLower();
                string first = str.Substring(0, 2);
                string lastFour = null;
                string lastTwo = null;

                try
                {
                    lastTwo = str.Substring(str.Length - 2);
                    lastFour = str.Substring(str.Length - 4);
                }
                catch { }

                switch (first)
                {
                    case "on":
                        numsToAdd.Add(1);
                        break;
                    case "tw":
                        if (lastTwo == "ve") numsToAdd.Add(12);
                        else if (lastTwo == "ty") numsToAdd.Add(20);
                        else numsToAdd.Add(2);
                        break;
                    case "th":
                        if (lastFour == "teen") numsToAdd.Add(13);
                        else if (lastTwo == "ty") numsToAdd.Add(30);
                        else numsToAdd.Add(3);
                        break;
                    case "fo":
                        if (lastFour == "teen") numsToAdd.Add(14);
                        else if (lastTwo == "ty") numsToAdd.Add(40);
                        else numsToAdd.Add(4);
                        break;
                    case "fi":
                        if (lastFour == "teen") numsToAdd.Add(15);
                        else if (lastTwo == "ty") numsToAdd.Add(50);
                        else numsToAdd.Add(5);
                        break;
                    case "si":
                        if (lastFour == "teen") numsToAdd.Add(16);
                        else if (lastTwo == "ty") numsToAdd.Add(60);
                        else numsToAdd.Add(6);
                        break;
                    case "se":
                        if (lastFour == "teen") numsToAdd.Add(17);
                        else if (lastTwo == "ty") numsToAdd.Add(70);
                        else numsToAdd.Add(7);
                        break;
                    case "ei":
                        if (lastFour == "teen") numsToAdd.Add(18);
                        else if (lastTwo == "ty") numsToAdd.Add(80);
                        else numsToAdd.Add(8);
                        break;
                    case "ni":
                        if (lastFour == "teen") numsToAdd.Add(19);
                        else if (lastTwo == "ty") numsToAdd.Add(90);
                        else numsToAdd.Add(9);
                        break;
                    case "te":
                        numsToAdd.Add(10);
                        break;
                    case "el":
                        numsToAdd.Add(11);
                        break;
                    case "ze":
                        numsToAdd.Add(0);
                        break;
                }
            }
            return numsToAdd.Sum();
        }
    }
}
