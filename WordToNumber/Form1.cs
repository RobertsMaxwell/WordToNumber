using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
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

            lightMode.Checked = true;
            lightMode_Click(null, null);
        }

        private void lightMode_Click(object sender, EventArgs e)
        {
            if (lightMode.Checked)
            {
                darkMode.Checked = false;
                darkMode.Visible = true;
                lightMode.Visible = false;

                Color lightColor = Color.White;

                menuStrip1.BackColor = lightColor;
                this.BackColor = lightColor;
                input.BackColor = lightColor;
                result.BackColor = lightColor;
                start.BackColor = lightColor;

                Font regularFont = new Font(convertLabel.Font, FontStyle.Regular);

                convertLabel.ForeColor = Color.Black;
                convertLabel.Font = regularFont;
                toLabel.ForeColor = Color.Black;
                toLabel.Font = regularFont;
                resultLabel.ForeColor = Color.Black;
                resultLabel.Font = regularFont;
                start.ForeColor = Color.Black;
                start.Font = regularFont;
                menuStrip1.ForeColor = Color.Black;
                menuStrip1.Font = regularFont;
                wordButton.ForeColor = Color.Black;
                wordButton.Font = regularFont;
                numberButton.ForeColor = Color.Black;
                numberButton.Font = regularFont;
                input.ForeColor = Color.Black;
                result.ForeColor = Color.Black;
            }
        }

        private void darkMode_Click(object sender, EventArgs e)
        {
            if (darkMode.Checked)
            {
                lightMode.Checked = false;
                lightMode.Visible = true;
                darkMode.Visible = false;

                ColorConverter conv = new ColorConverter();
                Color darkColor = (Color)conv.ConvertFromString("#162447");
                Color lighterDarkColor = (Color)conv.ConvertFromString("#1f4068");

                this.BackColor = darkColor;
                menuStrip1.BackColor = lighterDarkColor;
                input.BackColor = lighterDarkColor;
                result.BackColor = lighterDarkColor;
                start.BackColor = lighterDarkColor;

                Font boldFont = new Font(convertLabel.Font, FontStyle.Bold);

                convertLabel.ForeColor = Color.White;
                convertLabel.Font = boldFont;
                toLabel.ForeColor = Color.White;
                toLabel.Font = boldFont;
                resultLabel.ForeColor = Color.White;
                resultLabel.Font = boldFont;
                start.ForeColor = Color.White;
                start.Font = boldFont;
                wordButton.ForeColor = Color.White;
                wordButton.Font = boldFont;
                numberButton.ForeColor = Color.White;
                numberButton.Font = boldFont;
                menuStrip1.ForeColor = Color.White;
                input.ForeColor = Color.White;
                result.ForeColor = Color.White;
            }
        }
    }
}