//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPM.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            this.Conductor_Vehiculo = new HashSet<Conductor_Vehiculo>();
        }
    
        public int IdVehiculo { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
    
        public virtual ICollection<Conductor_Vehiculo> Conductor_Vehiculo { get; set; }
    }
}
