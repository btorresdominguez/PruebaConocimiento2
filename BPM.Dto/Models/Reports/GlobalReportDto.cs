using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM.Dto.Reports
{
    public class GlobalReportDto
    {
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public int Report { get; set; }
    }
}
