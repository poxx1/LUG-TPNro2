using System;
using System.Windows.Forms;
using BLL_Negocio;

namespace LastraJulianTP2
{
    public partial class UI_Programs : Form
    {
        public UI_Programs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new XML();
            x.Create(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = new XML();
            x.Write(textBox1.Text, textBox2.Text, textBox3.Text);
        }
    }
}
