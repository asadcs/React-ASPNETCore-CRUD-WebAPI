using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Configuration;
using React_ASPNETCore_CRUD_WebAPI.Models;

namespace React_ASPNETCore_CRUD_WebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        public HttpResponseMessage GetDepartment()
        {

            DataTable dt = new DataTable();

            string query = @"select * from Departments";

            using ( var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString)) 
                using (var command = new SqlCommand(query , conn))
                using (var da =new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.Text;
                da.Fill(dt);
            }

            return Request.CreateResponse(HttpStatusCode.OK, dt);

        }

        public string Post(Department dept)
        {
            try
            {
                DataTable dt = new DataTable();

                string query = @"insert into departments values('"+dept.DepartmentName+"')";

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


        public string PUT(Department dept)
        {
            try
            {
                DataTable dt = new DataTable();

                string query = @"update Departments set [DepartmentName] = '"+dept.DepartmentName+"' where [DepartmentID]="+dept.DepartmentID;

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

        public string DELETE(Department dept)
        {
            try
            {
                DataTable dt = new DataTable();

                string query = @"update Departments set [DepartmentName] = '" + dept.DepartmentName + "' where [DepartmentID]=" + dept.DepartmentID;

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
