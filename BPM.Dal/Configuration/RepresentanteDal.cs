using BPM.Dto.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM.Dal.Configuration
{
    public class RepresentanteDal
    {

        public int SaveRepresentante(RepresentanteDto RepresentanteTra)
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var Created = db.Sp_InsertarRepresentante
                        (RepresentanteTra.Tipo,
                      RepresentanteTra.NumeroDocumento,
                      RepresentanteTra.NombreCompleto,
                      RepresentanteTra.Direccion,
                      RepresentanteTra.Ciudad,
                      RepresentanteTra.Departamento,
                      RepresentanteTra.Pais,
                      RepresentanteTra.Telefono,
                      RepresentanteTra.IdEmpresa).First();
                    return Convert.ToInt32(Created);
                }
            }
            catch (Exception e)
            {

                return 0;
            }
        }

        public List<RepresentanteDto> GetRepresentanteTras()
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var RepresentanteTras = db.Sp_ListarRepresentantes().ToList().ConvertAll(Representantes => new RepresentanteDto()
                    {
                        IdRepresentante = Representantes.IdRepresentante,
                        Tipo = Representantes.Tipo,
                        NumeroDocumento = Representantes.NumeroDocumento,
                        NombreCompleto= Representantes.NombreCompleto,
                        Direccion= Representantes.Direccion,
                        Ciudad= Representantes.Ciudad,
                        Departamento= Representantes.Departamento,
                        Pais= Representantes.Pais,
                        Telefono= Representantes.Telefono,
                        NameEmpresa = Representantes.NameEmpresa,
                        NameState = Representantes.NameState,
                        
                    });

                    return RepresentanteTras;
                }
            }
            catch (Exception e)
            {
                return new List<RepresentanteDto>(); ;
            }
        }

        public int AddRepresentanteTra(RepresentanteDto RepresentanteTra)
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var Created = db.Sp_InsertarRepresentante(
                      RepresentanteTra.Tipo,
                      RepresentanteTra.NumeroDocumento,
                      RepresentanteTra.NombreCompleto,
                      RepresentanteTra.Direccion,
                      RepresentanteTra.Ciudad,
                      RepresentanteTra.Departamento,
                      RepresentanteTra.Pais,
                      RepresentanteTra.Telefono,
                      RepresentanteTra.IdEmpresa

                      ).First();
                    return Convert.ToInt32(Created);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to open {0}.", e);
                throw;

                return 2;
            }

        }

        public RepresentanteDto GetRepresentanteTra(int IdRepresentante)
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var RepresentanteTra = db.RepresentanteLegal.Where(x => x.IdRepresentante == IdRepresentante).FirstOrDefault();
                    var RepresentanteDto = new RepresentanteDto
                    {

                        IdRepresentante = RepresentanteTra.IdRepresentante,
                        Tipo = RepresentanteTra.Tipo,
                        NumeroDocumento = RepresentanteTra.NumeroDocumento,
                        NombreCompleto = RepresentanteTra.NombreCompleto,
                        Direccion = RepresentanteTra.Direccion,
                        Ciudad = RepresentanteTra.Ciudad,
                        Departamento = RepresentanteTra.Departamento,
                        Pais = RepresentanteTra.Pais,
                        Telefono = RepresentanteTra.Telefono,
                        IdEmpresa = Convert.ToInt32(RepresentanteTra.IdEmpresa)

                    };
                    return RepresentanteDto;
                }
            }
            catch (Exception e)
            {
                RepresentanteDto RepresentanteDto = new RepresentanteDto
                {
                    IdRepresentante = 0,
                };
                return RepresentanteDto;
            }

        }
        public int EditRepresentanteTra(RepresentanteDto Representantes)
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var Created = db.Sp_EditarRepresentante(Representantes.IdRepresentante, Representantes.Tipo,
                      Representantes.NumeroDocumento,
                      Representantes.NombreCompleto,
                      Representantes.Direccion,
                      Representantes.Ciudad,
                      Representantes.Departamento,
                      Representantes.Pais,
                      Representantes.Telefono,
                      Representantes.IdEmpresa).First();
                    return Convert.ToInt32(Created);
                }
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public int RemoveRepresentanteTra(int Id)
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var Remove = db.Sp_EliminarRepresentante(Id).First();
                    return Convert.ToInt32(Remove);
                }
            }
            catch (Exception e)
            {
                return 0;
            }

        }

    }
}
