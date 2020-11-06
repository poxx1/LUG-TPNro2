using System;
using System.Collections.Generic;
using System.Text;
using BE_Propiedades;
using Mapper;

namespace BLL_Negocio
{
    public class N_Users
    {
        //public List<BE_Propiedades.BEUsers> LoadUsers()
        //{
        //    var us = new MUsers();
        //    return us.LoadUsers();
        //}

        public bool Insert(BE_Users u)
        {
            var us = new MUsers();
            return us.Insert(u);
        }
        public bool Update(BE_Users u)
        {
            var us = new MUsers();
            return us.Update(u);
        }
        public bool Delete(BE_Users u)
        {
            var us = new MUsers();
            return us.Delete(u);
        }

    }
}
