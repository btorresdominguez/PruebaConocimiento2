using BPM.Dal;
using BPM.Dal.Configuration;
using BPM.Dto.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM.Business.Configuration
{
    public class EmpresaBusiness
    {

        public List<EmpresaDto> GetEmpresaTras()
        {
            var Dal = new EmpresaDal();
            return Dal.GetEmpresaTras();
        }

        public int AddEmpresaTra(EmpresaDto EmpresaTra)
        {
            var Dal = new EmpresaDal();
            return Dal.AddEmpresaTra(EmpresaTra);

        }

        public EmpresaDto GetEmpresaTra(int IdEmpresa)
        {
            var Dal = new EmpresaDal();
            return Dal.GetEmpresaTra(IdEmpresa);
        }

        public int EditEmpresaTra(EmpresaDto EmpresaTra)
        {
            var Dal = new EmpresaDal();
            return Dal.EditEmpresaTra(EmpresaTra);

        }

        public int RemoveEmpresaTra(int Id)
        {
            var Dal = new EmpresaDal();
            return Dal.RemoveEmpresaTra(Id);
        }

        public int SaveEmpresaTra(EmpresaDto EmpresaTra)
        {
            var Dal = new EmpresaDal();
            return Dal.SaveEmpresaTra(EmpresaTra);
        }

    }
}
