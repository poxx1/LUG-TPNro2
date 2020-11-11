using BE_Propiedades;
using System;
using System.Collections.Generic;

namespace Mapper
{
    public class M_Proyects
    {
        public List<BE_ProyectsClient> List(object l)
        {
                var dataa = new DAL_SQL.Disconnected();
                dynamic query = "Select ProductOwner,Count(Name) as 'Cantidad' FROM Proyects Group by ProductOwner Order By ProductOwner DESC";
                return dataa.Read(query);
        }
    }
}