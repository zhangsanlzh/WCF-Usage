using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Caculator.CaculatorService;

namespace Caculator
{
    public partial class Form1 : Form
    {
        CaculatorServiceClient cliet;

        public Form1()
        {
            InitializeComponent();
            cliet = new CaculatorServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            label1.Text = cliet.Plus(a, b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            label1.Text = cliet.Subtract(a, b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = cliet.GetResult().ToString();
        }
    }
}
