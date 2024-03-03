using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMOD_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mendapatkan nilai dari inputan textBox1
            string inputText = textBox1.Text;

            // Menampilkan nilai inputan di label1 dengan tambahan kata "hallo"
            label1.Text = "Hallo " + inputText;
            label1.Font = new Font(label1.Font.FontFamily, 16, label1.Font.Style);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kosongkan label saat inputan berubah
            label1.Text = "";
        }
    }
}