using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerProject.DataStruct;
using ServerProject.DAL;

namespace ServerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            EmployeeDAL employeeDAL = new EmployeeDAL();

            employees = employeeDAL.GetAllEmployeeDAL();

            return employees;
        }

        //[HttpGet]
        //public WebResponse GetAllEmployees()
        //{
        //    WebResponse webResponse = new();
        //    try
        //    {
        //        List<Employee> employees = new List<Employee>();

        //        EmployeeDAL employeeDAL = new EmployeeDAL();

        //        employees = employeeDAL.GetAllEmployeeDAL();

        //        webResponse.Success = true;
        //        webResponse.ExceptionMessage = null;
        //        webResponse.Value = employees;
        //    }
        //    catch (Exception ex)
        //    {
        //        webResponse.Success = false;
        //        webResponse.ExceptionMessage = ex.Message;
        //        webResponse.Value = null;
        //    }

        //    return webResponse;
        //}


        [HttpGet("{EmployeeID}")]
        public Employee GetEmployeeByID(int EmployeeID)
        {
            Employee employee = new Employee();
            EmployeeDAL employeeDAL = new EmployeeDAL();
            employee = employeeDAL.GetEmployeeByIDDAL(EmployeeID);
            return employee;
        }




        [HttpPost]
        public void AddEmployee(Employee emp)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();

            employeeDAL.AddEmployeeDAL(emp);
        }

        //[HttpPost]
        //public WebResponse AddEmployee(Employee emp)
        //{
        //    WebResponse webResponse = new();
        //    try
        //    {
        //        EmployeeDAL employeeDAL = new EmployeeDAL();
        //        employeeDAL.AddEmployeeDAL(emp);

        //        webResponse.Success = true;
        //        webResponse.ExceptionMessage = null;
        //        webResponse.Value = { };

        //    }
        //    catch (Exception ex)
        //    {
        //        webResponse.Success = false;
        //        webResponse.ExceptionMessage = ex.Message;
        //        webResponse.Value = null;
        //    }
        //    return webResponse;
        //}

        //[HttpPost]
        //public WebResponse AddEmployee(Employee emp)
        //{
        //    WebResponse webResponse = new();
        //    try
        //    {
        //        EmployeeDAL employeeDAL = new EmployeeDAL();
        //        employeeDAL.AddEmployeeDAL(emp);

        //        webResponse.Success = true;
        //        webResponse.ExceptionMessage = null;
        //        webResponse.Value = { };

        //    }
        //    catch (Exception ex)
        //    {
        //        webResponse.Success = false;
        //        webResponse.ExceptionMessage = ex.Message;
        //        webResponse.Value = null;
        //    }
        //    return webResponse;         
        //}




        [HttpDelete("{EmployeeID}")]
        public void DeleteEmployee(int EmployeeID)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();

            employeeDAL.DeleteEmployeeDAL(EmployeeID);

        }


        [HttpPut("{EmployeeID}")]
        public void UpdateEmployee(int EmployeeID, Employee emp)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();

            employeeDAL.UpdateEmployeeDAL(EmployeeID, emp);

        }
    }
}