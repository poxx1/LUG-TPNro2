using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mapper;

namespace UC
{
    public partial class UserControl1 : UserControl
    {
        DataSet dst = new DataSet();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dal = new DAL_SQL.Disconnected();

            dataGridView1.DataSource = null;

            dal.Update(dst);

            label2.Text = "La base de datos de clientes, ha sido actualizada";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            M_Clients m_Clients = new M_Clients();

            dst = m_Clients.Read();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dst.Tables[0];

            label2.Text = "Los datos fueron cargados con Exito";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            M_Clients m_Clients = new M_Clients();
            dst = m_Clients.Read();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dst.Tables[0];
            label2.Text = "Se descartaron los cambios realizados.";
        }
    }
}
