using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordToNumber
{
    enum suffixes : long
    { 
        hundred = 100,
        thousand = 1000,
        million = 1000000,
        billion = 1000000000,
        trillion = 1000000000000,
        quadrillion = 1000000000000000
    }

    enum altWords : int
    { 
        twen = 2,
        thir = 3,
        four = 4,
        fif = 5,
        six = 6,
        seven = 7,
        eigh = 8,
        nine = 9
    }

    public static class Converter
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string GetWord(long num)
        {
            string word = "";

            List<string> pairs = new List<string>();
            string strum = num.ToString();
            int inc = 1;

            for (int i = 0; i < strum.Length; i += inc)
            {
                if (i == 0)
                {
                    int size;
                    if (strum.Length > 3)
                    {
                        size = strum.Length % 3;
                        if (size == 0)
                        {
                            size = 3;
                        }
                    }
                    else
                    {
                        size = strum.Length;
                    }
                    pairs.Add(strum.Substring(i, size));
                    inc = size;
                }
                else
                {
                    var size = 3;
                    pairs.Add(strum.Substring(i, size));
                    inc = size;
                }

                if (inc == 0)
                {
                    return "";
                }
            }

            for (int i = 0; i < pairs.Count; i++)
            {
                if (long.Parse(pairs[i]) > 0)
                {
                    if (pairs[i].Length == 3)
                    {
                        if (long.Parse(pairs[i][0].ToString()) != 0)
                        {
                            word += " " + GetDoubleDigitNumToWord(long.Parse(pairs[i][0].ToString())) + " hundred " + GetDoubleDigitNumToWord(long.Parse(pairs[i].Substring(1, 2)));
                        }
                        else
                        {
                            word += " " + GetDoubleDigitNumToWord(long.Parse(pairs[i].Substring(1, 2)));
                        }
                    }
                    else
                    {
                        word += " " + GetDoubleDigitNumToWord(long.Parse(pairs[i]));
                    }

                    if (pairs.Count - (i + 1) > 0)
                    {
                        word += " " + Enum.GetNames(typeof(suffixes))[pairs.Count - (i + 1)];
                    }
                }
            }

            return word.Trim();
        }

        public static long GetNum(string str)
        {
            string[] words = str.ToLower().Replace(" ", "").Replace("-", "").SplitBeforeAfter(Enum.GetNames(typeof(suffixes)));
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

        static string GetDoubleDigitNumToWord(long num)
        {
            string str = num.ToString();

            switch (str[0])
            {
                case '1':
                    if (str.Length == 1)
                    {
                        return "one";
                    }
                    else if(str.Length == 2)
                    {
                        switch (str[1])
                        {
                            case '0':
                                return "ten";
                            case '1':
                                return "eleven";
                            case '2':
                                return "twelve";
                            default:
                                string word = ((altWords)int.Parse(str[1].ToString())).ToString();
                                return word + "teen";
                        }
                    }
                    break;
                case '2':
                    if (str.Length == 1)
                    {
                        return "two";
                    }
                    break;
                case '3':
                    if (str.Length == 1)
                    {
                        return "three";
                    }
                    break;
                case '4':
                    if (str.Length == 1)
                    {
                        return "four";
                    }
                    break;
                case '5':
                    if (str.Length == 1)
                    {
                        return "five";
                    }
                    break;
                case '6':
                    if (str.Length == 1)
                    {
                        return "six";
                    }
                    break;
                case '7':
                    if (str.Length == 1)
                    {
                        return "seven";
                    }
                    break;
                case '8':
                    if (str.Length == 1)
                    {
                        return "eight";
                    }
                    break;
                case '9':
                    if (str.Length == 1)
                    {
                        return "nine";
                    }
                    break;
            }

            if (str.Length == 2)
            {
                string word = ((altWords)int.Parse(str[0].ToString())).ToString();
                return word + "ty" + "-" + GetDoubleDigitNumToWord(int.Parse(str[1].ToString()));
            }
            else
            {
                return "";
            }
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