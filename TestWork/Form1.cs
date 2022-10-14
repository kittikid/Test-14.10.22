using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string FindWords(string stroke) 
        {
            string result = "";
            char[] separators = new char[] { ' ', '.', ',', ';', ':', '!', '?', '-', '(', ')', '"', '/', '\'', '\\', '{', '}', '[', ']' }; //мне лень все разделители описывать D:
            string[] strokeArr = stroke.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < strokeArr.Length; ++i)
            {
                string comparisonWord = strokeArr[i];

                for (int j = i + 1; j < strokeArr.Length; ++j)
                {
                    string whomToCompareWords = strokeArr[j];

                    if (comparisonWord.Length != whomToCompareWords.Length) continue;

                    bool isValid = true;

                    for (int k = 0; k < comparisonWord.Length; ++k)
                    {
                        if (comparisonWord[k] != whomToCompareWords[whomToCompareWords.Length - k - 1])
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        bool isNotExist = true;
                        string[] buf = result.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        for (int p = 0; p < buf.Length; ++p)
                            if (comparisonWord == buf[p]) isNotExist = false;
                        
                        if (isNotExist)
                            result += $"Слова {comparisonWord} и {whomToCompareWords} обратимы." + "\n";
                    }
                }
            }
            return result;
        }

        private void ButtonFindWords_Click(object sender, EventArgs e)
        {
            outputText.Text = null;
            outputText.Text += FindWords(inputText.Text);
        }
    }
}
