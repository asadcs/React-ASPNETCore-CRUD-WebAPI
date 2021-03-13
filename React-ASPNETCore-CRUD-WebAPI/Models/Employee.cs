using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace React_ASPNETCore_CRUD_WebAPI.Models
{
    public class Employee
    {
        public long EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        public string MailID { get; set; }

        public DateTime? DOJ { get; set; }
    }
}