using BPM.Dal;
using BPM.Dal.Configuration;
using BPM.Dal.Depuration;
using BPM.Dto.Configuration;
using BPM.Dto.Models.Configuration;
using BPM.Dto.Models.PQR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM.Business.Configuration
{
    public class MatrizEscalationBusiness
    {

        #region "VARIABLES"
        MatrizEscalationDal Dal = new MatrizEscalationDal();
        SendEmailDal DalEmail = new SendEmailDal();
        #endregion

        public int SaveMatriz(MatrizEscalation Matriz)
        {
            return Dal.SaveMatriz(Matriz);
        }

        public List<MatrizEscalation> GetMatrizes()
        {
            return Dal.GetMatrizs();
        }

        public int AddMatriz(MatrizEscalation Matriz)
        {
            return Dal.AddMatriz(Matriz);

        }

        public MatrizEscalation GetMatriz(int Id)
        {
            return Dal.GetMatriz(Id);
        }
        public int EditMatriz(MatrizEscalation Matriz)
        {
            return Dal.EditMatriz(Matriz);

        }

        public int RemoveMatriz(int Id)
        {
            return Dal.RemoveMatriz(Id);

        }

      
             

        public List<MEscalationOrgan> GetOrganization()
        {
            return Dal.GetOrganization();
        }

        public List<MEscalationCompany> GetCompany()
        {
            return Dal.GetCompany();
        }

        public List<MEscalationProcess> GetProcess()
        {
            return Dal.GetProcess();
        }

        public List<MEscalationC4C> GetC4C()
        {
            return Dal.GetC4C();
        }

        public MatrizEscalation GetEmailEscalation()
        {
            try
            {
                return DalEmail.GetEmailEscalation();
            }
            catch (Exception)
            {

                return new MatrizEscalation();
            }
        }
     
    }
}
