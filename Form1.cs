using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace provaGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_piu_Click(object sender, EventArgs e)
        {
            int num1=int.Parse(txt_num1.Text);
            int num2 = int.Parse(txt_num2.Text);
            int somma = Library.Somma(num1, num2);
            listBox1.Items.Clear();
            listBox1.Items.Add(num1+ " +");
            listBox1.Items.Add(num2 + " =");
            listBox1.Items.Add("---------");
            listBox1.Items.Add(somma);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_num1.Clear();
            txt_num2.Clear();
            listBox1.Items.Clear();
            txt_num1.Focus();
        }

        private void btn_esci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_meno_Click(object sender, EventArgs e)
        {

        }
    }
}
