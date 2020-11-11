using BLL_Negocio;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

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
            var x = new N_Proyects();
            x.Create(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            MDIParent1 m = new MDIParent1();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = new N_Proyects();
            x.Write(textBox1.Text, textBox2.Text, textBox3.Text);
          
            listBox1.DataSource = x.Read();
            listBox1.DisplayMember = "name";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var x = new N_Proyects();
            listBox1.DataSource = x.Read();
            listBox1.DisplayMember = "name";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //English
            ChangeLang("EN-US");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Spanish
            ChangeLang("ES-AR");
        }

        public void ChangeLang(string Culture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Culture);

            if (Culture == "ES-AR")
            {
                label1.Text = UI_ProgramsES_AR.label1;
                label2.Text = UI_ProgramsES_AR.label2;
                label3.Text = UI_ProgramsES_AR.label3;
                label4.Text = UI_ProgramsES_AR.label4;
                button1.Text = UI_ProgramsES_AR.Button1;
                button2.Text = UI_ProgramsES_AR.Button2;
                button2.Text = UI_ProgramsES_AR.Button3;
                button4.Text = UI_ProgramsES_AR.Button4;
            }
            else
            {
                label1.Text = UI_ProgramsEN_US.label1;
                label2.Text = UI_ProgramsEN_US.label2;
                label3.Text = UI_ProgramsEN_US.label3;
                label4.Text = UI_ProgramsEN_US.label4;
                button1.Text = UI_ProgramsEN_US.Button1;
                button2.Text = UI_ProgramsEN_US.Button2;
                button2.Text = UI_ProgramsEN_US.Button3;
                button4.Text = UI_ProgramsEN_US.Button4;
            }
        }
    }
}
