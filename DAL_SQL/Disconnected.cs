using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL_SQL
{
    public class Disconnected
    {
        public void Update(DataSet ds)
        {
            var cn = new SqlConnection(@"Server=DESKTOP-H982BU0\SQLEXPRESS; Initial Catalog=LastraJulianDev;Integrated Security=True");

            var query = "SELECT* FROM Clients";

            var da = new SqlDataAdapter(query,cn);

            var cb = new SqlCommandBuilder(da);

            da.InsertCommand = cb.GetInsertCommand();
            da.UpdateCommand = cb.GetUpdateCommand();
            da.DeleteCommand = cb.GetDeleteCommand();

            da.ContinueUpdateOnError = true;

            da.Fill(ds);

            da.Update(ds.Tables[0]);

        }

        public DataSet Read(string query)
        {
            var cn = new SqlConnection(@"Server=DESKTOP-H982BU0\SQLEXPRESS; Initial Catalog=LastraJulianDev;Integrated Security=True");

            var ds = new DataSet();

            try
            {
                // creo el data adapter y lleno el DataSet
                SqlDataAdapter Da = new SqlDataAdapter(query,cn);
                Da.Fill(ds);
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return ds;
        }
      
    }
}
