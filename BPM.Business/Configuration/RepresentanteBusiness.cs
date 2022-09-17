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
    public class RepresentanteBusiness
    {

        public List<RepresentanteDto> GetRepresentanteTras()
        {
            var Dal = new RepresentanteDal();
            return Dal.GetRepresentanteTras();
        }

        public int AddRepresentanteTra(RepresentanteDto RepresentanteTra)
        {
            var Dal = new RepresentanteDal();
            return Dal.AddRepresentanteTra(RepresentanteTra);

        }

        public RepresentanteDto GetRepresentanteTra(int IdRepresentante)
        {
            var Dal = new RepresentanteDal();
            return Dal.GetRepresentanteTra(IdRepresentante);
        }

        public int EditRepresentanteTra(RepresentanteDto Representantes)
        {
            var Dal = new RepresentanteDal();
            return Dal.EditRepresentanteTra(Representantes);

        }

        public int RemoveRepresentanteTra(int Id)
        {
            var Dal = new RepresentanteDal();
            return Dal.RemoveRepresentanteTra(Id);
        }

        public int SaveRepresentante(RepresentanteDto RepresentanteTra)
        {
            var Dal = new RepresentanteDal();
            return Dal.SaveRepresentante(RepresentanteTra);
        }

    }
}
