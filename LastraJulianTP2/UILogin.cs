using BE_Propiedades;
using BLL_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastraJulianTP2
{
    public partial class UILogin : Form
    {
        public bool change = true;
        private BE_Users user;
        private N_Users userLogin;
        public UILogin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cambiar idioma. Como trato solo con ENG y con ESP. Uso un true 
            //para validar en que idioma estoy y de ahi cambiarlo al otro.
            if (change == true)
            {
                label1.Text = UI_LoginES_AR.label1;
                label2.Text = UI_LoginES_AR.label2;
                label3.Text = UI_LoginES_AR.label3;
                button1.Text = UI_LoginES_AR.Button3;
                button2.Text = UI_LoginES_AR.Button2;
                button3.Text = UI_LoginES_AR.Button1;
                button4.Text = UI_LoginES_AR.Button4;
                change = false;
            }
            else
            {
                label1.Text = UI_LoginEN_US.label1;
                label2.Text = UI_LoginEN_US.label2;
                label3.Text = UI_LoginEN_US.label3;
                button1.Text = UI_LoginEN_US.Button3;
                button2.Text = UI_LoginEN_US.Button2;
                button3.Text = UI_LoginEN_US.Button1;
                button4.Text = UI_LoginEN_US.Button4;
                change = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "admin";
            textBox2.Text = "admin";
            label3.Text = "Usuario para login cargado";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //LOGIN
            //Si no pongo nada me logueo d1 porque alta paja escribir sino
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                var nf = new UI_Core();
                nf.Show();
                Hide();
            }
            else
            {
                user = new BE_Users();
                userLogin = new N_Users();

                user.UserName = textBox1.Text;
                user.PassWord = textBox2.Text;

                var userBack = userLogin.LoadUsers(user);

                if (userBack[1] == user.PassWord)
                {
                    var nf = new UI_Core();
                    nf.Show();
                    Hide();
                }
                else 
                {
                    label3.Text = "No pa, le pifiaste, try again";
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            
        }
    }
}
