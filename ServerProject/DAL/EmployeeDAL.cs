using System.Data;
using System.Data.SqlClient;
using ServerProject.DataStruct;

namespace ServerProject.DAL
{
    public class EmployeeDAL
    {
        public List<Employee> GetAllEmployeeDAL()
        {
            List<Employee> employees = new List<Employee>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-0677600;Database=AHAMAD;Integrated Security=Yes;";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

            con.Open();

            cmd.Connection = con;

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Employee emp = new Employee();

                emp.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                emp.EmployeeName = dr["EmployeeName"].ToString();
                emp.Salary = Convert.ToInt32(dr["Salary"]);
                emp.DateOfJoin = dr["DateOfJoin"].ToString();
                emp.Designation = dr["Designation"].ToString();

                employees.Add(emp);
            }

            con.Close();

            return employees;
        }


        //public WebResponse GetAllEmployeeDAL()
        //{
        //    WebResponse webResponse = new WebResponse();
        //    try
        //    {
        //        List<Employee> employees = new List<Employee>();

        //        SqlConnection con = new SqlConnection();
        //        con.ConnectionString = "Server=DESKTOP-0677600;Database=AHAMAD;Integrated Security=Yes;";

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "select * from Employees";

        //        con.Open();

        //        cmd.Connection = con;

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            Employee emp = new Employee();

        //            emp.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
        //            emp.EmployeeName = dr["EmployeeName"].ToString();
        //            emp.Salary = Convert.ToInt32(dr["Salary"]);
        //            emp.DateOfJoin = dr["DateOfJoin"].ToString();
        //            emp.Designation = dr["Designation"].ToString();

        //            employees.Add(emp);
        //        }

        //        con.Close();

        //        webResponse.Success = true;
        //        webResponse.ExceptionMessage = null;
        //        webResponse.Value = employees;
        //    }
        //    catch(Exception ex)
        //    {
        //        webResponse.Success = false;
        //        webResponse.ExceptionMessage = ex.Message;
        //        webResponse.Value = null;
        //    }
            
        //    return webResponse;
        //}


        public Employee GetEmployeeByIDDAL(int empID)
        {

            Employee emp = new Employee();

            // create connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-0677600;Database=AHAMAD;Integrated Security=Yes;";

            // open connection
            con.Open();

            // create command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees where EmployeeID=" + empID;

            // pass the connection
            cmd.Connection = con;

            // execute Query
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                emp.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                emp.EmployeeName = dr["EmployeeName"].ToString();
                emp.Salary = Convert.ToInt32(dr["Salary"]);
                emp.DateOfJoin = dr["DateOfJoin"].ToString();
                emp.Designation = dr["Designation"].ToString();
            }

            // close connection
            con.Close();

            return emp;
        }


        public void AddEmployeeDAL(Employee emp)
        {
            // Create connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-0677600;Database=AHAMAD;Integrated Security=Yes;";

            // Open connection
            con.Open();

            // Create Command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Employees values(@EmployeeID, @EmployeeName, @Salary, @DateOfJoin, @Designation)";
            cmd.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
            cmd.Parameters.AddWithValue("@EmployeeName", emp.EmployeeName);
            cmd.Parameters.AddWithValue("@Salary", emp.Salary);
            cmd.Parameters.AddWithValue("@DateOfJoin", emp.DateOfJoin);
            cmd.Parameters.AddWithValue("@Designation", emp.Designation);

            // Pass the Connection
            cmd.Connection = con;

            // Execute the Connection
            cmd.ExecuteNonQuery();

            // Close the Connection
            con.Close();

        }


        public void DeleteEmployeeDAL(int empID)
        {
            // create connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-0677600;Database=AHAMAD;Integrated Security=Yes";

            // open connection
            con.Open();

            // create command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Employees where EmployeeID=" + empID;

            // pass the connection
            cmd.Connection = con;

            // execute the connection
            cmd.ExecuteNonQuery();

            // close the connection
            con.Close();
        }


        public void UpdateEmployeeDAL(int empID, Employee employee)
        {
            // create connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-0677600;Database=AHAMAD;Integrated Security=Yes;";

            // open connection
            con.Open();

            // create command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Employees set EmployeeName=@EmployeeName, Salary=@Salary, DateOfJoin=@DateOfJoin, Designation=@Designation where EmployeeID="+empID;
            cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
            cmd.Parameters.AddWithValue("@Salary", employee.Salary);
            cmd.Parameters.AddWithValue("@DateOfJoin", employee.DateOfJoin);
            cmd.Parameters.AddWithValue("Designation", employee.Designation);

            // pass the connection
            cmd.Connection = con;

            // execute command
            cmd.ExecuteNonQuery();

            // close the connection
            con.Close();
        }
    }
}
