using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using ServerProject.DataStruct;

namespace ServerProject.DAL
{
    public class AdminDAL
    {
        //public string ValidateAdminDAL(Admin admin)
        //{
        //    string result = "false";

        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "server=DESKTOP-0677600;Daabase=AHAMAD;Integrated Security=Yes;";

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from admins where AdminName=@AdminName and Password=@Password";
        //    cmd.Parameters.AddWithValue("@AdminName", admin.AdminName);
        //    cmd.Parameters.AddWithValue("@Password", admin.Password);

        //    con.Open();

        //    cmd.Connection = con;

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.HasRows)
        //    {
        //        result = "true";
        //    }

        //    con.Close();

        //    return result;
        //}


        //public Admin ValidateAdminDAL(string AdminName, string Password)
        //{
        //    Admin _admin = new Admin();

        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "server=DESKTOP-0677600;Database=AHAMAD;Integrated Security=Yes;";

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from admins where AdminName=@AdminName and Password=@Password";
        //    cmd.Parameters.AddWithValue("@AdminName", AdminName);
        //    cmd.Parameters.AddWithValue("@Password", Password);

        //    con.Open();

        //    cmd.Connection = con;

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        _admin = new Admin();
        //        _admin.AdminName = dr["AdminName"].ToString();
        //        _admin.Password = dr["Password"].ToString();
        //    }

        //    con.Close();

        //    return _admin;
        //}


        public bool ValidateAdminDAL(string AdminName, string Password)
        {
            bool response = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-0677600;Database=AHAMAD;Integrated Security=Yes;";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from admins where AdminName=@AdminName and Password=@Password";
            cmd.Parameters.AddWithValue("@AdminName", AdminName);
            cmd.Parameters.AddWithValue("@Password", Password);

            con.Open();

            cmd.Connection = con;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                response = true;
            }

            con.Close();

            return response;
        }



    }
}
