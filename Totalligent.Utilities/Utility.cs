using System;
using System.Configuration;
using System.Data;
using Totalligent.BusinessEntities;

namespace Totalligent.Utilities
{
    public class Utility
    {
        public string GetConnectionString()
        {
            string conStr = ConfigurationManager.ConnectionStrings["Totalligent"].ConnectionString.ToString();
            return conStr;
        }
        public DataTable ConvertToClient(Register _objRegisterClient)
        {
            try
            {
                DataTable _dt = new DataTable();
                _dt.Columns.Add("ClientName", typeof(string));
                _dt.Columns.Add("PolicyNumber", typeof(string));
                _dt.Columns.Add("CompanyAddress", typeof(string));
                _dt.Columns.Add("City", typeof(string));
                _dt.Columns.Add("StateName", typeof(string));
                _dt.Columns.Add("ZipCode", typeof(long));
                _dt.Columns.Add("ContactPerson", typeof(string));
                _dt.Columns.Add("MobileNumber", typeof(string));
                _dt.Columns.Add("EmailId", typeof(string));
                _dt.Columns.Add("Currency", typeof(string));
                _dt.Columns.Add("Broker", typeof(string));
                _dt.Columns.Add("Reinsurer", typeof(string));

                DataRow _dr;

                _dr = _dt.NewRow();
                _dr["ClientName"] = _objRegisterClient.ClientName;
                _dr["PolicyNumber"] = _objRegisterClient.PolicyNumber;
                _dr["CompanyAddress"] = _objRegisterClient.Address;
                _dr["City"] = _objRegisterClient.City;
                _dr["StateName"] = _objRegisterClient.StateName;
                _dr["ZipCode"] = _objRegisterClient.ZipCode;
                _dr["ContactPerson"] = _objRegisterClient.ContactPerson;
                _dr["MobileNumber"] = _objRegisterClient.MobileNumber;
                _dr["EmailId"] = _objRegisterClient.EmailId;
                _dr["Currency"] = _objRegisterClient.Currency;
                _dr["Broker"] = _objRegisterClient.Broker;
                _dr["Reinsurer"] = _objRegisterClient.Reinsurer;
                _dt.Rows.Add(_dr);

                return _dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ConvertToInsCompany(InsuranceCompany _objRegisterClient)
        {
            try
            {
                DataTable _dt = new DataTable();
                _dt.Columns.Add("CompanyName", typeof(string));
                _dt.Columns.Add("PolicyNumber", typeof(string));
                _dt.Columns.Add("CompanyAddress", typeof(string));
                _dt.Columns.Add("City", typeof(string));
                _dt.Columns.Add("StateName", typeof(string));
                _dt.Columns.Add("ZipCode", typeof(long));
                _dt.Columns.Add("ContactPerson", typeof(string));
                _dt.Columns.Add("MobileNumber", typeof(string));
                _dt.Columns.Add("EmailId", typeof(string));
                _dt.Columns.Add("Currency", typeof(string));
                _dt.Columns.Add("Broker", typeof(string));
                _dt.Columns.Add("Reinsurer", typeof(string));

                DataRow _dr;

                _dr = _dt.NewRow();
                _dr["CompanyName"] = _objRegisterClient.ClientName;
                _dr["PolicyNumber"] = _objRegisterClient.PolicyNumber;
                _dr["CompanyAddress"] = _objRegisterClient.Address;
                _dr["City"] = _objRegisterClient.City;
                _dr["StateName"] = _objRegisterClient.StateName;
                _dr["ZipCode"] = _objRegisterClient.ZipCode;
                _dr["ContactPerson"] = _objRegisterClient.ContactPerson;
                _dr["MobileNumber"] = _objRegisterClient.MobileNumber;
                _dr["EmailId"] = _objRegisterClient.EmailId;
                _dr["Currency"] = _objRegisterClient.Currency;
                _dr["Broker"] = _objRegisterClient.Broker;
                _dr["Reinsurer"] = _objRegisterClient.Reinsurer;
                _dt.Rows.Add(_dr);

                return _dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
