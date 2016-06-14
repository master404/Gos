using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace text_parser
{
    public partial class Form1 : Form
    {
        public static string Calc(string str) 
        {
            string pattern = @"[0-9]+";
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = reg.Matches(str);
            string s1 = Convert.ToString(matches[0]);
            string s2 = Convert.ToString(matches[1]);
            double result = Convert.ToDouble(s1) + Convert.ToDouble(s2);
            return Convert.ToString(result);
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string origin_text = richTextBox1.Text;
            string copy_text = richTextBox1.Text;
            string pattern = @"\b[0-9]+[+][0-9]+\b";
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = reg.Matches(origin_text);
            foreach(Match match in matches)
            {
                string a = Convert.ToString(match);
                copy_text = copy_text.Replace(a, Calc(a));
            };
            richTextBox2.Text = copy_text;
        }
    }
}
