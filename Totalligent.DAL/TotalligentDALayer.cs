using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totalligent.Utilities;
using Totalligent.BusinessEntities;


namespace Totalligent.DAL
{
    public class TotalligentDALayer
    {
        readonly Utility objUtility = new Utility();

        public List<UserType> GetUserTypeMaster()
        {
            List<UserType> lstUserType = new List<UserType>();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_GetUserType"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    sdaAdapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        lstUserType = (from DataRow dr in dt.Rows
                                       select new UserType()
                                       {
                                           UserTypeId = Convert.ToInt32(dr["UserTypeId"]),
                                           Designation = dr["Designation"].ToString()
                                       }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstUserType;
        }
        public List<Role> GetRoles()
        {
            List<Role> lstRoles = new List<Role>();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_GetRoles"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    sdaAdapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        lstRoles = (from DataRow dr in dt.Rows
                                    select new Role()
                                    {
                                        RoleId = Convert.ToInt32(dr["RoleId"]),
                                        Description = dr["Description"].ToString()
                                    }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstRoles;
        }
        public Employee GetLoginInfo(string Username, string Password, int RoleId, out string IsFirstLogin)
        {
            string Uname = string.Empty;
            IsFirstLogin = string.Empty;
            Employee objEmp = new Employee();
            SqlDataReader reader;
            try
            {

                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_GetLoginInfo"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@UserName", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@RoleId", RoleId);
                    SqlParameter param = new SqlParameter
                    {
                        ParameterName = "@IsFirstLogin",
                        Direction = ParameterDirection.Output,
                        SqlDbType = SqlDbType.Char,
                        Size = 10
                    };
                    cmd.Parameters.Add(param);

                    // Uname = cmd.ExecuteScalar().ToString();
                    //Uname = (cmd.ExecuteScalar() ?? "").ToString();

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        objEmp.EmployeeId = (int)reader.GetValue(0);
                        objEmp.UserName = reader.GetValue(1).ToString();
                        objEmp.UserEmployeeNo = reader.GetValue(2).ToString();
                        objEmp.Designation = reader.GetValue(3).ToString();
                        objEmp.ReportingManager = reader.GetValue(4).ToString();
                        objEmp.EmailId = reader.GetValue(5).ToString();
                        objEmp.MobileNumber = reader.GetValue(6).ToString();
                        objEmp.RoleId = (int)reader.GetValue(7);
                    }
                    reader.Close();
                    cmd.Dispose();

                    IsFirstLogin = Convert.ToString(cmd.Parameters["@IsFirstLogin"].Value);
                    if (string.IsNullOrEmpty(IsFirstLogin))
                    {
                        IsFirstLogin = "N";
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objEmp;
        }
        public long RegisterUser(Register objRegister)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_CompanyRegistration"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@CompanyName", objRegister.CompanyName);
                    cmd.Parameters.AddWithValue("@Address", objRegister.Address);
                    cmd.Parameters.AddWithValue("@City", objRegister.City);
                    cmd.Parameters.AddWithValue("@StateName", objRegister.StateName);
                    cmd.Parameters.AddWithValue("@ContactPerson", objRegister.ContactPerson);
                    cmd.Parameters.AddWithValue("@MobileNumber", objRegister.MobileNumber);
                    cmd.Parameters.AddWithValue("@EmailId", objRegister.EmailId);
                    cmd.Parameters.AddWithValue("@Currency", objRegister.Currency);
                    cmd.Parameters.AddWithValue("@CreatedBy", "Developer");
                    long returnCode = cmd.ExecuteNonQuery();
                    return returnCode;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateNewPassword(string Username, string OldPswd, string NewPswd)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_UpdatePassword"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@UserName", Username);
                    cmd.Parameters.AddWithValue("@OldPassword", OldPswd);
                    cmd.Parameters.AddWithValue("@NewPassword", NewPswd);

                    long returnCode = cmd.ExecuteNonQuery();
                    return returnCode;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long SaveLogin(string UserName, string Password, int RoleId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_SaveLogin"
                    };
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@RoleId", RoleId);

                    long returnCode = cmd.ExecuteNonQuery();
                    return returnCode;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long RegisterEmployee(Employee objRegisterEmployee, out string UserName, out string EmailId)
        {
            long returnCode = -1;
            SqlDataReader reader;
            UserName = string.Empty;
            EmailId = string.Empty;
            try
            {
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_EmployeeRegistration"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@UserName", objRegisterEmployee.UserName);
                    cmd.Parameters.AddWithValue("@UserEmployeeNo", objRegisterEmployee.UserEmployeeNo);
                    cmd.Parameters.AddWithValue("@UserTypeId", objRegisterEmployee.UserTypeId);
                    cmd.Parameters.AddWithValue("@ReportingManager", objRegisterEmployee.ReportingManager);
                    cmd.Parameters.AddWithValue("@EmailId", objRegisterEmployee.EmailId);
                    cmd.Parameters.AddWithValue("@MobileNumber", objRegisterEmployee.MobileNumber);
                    cmd.Parameters.AddWithValue("@CreatedBy", "Admin");
                    cmd.Parameters.AddWithValue("@RoleId", objRegisterEmployee.RoleId);
                    //long returnCode = cmd.ExecuteNonQuery();

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UserName = reader.GetValue(0).ToString();
                        EmailId = reader.GetValue(1).ToString();
                    }
                    reader.Close();
                    cmd.Dispose();
                    if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(EmailId))
                        returnCode = 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        public string InsertClient(Register objRegisterClient)
        {
            string PolicyNumber = string.Empty;
            try
            {
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    DataTable dt = objUtility.ConvertToClient(objRegisterClient);
                    if (dt.Rows.Count > 0)
                    {
                        SqlCommand cmd;
                        cmd = new SqlCommand
                        {
                            CommandText = "SP_RegisterClient",
                            CommandTimeout = 180,
                            Connection = con,
                            CommandType = CommandType.StoredProcedure
                        };
                        SqlParameter UDTparam = new SqlParameter
                        {
                            ParameterName = "@UDT_ClientRegistration",
                            Size = -1,
                            Value = dt
                        };
                        cmd.Parameters.Add(UDTparam);
                        PolicyNumber = cmd.ExecuteScalar().ToString() ?? "";
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return PolicyNumber;
        }
        public List<Register> GetClients(string PolicyNumber)
        {
            List<Register> lstClients = new List<Register>();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_Clients"
                    };
                    cmd.Parameters.AddWithValue("@PolicyNumber", PolicyNumber);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    sdaAdapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        lstClients = (from DataRow dr in dt.Rows
                                      select new Register()
                                      {
                                          ClientId = Convert.ToInt32(dr["ClientId"]),
                                          PolicyNumber = dr["PolicyNumber"].ToString(),
                                          ClientName = dr["ClientName"].ToString(),
                                          Address = dr["CompanyAddress"].ToString(),
                                          City = dr["City"].ToString(),
                                          StateName = dr["StateName"].ToString(),
                                          ZipCode = (long)dr["ZipCode"],
                                          ContactPerson = dr["ContactPerson"].ToString(),
                                          MobileNumber = dr["MobileNumber"].ToString(),
                                          EmailId = dr["EmailId"].ToString(),
                                          Currency = dr["Currency"].ToString(),
                                          Broker = dr["Broker"].ToString(),
                                          Reinsurer = dr["Reinsurer"].ToString(),
                                      }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstClients;
        }
        public long TPAInsComRegister(InsuranceCompany objInsCompanyRegister, out string PolicyNumber)
        {
            long returnCode = -1;
            PolicyNumber = string.Empty;
            try
            {
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    DataTable dt = objUtility.ConvertToInsCompany(objInsCompanyRegister);
                    if (dt.Rows.Count > 0)
                    {
                        SqlCommand cmd;
                        cmd = new SqlCommand
                        {
                            CommandText = "SP_RegisterInsCompany",
                            CommandTimeout = 180,
                            Connection = con,
                            CommandType = CommandType.StoredProcedure
                        };
                        SqlParameter UDTparam = new SqlParameter
                        {
                            ParameterName = "@UDT_InsCompanyRegistration",
                            Size = -1,
                            Value = dt
                        };
                        cmd.Parameters.Add(UDTparam);
                        if (!string.IsNullOrEmpty(cmd.ExecuteScalar().ToString()))
                            PolicyNumber = cmd.ExecuteScalar().ToString() ?? "";
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        public List<InsuranceCompany> GetCompanies(string CompanyDraftNo)
        {
            List<InsuranceCompany> lstCompanies = new List<InsuranceCompany>();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_GetCompanies"
                    };
                    cmd.Parameters.AddWithValue("@CompanyDraftNo", CompanyDraftNo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    sdaAdapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        lstCompanies = (from DataRow dr in dt.Rows
                                        select new InsuranceCompany()
                                        {
                                            ClientId = Convert.ToInt32(dr["InsCompanyId"]),
                                            PolicyNumber = dr["PolicyNumber"].ToString(),
                                            CompanyName = dr["CompanyName"].ToString(),
                                            Address = dr["CompanyAddress"].ToString(),
                                            City = dr["City"].ToString(),
                                            StateName = dr["StateName"].ToString(),
                                            ZipCode = (long)dr["ZipCode"],
                                            ContactPerson = dr["ContactPerson"].ToString(),
                                            MobileNumber = dr["MobileNumber"].ToString(),
                                            EmailId = dr["EmailId"].ToString(),
                                            Currency = dr["Currency"].ToString(),
                                            Broker = dr["Broker"].ToString(),
                                            Reinsurer = dr["Reinsurer"].ToString(),
                                        }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstCompanies;
        }
        public long SaveRaiseTicket(RaiseTickets objRaiseTickets)
        {
            long returnCode = -1;

            try
            {
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_RaiseTicket"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@TicketId", objRaiseTickets.TicketId);
                    cmd.Parameters.AddWithValue("@RaisedBy", objRaiseTickets.RaisedBy);
                    cmd.Parameters.AddWithValue("@Description", objRaiseTickets.Description);
                    cmd.Parameters.AddWithValue("@CreatedAt", objRaiseTickets.CreatedAt);
                    cmd.Parameters.AddWithValue("@CreatedBy", objRaiseTickets.CreatedBy);

                    returnCode = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        public int IsUserExists(string UserName, out List<Employee> lstUsers)
        {
            int i = 0;
            DataTable dt = new DataTable();
            lstUsers = new List<Employee>();
            //List<Employee> lstUsers = new List<Employee>();
            try
            {
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_ResetPassword"
                    };
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    sdaAdapter.Fill(dt);
                    i = dt.Rows.Count;
                    if (dt.Rows.Count > 0)
                    {
                        lstUsers = (from DataRow dr in dt.Rows
                                    select new Employee()
                                    {
                                        UserName = dr["UserName"].ToString(),
                                        MobileNumber = dr["MobileNumber"].ToString(),
                                        EmailId = dr["EmailId"].ToString(),
                                        TicketId = (int)dr["TicketId"],

                                    }).ToList();

                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return i;
        }
        public List<RaiseTickets> GetTickets()
        {
            List<RaiseTickets> lstViewTickets = new List<RaiseTickets>();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_ViewTickets"
                    };
                    // cmd.Parameters.AddWithValue("@CompanyDraftNo", CompanyDraftNo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    sdaAdapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        lstViewTickets = (from DataRow dr in dt.Rows
                                          select new RaiseTickets()
                                          {
                                              TicketId = Convert.ToInt32(dr["TicketId"]),
                                              RaisedBy = dr["RaisedBy"].ToString(),
                                              Description = dr["Description"].ToString(),
                                              CreatedAt = Convert.ToDateTime(dr["CreatedAt"].ToString()),
                                              Status = dr["Status"].ToString(),
                                              EmailId = dr["EmailId"].ToString()

                                          }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstViewTickets;
        }
        public long CloseRaisedTicket(RaiseTickets objRaiseTickets, out List<Employee> lstMailNewPwsd)
        {
            long returnCode = -1;
            lstMailNewPwsd = new List<Employee>();

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_CloseTicket"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@TicketId", objRaiseTickets.TicketId);
                    cmd.Parameters.AddWithValue("@RaisedBy", objRaiseTickets.RaisedBy);
                    cmd.Parameters.AddWithValue("@Newpassword", objRaiseTickets.Newpassword);

                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    sdaAdapter.Fill(dt);
                    returnCode = dt.Rows.Count;
                    if (dt.Rows.Count > 0)
                    {
                        lstMailNewPwsd = (from DataRow dr in dt.Rows
                                          select new Employee()
                                          {
                                              UserName = dr["UserName"].ToString(),
                                              Newpassword = dr["Newpassword"].ToString(),
                                              EmailId = dr["EmailId"].ToString(),
                                              TicketId = (int)dr["TicketId"],

                                          }).ToList();

                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        public long SavePM(ProducerMaster objPM, out string UserName, out string EmailId)
        {
            long returnCode = -1;
            SqlDataReader reader;
            UserName = string.Empty;
            EmailId = string.Empty;
            try
            {
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_InsertProducerMaster"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@MasterType", objPM.MasterType);
                    cmd.Parameters.AddWithValue("@Name", objPM.Name);
                    // cmd.Parameters.AddWithValue("@UserName", objPM.UserName);
                    cmd.Parameters.AddWithValue("@Password", objPM.Password);
                    cmd.Parameters.AddWithValue("@EmailId", objPM.EmailId);
                    cmd.Parameters.AddWithValue("@AddedBy", objPM.AddedBy);
                    //  cmd.Parameters.AddWithValue("@MobileNumber", objPM.MobileNumber);
                    //  cmd.Parameters.AddWithValue("@CreatedBy", "Admin");
                    //  cmd.Parameters.AddWithValue("@RoleId", objPM.RoleId);
                    //long returnCode = cmd.ExecuteNonQuery();

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UserName = reader.GetValue(0).ToString();
                        EmailId = reader.GetValue(1).ToString();
                    }
                    reader.Close();
                    cmd.Dispose();
                    if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(EmailId))
                        returnCode = 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        public long SaveEM(EmployeeMaster objEM)
        {
            long returnCode = -1;
            DataTable dt = objUtility.ConvertToEmployeeMasterGenerator(objEM);
            try
            {
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_EmployeeMaster"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;

                    SqlParameter UDTparam = new SqlParameter
                    {
                        ParameterName = "@UDT_EmployeeMaster",
                        Size = -1,
                        Value = dt
                    };
                   // cmd.Parameters.AddWithValue("@QuotationId", QuotationId);
                    cmd.Parameters.AddWithValue("@UserName", "Admin");
                    cmd.Parameters.Add(UDTparam);

                    returnCode = cmd.ExecuteNonQuery();

                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        public long CreateQuotation(Quotation obj,long QuotationId, out string draftNo)
        {
            long returnCode = -1;
            SqlDataReader reader;
            draftNo = string.Empty;
            try
            {
                DataTable dt = objUtility.ConvertToQuotationGenerator(obj);
                if (dt.Rows.Count > 0)
                {


                    using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand
                        {
                            CommandText = "SP_CreateQuotation"
                        };

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        SqlParameter UDTparam = new SqlParameter
                        {
                            ParameterName = "@UDT_QuotationGenerator",
                            Size = -1,
                            Value = dt
                        };
                        cmd.Parameters.AddWithValue("@QuotationId", QuotationId);
                        cmd.Parameters.AddWithValue("@UserName", "Admin");
                        cmd.Parameters.Add(UDTparam);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            draftNo = reader.GetValue(0).ToString();
                            // EmailId = reader.GetValue(1).ToString();
                        }
                        reader.Close();
                        cmd.Dispose();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        public long GetUWDashBoardDetails(string UserName, out UnderWriter lstInfo)
        {
            long returnCode = -1;
            lstInfo = new UnderWriter();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_GetUWDashboard"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    //cmd.Parameters.AddWithValue("@Password", lstInput.Password);
                    //cmd.Parameters.AddWithValue("@RoleId", lstInput.Role);

                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    //DataSet ds = new DataSet();
                    sdaAdapter.Fill(ds);
                    List<Quotation> lst = new List<Quotation>();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            lstInfo.TNPYear = Convert.ToInt64(dr["TNPYear"]);
                            lstInfo.TotalNoPolQuotationDrafted = Convert.ToInt64(dr["TotalNoPolQuotationDrafted"]);
                            lstInfo.TotNoPolIssued = Convert.ToInt64(dr["TotNoPolIssued"]);
                            lstInfo.TotalNoPolRejected = Convert.ToInt64(dr["TotalNoPolRejected"]);
                        }

                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        DTtoListConverter.ConvertTo(ds.Tables[1], out lst);
                        lstInfo.lstQuotation = lst;
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[2].Rows)
                        {
                            lstInfo.TotalPremiumEarned = Convert.ToInt64(dr["TotalPremiumEarned"]);
                            lstInfo.TotalPremiumRejected = Convert.ToInt64(dr["TotalPremiumRejected"]);
                            lstInfo.TotalPremiumPending = Convert.ToInt64(dr["TotalPremiumPending"]);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        public long GetPolicyIssuance(string DraftNumber, out List<Quotation> lstQuotation)
        {
            long returnCode = -1;
            
            lstQuotation = new List<Quotation>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_GetPolicyIssuance"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@DraftNumber", DraftNumber ?? "");
                   

                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    //DataSet ds = new DataSet();
                    sdaAdapter.Fill(ds);
                    List<Quotation> lst = new List<Quotation>();
                   
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DTtoListConverter.ConvertTo(ds.Tables[0], out lstQuotation);
                       
                    }
                   
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        public long EditQuotation(string UserName,long QuotationId, out Quotation lstInfo)
        {
            long returnCode = -1;
            lstInfo = new Quotation();
            try
            {


                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_GetQuotation"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@QuotationId", QuotationId);
                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    
                    DataSet ds = new DataSet();
                    sdaAdapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            lstInfo.QuotationId = Convert.ToInt64(dr["QuotationId"]);
                            lstInfo.DraftNo = Convert.ToString(dr["DraftNo"]);
                            lstInfo.Status = Convert.ToString(dr["Status"]);
                            lstInfo.CIInsuranceCompanyName = Convert.ToString(dr["CIInsuranceCompanyName"]);
                            lstInfo.CIClientCompanyName = Convert.ToString(dr["CIClientCompanyName"]);
                            lstInfo.CIProducerType = Convert.ToString(dr["CIProducerType"]);
                            lstInfo.CIProducerName = Convert.ToString(dr["CIProducerName"]);
                            lstInfo.CISelectCommission = Convert.ToDecimal(dr["CISelectCommission"]);
                            lstInfo.CINoOfPlanCategories = Convert.ToInt32(dr["CINoOfPlanCategories"]);
                            lstInfo.GBMedicalProviderNetwork = Convert.ToString(dr["GBMedicalProviderNetwork"]);
                            lstInfo.GBScopeOfCover = Convert.ToString(dr["GBScopeOfCover"]);
                            lstInfo.GBAreaOfCoverage = ds.Tables[0].AsEnumerable().SelectMany(r => r.Field<string>(11).Split('~')).ToArray();
                            lstInfo.GBPersonCovered = ds.Tables[0].AsEnumerable().SelectMany(r => r.Field<string>(12).Split('~')).ToArray();
                            // lstInfo.GBAreaOfCoverage = Convert.ToString(dr["GBAreaOfCoverage"]);
                           // lstInfo.GBPersonCovered = Convert.ToString(dr["GBPersonCovered"]);
                            lstInfo.GBAnnualBenefitsLimit = Convert.ToDecimal(dr["GBAnnualBenefitsLimit"]);
                            lstInfo.GBIsPerClaimLimitIP = Convert.ToString(dr["GBIsPerClaimLimitIP"]);
                            lstInfo.GBPerClaimLimitIP = Convert.ToDecimal(dr["GBPerClaimLimitIP"]);
                            lstInfo.GBIsPerClaimLimitOP = Convert.ToString(dr["GBIsPerClaimLimitOP"]);
                            lstInfo.GBPerClaimLimitOP = Convert.ToDecimal(dr["GBPerClaimLimitOP"]);
                            lstInfo.GBPreExisting_ChronicLimit = Convert.ToDecimal(dr["GBPreExisting_ChronicLimit"]);
                            lstInfo.GBGeoThreateningEmergencyTreatment = ds.Tables[0].AsEnumerable().SelectMany(r => r.Field<string>(19).Split('~')).ToArray();
                            lstInfo.GBGeoElectiveTreatement = ds.Tables[0].AsEnumerable().SelectMany(r => r.Field<string>(20).Split('~')).ToArray();
                           // lstInfo.GBGeoThreateningEmergencyTreatment = Convert.ToString(dr["GBGeoThreateningEmergencyTreatment"]);
                            //lstInfo.GBGeoElectiveTreatement = Convert.ToString(dr["GBGeoElectiveTreatement"]);
                            lstInfo.GBGeoOutsideResidentCountry = Convert.ToString(dr["GBGeoOutsideResidentCountry"]);
                            lstInfo.IPHospitalizationClass = Convert.ToString(dr["IPHospitalizationClass"]);
                            lstInfo.IPHospitalizationClassLimit = Convert.ToDecimal(dr["IPHospitalizationClassLimit"]);
                            lstInfo.IPICUCoronaryTreatement = Convert.ToString(dr["IPICUCoronaryTreatement"]);
                            lstInfo.IPICUCoronaryTreatementLimit = Convert.ToDecimal(dr["IPICUCoronaryTreatementLimit"]);
                            lstInfo.IPVariousTherapies = Convert.ToString(dr["IPVariousTherapies"]);
                            lstInfo.IPVariousTherapiesLimit = Convert.ToDecimal(dr["IPVariousTherapiesLimit"]);
                            lstInfo.IPOrganTransplantationServices = Convert.ToString(dr["IPOrganTransplantationServices"]);
                            lstInfo.IPOrganTransplantationServicesLimit = Convert.ToDecimal(dr["IPOrganTransplantationServicesLimit"]);
                            lstInfo.IPAmbulanceServices = Convert.ToString(dr["IPAmbulanceServices"]);
                            lstInfo.IPAmbulanceServicesLimit = Convert.ToDecimal(dr["IPAmbulanceServicesLimit"]);
                            lstInfo.IPCompanionRoomBoardExpenses = Convert.ToString(dr["IPCompanionRoomBoardExpenses"]);
                            lstInfo.IPCompanionRoomBoardExpensesLimit = Convert.ToDecimal(dr["IPCompanionRoomBoardExpensesLimit"]);
                            lstInfo.IPHospitalCashBenefitsCashPerDay = Convert.ToDecimal(dr["IPHospitalCashBenefitsCashPerDay"]);
                            lstInfo.IPHospitalCashBenefitsCashTotal = Convert.ToDecimal(dr["IPHospitalCashBenefitsCashTotal"]);
                            lstInfo.IPRepatriationCostTraansport = Convert.ToDecimal(dr["IPRepatriationCostTraansport"]);
                            lstInfo.IPAddBenefits = Convert.ToString(dr["IPAddBenefits"]);
                            lstInfo.OPPhysicianConsultationDeductible = Convert.ToString(dr["OPPhysicianConsultationDeductible"]);
                            lstInfo.OPPhysicianConsultationDeductibleLimit = Convert.ToDecimal(dr["OPPhysicianConsultationDeductibleLimit"]);
                            lstInfo.OPDiagnostics = Convert.ToString(dr["OPDiagnostics"]);
                            lstInfo.OPDiagnosticsLimit = Convert.ToDecimal(dr["OPDiagnosticsLimit"]);
                            lstInfo.OPPharmaceuticals = Convert.ToString(dr["OPPharmaceuticals"]);
                            lstInfo.OPPharmaceuticalsLimit = Convert.ToDecimal(dr["OPPharmaceuticalsLimit"]);
                            lstInfo.OPPhysiotheraphy = Convert.ToString(dr["OPPhysiotheraphy"]);
                            lstInfo.OPPhysiotheraphyLimit = Convert.ToDecimal(dr["OPPhysiotheraphyLimit"]);
                            lstInfo.OPDaycareTreatment = Convert.ToString(dr["OPDaycareTreatment"]);
                            lstInfo.OPDaycareTreatmentLimit = Convert.ToDecimal(dr["OPDaycareTreatmentLimit"]);
                            lstInfo.OPOutPatientSurgery = Convert.ToString(dr["OPOutPatientSurgery"]);
                            lstInfo.OPOutPatientSurgeryLimit = Convert.ToDecimal(dr["OPOutPatientSurgeryLimit"]);
                            lstInfo.OPWorkRelatedInjuries = Convert.ToString(dr["OPWorkRelatedInjuries"]);
                            lstInfo.OPWorkRelatedInjuriesLimit = Convert.ToDecimal(dr["OPWorkRelatedInjuriesLimit"]);
                            lstInfo.OPAccidentalDamageNaturalTeeth = Convert.ToString(dr["OPAccidentalDamageNaturalTeeth"]);
                            lstInfo.OPAccidentalDamageNaturalTeethLimit = Convert.ToDecimal(dr["OPAccidentalDamageNaturalTeethLimit"]);
                            lstInfo.OPNewBornBabyCoverage = Convert.ToString(dr["OPNewBornBabyCoverage"]);
                            lstInfo.OPNewBornBabyCoverageLimit = Convert.ToDecimal(dr["OPNewBornBabyCoverageLimit"]);
                            lstInfo.OPNursingAtHome = Convert.ToString(dr["OPNursingAtHome"]);
                            lstInfo.OPNursingAtHomeLimit = Convert.ToDecimal(dr["OPNursingAtHomeLimit"]);
                          // GBGeoElectiveTreatement58
                                lstInfo.OPAlternativeMedicine = ds.Tables[0].AsEnumerable().SelectMany(r => r.Field<string>(58).Split('~')).ToArray();
                            
                          //  lstInfo.OPAlternativeMedicine = Convert.ToString(dr["OPAlternativeMedicine"]);
                            lstInfo.OPAlternativeMedicineCoverage = Convert.ToString(dr["OPAlternativeMedicineCoverage"]);
                            lstInfo.OPAlternativeMedicineCoverageLimit = Convert.ToDecimal(dr["OPAlternativeMedicineCoverageLimit"]);
                            lstInfo.OPAlternativeMedicineDeductible = Convert.ToString(dr["OPAlternativeMedicineDeductible"]);
                            lstInfo.OPAlternativeMedicineDeductibleLimit = Convert.ToDecimal(dr["OPAlternativeMedicineDeductibleLimit"]);
                            lstInfo.OPFreeAccessOutsideOMAN = ds.Tables[0].AsEnumerable().SelectMany(r => r.Field<string>(63).Split('~')).ToArray();
                            //lstInfo.OPFreeAccessOutsideOMAN = Convert.ToString(dr["OPFreeAccessOutsideOMAN"]);
                            lstInfo.EBFreeAccessTPANetwork = Convert.ToString(dr["EBFreeAccessTPANetwork"]);
                            lstInfo.EBFreeAccessTPANetworkLimit = Convert.ToString(dr["EBFreeAccessTPANetworkLimit"]);
                            lstInfo.EBReimbursementNonNetworkMedicalProviders = ds.Tables[0].AsEnumerable().SelectMany(r => r.Field<string>(66).Split('~')).ToArray();
                          //  lstInfo.EBReimbursementNonNetworkMedicalProviders = Convert.ToString(dr["EBReimbursementNonNetworkMedicalProviders"]);
                            lstInfo.EBReimbursementNonNetworkMedicalProvidersLimit = Convert.ToString(dr["EBReimbursementNonNetworkMedicalProvidersLimit"]);
                            lstInfo.EBEmergencyTreatment = Convert.ToString(dr["EBEmergencyTreatment"]);
                            lstInfo.EBEmergencyTreatmentLimit = Convert.ToString(dr["EBEmergencyTreatmentLimit"]);
                            lstInfo.EBEmergencyTreatmentCountry = ds.Tables[0].AsEnumerable().SelectMany(r => r.Field<string>(70).Split('~')).ToArray();
                           // lstInfo.EBEmergencyTreatmentCountry = Convert.ToString(dr["EBEmergencyTreatmentCountry"]);
                            lstInfo.ABBenefits = Convert.ToString(dr["ABBenefits"]);
                            lstInfo.ABDescription = Convert.ToString(dr["ABDescription"]);
                            lstInfo.ABExclusions = Convert.ToString(dr["ABExclusions"]);
                            lstInfo.PolicyNo = Convert.ToString(dr["PolicyNo"]);
                            lstInfo.GBTotalPremium = Convert.ToDecimal(dr["GBTotalPremium"]);
                            lstInfo.GBPolicyFee = Convert.ToDecimal(dr["GBPolicyFee"]);
                            lstInfo.GBInsuranceLevy = Convert.ToDecimal(dr["GBInsuranceLevy"]);
                            lstInfo.GBPremium = Convert.ToDecimal(dr["GBPremium"]);

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        public List<DataPoint> GetDBBarchartUW(int flag, string uname)
        {
            List<DataPoint> lst = new List<DataPoint>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "GetBarChartUW"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    //cmd.Parameters.AddWithValue("@flag", flag);
                    cmd.Parameters.AddWithValue("@UserName", uname);

                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    sdaAdapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lst = (from DataRow dr in ds.Tables[0].Rows
                               select new DataPoint()
                               {

                                   y = dr["MonthName"].ToString(),
                                   a = (decimal)dr["TotalPremiumEarned"],
                                   b = (decimal)dr["TotalPremiumRejected"],
                                   c = (decimal)dr["TotalPremiumPending"],

                               }).ToList();
                    }

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;
        }
        public List<DataPoint> GetLinechartUWriter(int flag, string uname)
        {
            List<DataPoint> lst = new List<DataPoint>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_GetLineChartUW"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    //cmd.Parameters.AddWithValue("@flag", flag);
                    cmd.Parameters.AddWithValue("@UserName", uname);

                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    sdaAdapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lst = (from DataRow dr in ds.Tables[0].Rows
                               select new DataPoint()
                               {

                                   y = dr["MonthName"].ToString(),
                                   a = (long)dr["Pending"],
                                   b = (long)dr["Approved"],
                                   c = (long)dr["Rejected"],
                                   d = (long)dr["Total"],

                               }).ToList();
                    }

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;
        }
        public List<ProducerMaster> GetUserList(string BussType)
        {
            List<ProducerMaster> lst = new List<ProducerMaster>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection con = new SqlConnection(objUtility.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "SP_GetProducerList"
                    };

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@MasterType", BussType);

                    SqlDataAdapter sdaAdapter = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    sdaAdapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lst = (from DataRow dr in ds.Tables[0].Rows
                               select new ProducerMaster()
                               {
                                   Id = (long)dr["Id"],
                                   Name = dr["Name"].ToString(),
                                   EmailId = dr["EmailId"].ToString(),
                                  
                               }).ToList();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;
        }
    }
}
