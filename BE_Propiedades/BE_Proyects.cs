using System;
using System.Collections.Generic;
using System.Text;

namespace BE_Propiedades
{
    public class BE_Proyects
    {
        public string Name { get; set; }
        public BE_Client Client{get;set;} 
        public bool Is_Active { get; set;}
        public DateTime StartDate { get; set; }
    }
}
