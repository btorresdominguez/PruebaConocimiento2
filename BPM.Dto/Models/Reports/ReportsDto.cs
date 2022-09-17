using System.ComponentModel.DataAnnotations.Schema;

namespace BPM.Dto.Models.Reports
{
    public class ReporteDto
    {

        [Column("CLIENTE")]
        public string Cliente { get; set; }

        [Column("ORIGEN")]
        public string CuentaOrigen { get; set; }

        [Column("TIPO_OPERACION")]
        public string Tipo { get; set; }

        [Column("SALDO")]
        public int Saldo { get; set; }

        [Column("VALOR_RETIRO")]
        public int Valor_Retiro { get; set; }
     
        [Column("VALOR_GMF")]
        public int GMF { get; set; }

        [Column("BANCO")]
        public string Banco { get; set; }

        [Column("CUENTA_DESTINO")]
        public string Cuenta { get; set; }

   

       
    }
}
