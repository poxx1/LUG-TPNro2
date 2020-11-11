using System;

namespace BE_Propiedades
{
    public class BE_ProyectsClient
    {
        public string Name { get; set; }
        public BE_Client Client{get;set;} 
        public bool Is_Active { get; set;}
        public DateTime StartDate { get; set; }
        public int WBS { get; set; }
    }
}
