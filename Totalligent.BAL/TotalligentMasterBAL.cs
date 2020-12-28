using Totalligent.DAL;
using Totalligent.BusinessEntities;
using System.Security.Cryptography;
using Totalligent.Utilities;

using System;
using System.Transactions;
using System.Collections.Generic;
using System.Text;

namespace Totalligent.BAL
{
    public class TotalligentMasterBAL
    {
        TotalligentMasterDAL objMasterDAL = new TotalligentMasterDAL();
        MailingServices objMail = new MailingServices();
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
            long returnCode = -1;

            using (TransactionScope transactionScope = new TransactionScope())
            {

                try
                {
                    byte[] b = ASCIIEncoding.ASCII.GetBytes(objClientCom.EmailId);
                    string encryptedPswd = Convert.ToBase64String(b);
                    objClientCom.Password = encryptedPswd;
                    returnCode = objMasterDAL.SaveClientCompany(objClientCom, out string UserName, out string Password);


                    returnCode = objMail.SendMailToAdmin(UserName, Password, objClientCom.EmailId);
                    transactionScope.Complete();
                    transactionScope.Dispose();

                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    throw ex;
                }
            }
            return returnCode;
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
        public long BulkUpload(string Extension, string filePath, string UserName)
        {
            long returnCode = -1;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    returnCode = objMasterDAL.BulkUpload(Extension, filePath, UserName);
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
        public long BulkUploadMotor(string Extension, string filePath, int reqFrom, out int rowsCnt, out string fileMismatchErr, string UserName)
        {
            long returnCode = -1;
            rowsCnt = 0;
            List<ProducerMaster> lstPMBulkUpload = new List<ProducerMaster>();
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {

                    returnCode = objMasterDAL.BulkUploadMotor(Extension, filePath, reqFrom, out rowsCnt, out fileMismatchErr, UserName, out lstPMBulkUpload);
                    if (returnCode > 0 && lstPMBulkUpload.Count > 0)
                    {
                        foreach (var item in lstPMBulkUpload)
                        {
                            byte[] b = ASCIIEncoding.ASCII.GetBytes(item.UserName);
                            string encryptedPswd = Convert.ToBase64String(b);
                            returnCode = objMail.SendMailToAdmin(item.UserName, encryptedPswd, item.EmailId);
                        }
                    }
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
