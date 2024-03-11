using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalitim__inheritance_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class3 class3 = new Class3();
            class3.metot2();
            class3.metot();
            textBox1.Text = class3.id + Environment.NewLine; // yeni satır at
            textBox1.Text = class3.ad + Environment.NewLine;
            textBox1.Text = class3.soyad + Environment.NewLine;
            textBox1.Text = class3.pozisyon+ Environment.NewLine;
            textBox1.Text = class3.maas + Environment.NewLine;
            textBox1.Text = class3.brans+ Environment.NewLine;
        }
    }
}
