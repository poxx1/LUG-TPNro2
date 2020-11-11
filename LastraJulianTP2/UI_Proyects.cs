using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LastraJulianTP2
{
    public partial class UI_Proyects : Form
    {
        public UI_Proyects()
        {
            InitializeComponent();
        }

        private void UI_Proyects_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validates();
        }

        public void Validates()
        {
            try
            {
                #region Vars
                //Para validar los campos
                bool v1, v2, v5;
                //Con esta var valido si escribieron algo para el orto
                bool isOk = false;
                #endregion

                label6.Text = "";

                #region Expresiones regulares + Validaciones
                //El nombre del proyecto solo tiene letras
                if (textBox4.Text.Length > 0)
                {
                    v1 = Regex.IsMatch(textBox4.Text, "^([a-zA-Z]+$)");
                    if (v1)
                        isOk = true;

                    else
                    {
                        isOk = false;
                        label6.Text = "Insert only text in Proyect name";
                    }
                }
                else
                {
                    label6.Text = "Proyect cannot be empty";
                }

                //Start Date tiene formato fecha
                v2 = Regex.IsMatch(textBox2.Text, "^([0][1-9]|[12][0-9]|3[01])(\\/|-)([0][1-9]|[1][0-2])\\2(\\d{4})$");
                if (v2)
                    isOk = true;

                else
                {
                    isOk = false;
                    label6.Text = label6.Text + " Insert date in the correct format";
                }

                //Valido que el año del proyecto no sea menor al comienzo de la empresa.
                var enterpriseStartDate = Convert.ToDateTime("01/01/1999");

                if (Convert.ToDateTime(textBox2.Text) > enterpriseStartDate)
                    isOk = true;

                else
                {
                    label6.Text = "Insert a valid date > 1999";
                    isOk = false;
                }

                //La WBS solo tiene numeros
                v5 = Regex.IsMatch(textBox3.Text, "^([0-9]+$)");
                if (v5)
                    isOk = true;

                else
                {
                    isOk = false;
                    label6.Text = label6.Text + " Insert only numbers in WBS";
                }

                #endregion

                //IF isOK == true, ins/upd/del > a la base de datos
                if (isOk)
                {

                }
                else
                {
                    label6.ForeColor = Color.Red;
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            MDIParent1 m = new MDIParent1();
            m.Show();
        }
    }
}
