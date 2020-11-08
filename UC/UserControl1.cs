using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

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
            var dal = new DAL_SQL.Disconnected();
            dst = dal.Read("SELECT * FROM Clients");
            DataColumn[] dc = new DataColumn[1];
            dc[0] = dst.Tables[0].Columns[0];
            dst.Tables[0].PrimaryKey = dc;

            dataGridView1.DataSource = dst.Tables[0];
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dal = new DAL_SQL.Disconnected();
            dynamic dn = "SELECT* FROM Clients";
            dal.Update(dn, dst);
        }
    }
}
