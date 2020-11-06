using System;
using DAL_SQL;

namespace Mapper
{
    public class MUsers
    {
        public bool Insert(BE_Propiedades.BE_Users user)
        {
            var bdc = new BDConnection();
            string query = "EXEC [InsertUser] @UserN = N'" + user.UserName + "', @Pass = N'"+user.PassWord+"'";
            return bdc.Insert(query);
        }
    }
}
