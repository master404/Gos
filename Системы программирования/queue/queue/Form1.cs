using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int N = Convert.ToInt32(textBox3.Text);
            Queue<int> numbers = new Queue<int>();
            Queue<int> result = new Queue<int>();
            numbers.Enqueue(1);
            int cur = 1;
            while(numbers.Count > 0)
            {
                cur = numbers.Dequeue();
                result.Enqueue(cur);
                if ((cur + a <= N) && (!result.Contains(cur + a))) { numbers.Enqueue(cur + a); };
                if ((cur * b <= N) && (!result.Contains(cur * b))) { numbers.Enqueue(cur * b); };
            }
            foreach (int number in result) 
            {
                richTextBox1.Text += Convert.ToString(number)+" ";
            }
        }
    }
}
