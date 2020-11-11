using System;
using System.Collections.Generic;
using System.Text;
using BE_Propiedades;
using Mapper;

namespace BLL_Negocio
{
    public class N_Users
    {
        public bool Insert(BE_Users u)
        {
            var us = new M_Users();
            return us.Insert(u);
        }
        public bool Update(BE_Users u)
        {
            var us = new M_Users();
            return us.Update(u);
        }
        public bool Delete(BE_Users u)
        {
            var us = new M_Users();
            return us.Delete(u);
        }

        public string[] LoadUsers(BE_Users u)
        {
            var us = new M_Users();
            return us.Validate(u);
        }
    }
}
