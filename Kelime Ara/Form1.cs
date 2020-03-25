using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kelime_Ara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Konum = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            string Kelime = textBox1.Text;
            string Metin = textBox2.Text;

            Konum = Metin.IndexOf(Kelime, Konum + 1);

            textBox2.Focus();
            if (Konum != -1)
                textBox2.Select(Konum, Kelime.Length);
            else
                MessageBox.Show("Aradığınız Kelime bulunamadı");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
