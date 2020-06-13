using Totalligent.DAL;
using Totalligent.BusinessEntities;
using System.Security.Cryptography;
using Totalligent.Utilities;

using System;
using System.Transactions;

namespace Totalligent.BAL
{
    public class TotalligentMasterBAL
    {
        TotalligentMasterDAL objMasterDAL = new TotalligentMasterDAL();
        public long SaveAgent(AgentMaster objAgentMaster)
        {
            try
            {
                long returnCode = objMasterDAL.SaveAgent(objAgentMaster);

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long SaveBroker(BrokerMaster objBroker)
        {
            try
            {
                long returnCode = objMasterDAL.SaveBroker(objBroker);

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long SaveClientCom(ClientCompanyMaster objClientCom)
        {
            try
            {
                long returnCode = objMasterDAL.SaveClientCompany(objClientCom);

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertDiagnostics(DiagnosticsMaster objDiag)
        {
            try
            {
                long returnCode = objMasterDAL.SaveDiagnostics(objDiag);

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long SaveDrug(DrugMaster objDrug)
        {
            try
            {
                long returnCode = objMasterDAL.SaveDrugs(objDrug);

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long SaveHosMaster(HospitalMaster objHos)
        {
            try
            {
                long returnCode = objMasterDAL.SaveHospitalMaster(objHos);

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long SaveInsCom(InsuranceCompanyMaster objInsCom)
        {
            try
            {
                long returnCode = objMasterDAL.SaveInsCompanyMaster(objInsCom);

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long SaveLab(LabMaster objLab)
        {
            try
            {
                long returnCode = objMasterDAL.SaveLabMaster(objLab);

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long BulkUpload(string Extension, string filePath)
        {
            long returnCode = -1;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    returnCode = objMasterDAL.BulkUpload(Extension, filePath);
                    transactionScope.Complete();
                    transactionScope.Dispose();

                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    throw ex;
                }

                return returnCode;
            }
        }
    }
}
