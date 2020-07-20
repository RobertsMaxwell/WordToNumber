using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordToNumber
{
    static class Program
    {
        static string word = null;

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
                word = Console.ReadLine();
                Console.WriteLine(GetNum(word));
            }
        }

        static int GetNum(string str)
        {
            str = str.ToLower();
            string first = str.Substring(0, 2);
            string lastFour = null;
            string lastTwo = null;

            try
            {
                lastFour = str.Substring(str.Length - 4);
                lastTwo = lastFour.Substring(lastFour.Length - 2);
            }
            catch { }
            
            switch (first)
            {
                case "on":
                    return 1;
                case "tw":
                    if (lastTwo == "ve") return 12;
                    else if (lastTwo == "ty") return 20;
                    return 2;
                case "th":
                    if (lastFour == "teen") return 13;
                    else if (lastTwo == "ty") return 30;
                    return 3;
                case "fo":
                    if (lastFour == "teen") return 14;
                    else if (lastTwo == "ty") return 40;
                    return 4;
                case "fi":
                    if (lastFour == "teen") return 15;
                    else if (lastTwo == "ty") return 50;
                    return 5;
                case "si":
                    if (lastFour == "teen") return 16;
                    else if (lastTwo == "ty") return 60;
                    return 6;
                case "se":
                    if (lastFour == "teen") return 17;
                    else if (lastTwo == "ty") return 70;
                    return 7;
                case "ei":
                    if (lastFour == "teen") return 18;
                    else if (lastTwo == "ty") return 80;
                    return 8;
                case "ni":
                    if (lastFour == "teen") return 19;
                    else if (lastTwo == "ty") return 90;
                    return 9;
                case "te":
                    return 10;
                case "el":
                    return 11;
                case "ze":
                    return 0;
            }
            return -1;
        }
    }
}
