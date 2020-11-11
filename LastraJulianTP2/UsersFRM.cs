using System;
using System.Windows.Forms;

namespace LastraJulianTP2
{
    public partial class UsersFRM : Form
    {
        public UsersFRM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var BUser = new BE_Propiedades.BE_Users();
            var NUser = new BLL_Negocio.N_Users();

            BUser.UserName = textBox1.Text;
            BUser.PassWord = textBox2.Text;

            NUser.Insert(BUser);
            label3.Text = "User Inserted into the database";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            MDIParent1 m = new MDIParent1();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var BUser = new BE_Propiedades.BE_Users();
            var NUser = new BLL_Negocio.N_Users();

            BUser.UserName = textBox1.Text;

            NUser.Delete(BUser);

            label3.Text = "User Deleted from the database";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var BUser = new BE_Propiedades.BE_Users();
            var NUser = new BLL_Negocio.N_Users();

            BUser.UserName = textBox1.Text;
            BUser.PassWord = textBox2.Text;

            NUser.Update(BUser);
            label3.Text = "User Updated in the database";
        }
    }
}
