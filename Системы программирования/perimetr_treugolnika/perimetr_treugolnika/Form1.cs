using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace perimetr_treugolnika
{
    public partial class Form1 : Form
    {
        public static double getLength(double x1, double y1, double x2, double y2) {
            return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double AB = getLength(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox3.Text));
            double AC = getLength(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox5.Text));
            double BC = getLength(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox5.Text));
            if ((AB + AC <= BC) || (AB + BC <= AC) || (BC + AC <= AB))
            {
                MessageBox.Show("Треугольника с такими сторонами не существует!");
            }
            else 
            {
                double perimeter = AB + AC + BC;
                MessageBox.Show("Perimeter = " + perimeter);    
            }
            
        }
    }
}
