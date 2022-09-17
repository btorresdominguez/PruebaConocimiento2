﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class TransporteEntities : DbContext
    {
        public TransporteEntities()
            : base("name=TransporteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Conductor> Conductor { get; set; }
        public DbSet<Conductor_Vehiculo> Conductor_Vehiculo { get; set; }
        public DbSet<RepresentanteLegal> RepresentanteLegal { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
    
        public virtual ObjectResult<Nullable<int>> Sp_EditarEmpresa(Nullable<int> id, string tipo, string numeroDocumento, string nombreCompleto, string direccion, string ciudad, string departamento, string pais, string telefono)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(string));
    
            var numeroDocumentoParameter = numeroDocumento != null ?
                new ObjectParameter("NumeroDocumento", numeroDocumento) :
                new ObjectParameter("NumeroDocumento", typeof(string));
    
            var nombreCompletoParameter = nombreCompleto != null ?
                new ObjectParameter("NombreCompleto", nombreCompleto) :
                new ObjectParameter("NombreCompleto", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var ciudadParameter = ciudad != null ?
                new ObjectParameter("Ciudad", ciudad) :
                new ObjectParameter("Ciudad", typeof(string));
    
            var departamentoParameter = departamento != null ?
                new ObjectParameter("Departamento", departamento) :
                new ObjectParameter("Departamento", typeof(string));
    
            var paisParameter = pais != null ?
                new ObjectParameter("Pais", pais) :
                new ObjectParameter("Pais", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Sp_EditarEmpresa", idParameter, tipoParameter, numeroDocumentoParameter, nombreCompletoParameter, direccionParameter, ciudadParameter, departamentoParameter, paisParameter, telefonoParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Sp_EliminarEmpresa(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Sp_EliminarEmpresa", idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Sp_InsertarEmpresa(string tipo, string numeroDocumento, string nombreCompleto, string direccion, string ciudad, string departamento, string pais, string telefono)
        {
            var tipoParameter = tipo != null ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(string));
    
            var numeroDocumentoParameter = numeroDocumento != null ?
                new ObjectParameter("NumeroDocumento", numeroDocumento) :
                new ObjectParameter("NumeroDocumento", typeof(string));
    
            var nombreCompletoParameter = nombreCompleto != null ?
                new ObjectParameter("NombreCompleto", nombreCompleto) :
                new ObjectParameter("NombreCompleto", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var ciudadParameter = ciudad != null ?
                new ObjectParameter("Ciudad", ciudad) :
                new ObjectParameter("Ciudad", typeof(string));
    
            var departamentoParameter = departamento != null ?
                new ObjectParameter("Departamento", departamento) :
                new ObjectParameter("Departamento", typeof(string));
    
            var paisParameter = pais != null ?
                new ObjectParameter("Pais", pais) :
                new ObjectParameter("Pais", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Sp_InsertarEmpresa", tipoParameter, numeroDocumentoParameter, nombreCompletoParameter, direccionParameter, ciudadParameter, departamentoParameter, paisParameter, telefonoParameter);
        }
    
        public virtual ObjectResult<Sp_ListarEmpresas_Result> Sp_ListarEmpresas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_ListarEmpresas_Result>("Sp_ListarEmpresas");
        }
    
        public virtual ObjectResult<Nullable<int>> Sp_EditarRepresentante(Nullable<int> id, string tipo, string numeroDocumento, string nombreCompleto, string direccion, string ciudad, string departamento, string pais, string telefono, Nullable<int> idEmpresa)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(string));
    
            var numeroDocumentoParameter = numeroDocumento != null ?
                new ObjectParameter("NumeroDocumento", numeroDocumento) :
                new ObjectParameter("NumeroDocumento", typeof(string));
    
            var nombreCompletoParameter = nombreCompleto != null ?
                new ObjectParameter("NombreCompleto", nombreCompleto) :
                new ObjectParameter("NombreCompleto", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var ciudadParameter = ciudad != null ?
                new ObjectParameter("Ciudad", ciudad) :
                new ObjectParameter("Ciudad", typeof(string));
    
            var departamentoParameter = departamento != null ?
                new ObjectParameter("Departamento", departamento) :
                new ObjectParameter("Departamento", typeof(string));
    
            var paisParameter = pais != null ?
                new ObjectParameter("Pais", pais) :
                new ObjectParameter("Pais", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Sp_EditarRepresentante", idParameter, tipoParameter, numeroDocumentoParameter, nombreCompletoParameter, direccionParameter, ciudadParameter, departamentoParameter, paisParameter, telefonoParameter, idEmpresaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Sp_EliminarRepresentante(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Sp_EliminarRepresentante", idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Sp_InsertarRepresentante(string tipo, string numeroDocumento, string nombreCompleto, string direccion, string ciudad, string departamento, string pais, string telefono, Nullable<int> idEmpresa)
        {
            var tipoParameter = tipo != null ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(string));
    
            var numeroDocumentoParameter = numeroDocumento != null ?
                new ObjectParameter("NumeroDocumento", numeroDocumento) :
                new ObjectParameter("NumeroDocumento", typeof(string));
    
            var nombreCompletoParameter = nombreCompleto != null ?
                new ObjectParameter("NombreCompleto", nombreCompleto) :
                new ObjectParameter("NombreCompleto", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var ciudadParameter = ciudad != null ?
                new ObjectParameter("Ciudad", ciudad) :
                new ObjectParameter("Ciudad", typeof(string));
    
            var departamentoParameter = departamento != null ?
                new ObjectParameter("Departamento", departamento) :
                new ObjectParameter("Departamento", typeof(string));
    
            var paisParameter = pais != null ?
                new ObjectParameter("Pais", pais) :
                new ObjectParameter("Pais", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Sp_InsertarRepresentante", tipoParameter, numeroDocumentoParameter, nombreCompletoParameter, direccionParameter, ciudadParameter, departamentoParameter, paisParameter, telefonoParameter, idEmpresaParameter);
        }
    
        public virtual ObjectResult<Sp_ListarRepresentantes_Result> Sp_ListarRepresentantes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_ListarRepresentantes_Result>("Sp_ListarRepresentantes");
        }
    }
}