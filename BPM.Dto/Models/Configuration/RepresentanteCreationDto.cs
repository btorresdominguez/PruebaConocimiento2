using BPM.Dto.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM.Dto.Configuration
{
    public class RepresentanteCreationDto
    {
        public IEnumerable<RepresentanteDto> RepresentanteList { get; set; }
        public IEnumerable<EmpresaDto> EmpresaList { get; set; }
        public int SelectedEmpresa { get; set; }
    }
}
