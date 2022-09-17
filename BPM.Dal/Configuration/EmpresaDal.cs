using BPM.Dto.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM.Dal.Configuration
{
    public class EmpresaDal
    {

        public int SaveEmpresaTra(EmpresaDto EmpresaTra)
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var Created = db.Sp_InsertarEmpresa(EmpresaTra.Tipo,
                      EmpresaTra.NumeroDocumento,
                      EmpresaTra.NombreCompleto,
                      EmpresaTra.Direccion,
                      EmpresaTra.Ciudad,
                      EmpresaTra.Departamento,
                      EmpresaTra.Pais,
                      EmpresaTra.Telefono).First();
                    return Convert.ToInt32(Created);
                }
            }
            catch (Exception e)
            {

                return 0;
            }
        }

        public List<EmpresaDto> GetEmpresaTras()
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var EmpresaTras = db.Sp_ListarEmpresas().ToList().ConvertAll(EmpresaTra => new EmpresaDto()
                    {
                        IdEmpresa = EmpresaTra.IdEmpresa,
                        Tipo = EmpresaTra.Tipo,
                        NumeroDocumento = EmpresaTra.NumeroDocumento,
                        NombreCompleto=EmpresaTra.NombreCompleto,
                        Direccion= EmpresaTra.Direccion,
                        Ciudad=EmpresaTra.Ciudad,
                        Departamento=EmpresaTra.Departamento,
                        Pais= EmpresaTra.Pais,
                        Telefono= EmpresaTra.Telefono,
                        NameState = EmpresaTra.NameState
                    });

                    return EmpresaTras;
                }
            }
            catch (Exception e)
            {
                return new List<EmpresaDto>(); ;
            }
        }

        public int AddEmpresaTra(EmpresaDto EmpresaTra)
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var Created = db.Sp_InsertarEmpresa(EmpresaTra.Tipo,
                      EmpresaTra.NumeroDocumento,
                      EmpresaTra.NombreCompleto,
                      EmpresaTra.Direccion,
                      EmpresaTra.Ciudad,
                      EmpresaTra.Departamento,
                      EmpresaTra.Pais,
                      EmpresaTra.Telefono
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

        public EmpresaDto GetEmpresaTra(int Id)
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var EmpresaTra = db.Empresa.Where(x => x.IdEmpresa == Id).FirstOrDefault();
                    var EmpresaDto = new EmpresaDto
                    {

                        IdEmpresa = EmpresaTra.IdEmpresa,
                        Tipo = EmpresaTra.Tipo,
                        NumeroDocumento = EmpresaTra.NumeroDocumento,
                        NombreCompleto = EmpresaTra.NombreCompleto,
                        Direccion = EmpresaTra.Direccion,
                        Ciudad = EmpresaTra.Ciudad,
                        Departamento = EmpresaTra.Departamento,
                        Pais = EmpresaTra.Pais,
                        Telefono = EmpresaTra.Telefono

                    };
                    return EmpresaDto;
                }
            }
            catch (Exception e)
            {
                EmpresaDto EmpresaDto = new EmpresaDto
                {
                    IdEmpresa = 0,
                };
                return EmpresaDto;
            }

        }
        public int EditEmpresaTra(EmpresaDto EmpresaTra)
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var Created = db.Sp_EditarEmpresa(EmpresaTra.IdEmpresa, EmpresaTra.Tipo,
                      EmpresaTra.NumeroDocumento,
                      EmpresaTra.NombreCompleto,
                      EmpresaTra.Direccion,
                      EmpresaTra.Ciudad,
                      EmpresaTra.Departamento,
                      EmpresaTra.Pais,
                      EmpresaTra.Telefono).First();
                    return Convert.ToInt32(Created);
                }
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public int RemoveEmpresaTra(int Id)
        {
            try
            {
                using (TransporteEntities db = new TransporteEntities())
                {
                    var Remove = db.Sp_EliminarEmpresa(Id).First();
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
