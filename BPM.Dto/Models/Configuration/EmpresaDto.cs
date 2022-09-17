using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM.Dto.Configuration
{
    public class EmpresaDto
    {
          

        public int IdEmpresa { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Debe ingresar máximo 60 caracteres")]
        public string Tipo { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string NameState { get; set; }

    }
}
