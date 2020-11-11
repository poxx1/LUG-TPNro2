using System;
using System.Data;

namespace BLL_Negocio
{
    public class N_Clients
    {
       
        public DataSet CreateDataset()
        {
            var ds = new DataSet();

            var dt = new DataTable("Client");

            var Key = new DataColumn();
            Key.ColumnName = "ID_Client";
            Key.DataType = typeof(Int32);
            Key.AutoIncrement = true;
            Key.AutoIncrementSeed = 1;
            Key.AutoIncrementStep = 1;
            Key.AllowDBNull = false;
            Key.Unique = true;

            dt.Columns.Add(Key);

            dt.PrimaryKey = new DataColumn[] { Key };



            return ds;
        }
    }
}
