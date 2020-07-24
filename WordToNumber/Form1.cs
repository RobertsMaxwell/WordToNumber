using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordToNumber;

namespace WordToNumber
{
    public partial class Form1 : Form
    {
        string inputText = null;
        bool toWord = true;

        public Form1()
        {
            InitializeComponent();
            InitializeInputs();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (PopulateVariables())
            {
                if (toWord)
                {
                    try
                    {
                        var val = Converter.GetWord(long.Parse(inputText));
                        result.Text = val;
                    }
                    catch
                    {
                        MessageBox.Show("Error Calling \"GetWord\" method\nPlease correct your input");
                    }
                }
                else
                {
                    try
                    {
                        var val = Converter.GetNum(inputText);
                        result.Text = val.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Error Calling \"GetNum\" method\nPlease correct your input");
                    }
                }
            }
        }

        private bool PopulateVariables()
        {
            toWord = wordButton.Checked;
            inputText = input.Text;
            if (string.IsNullOrEmpty(inputText))
            {
                if (toWord)
                {
                    MessageBox.Show("Please input a number", "Input Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    MessageBox.Show("Please input a word", "Input Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            else if (!toWord && inputText.Any(c => int.TryParse(c.ToString(), out int fill)))
            {
                MessageBox.Show("Detected numeric input for Word to Number conversion", "Error", MessageBoxButtons.OK);
                return false;
            }
            else if (toWord && !int.TryParse(inputText, out int fill))
            {
                MessageBox.Show("Couldn't parse input text to number", "Error", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void InitializeInputs()
        {
            wordButton.Checked = true;
        }
    }
}
