﻿using System;
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
        public long CloseRaisedTicket(RaiseTickets objRaiseTickets,out List<Employee> lstMailNewPwsd)
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
    }
}
