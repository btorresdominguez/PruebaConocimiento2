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
    
    public partial class Sp_ListarRepresentantes_Result
    {
        public int IdRepresentante { get; set; }
        public string Tipo { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<bool> Estado { get; set; }
        public string NameEmpresa { get; set; }
        public string NameState { get; set; }
    }
}
