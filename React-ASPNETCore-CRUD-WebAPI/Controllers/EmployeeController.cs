using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using React_ASPNETCore_CRUD_WebAPI.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace React_ASPNETCore_CRUD_WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public HttpResponseMessage GetDepartment()
        {

            DataTable dt = new DataTable();

            string query = @"Select [EmployeeID],[EmployeeName],[Department],[MailID],Convert(varchar(10),DOJ,120) as DOJ from Employees";

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))
            using (var command = new SqlCommand(query, conn))
            using (var da = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            return Request.CreateResponse(HttpStatusCode.OK, dt);

        }
        public string Post(Employee emp)
        {
            try
            {
                DataTable dt = new DataTable();

                string query = @"Insert into Employees values('"+emp.EmployeeName+"','"+emp.Department+"','"+emp.MailID+"','"+emp.DOJ+"')";

                using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))
                using (var command = new SqlCommand(query, conn))
                using (var da = new SqlDataAdapter(command))
                {
                    command.CommandType = CommandType.Text;
                    da.Fill(dt);
                }

                return "Added successfully";
            }
            catch (Exception)
            {

                return "Failed To Add";
            }
        }

        public string PUT(Employee emp)
        {
            try
            {
                DataTable dt = new DataTable();

                string query = @"update employees set [EmployeeName] = '"+emp.EmployeeName+"' , [Department] ='"+emp.Department+"', [MailID] = '"+emp.MailID+"', DOJ = '"+emp.DOJ+"'where [EmployeeID] =" + emp.EmployeeID;
                using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))
                using (var command = new SqlCommand(query, conn))
                using (var da = new SqlDataAdapter(command))
                {
                    command.CommandType = CommandType.Text;
                    da.Fill(dt);
                }

                return "Added successfully";
            }
            catch (Exception)
            {

                return "Failed To Add";
            }
        }
    }

   
}
