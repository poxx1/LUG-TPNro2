using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Mapper
{
    public class M_Clients
    {
        public DataSet Read()
        {
            var dataa = new DAL_SQL.Disconnected();
            dynamic query = "Select * FROM Clients";
            return dataa.Read(query);
        }
    }
}

