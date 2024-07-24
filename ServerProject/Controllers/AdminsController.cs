using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerProject.DAL;
using ServerProject.DataStruct;

namespace ServerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        //[HttpGet]
        //public ActionResult<Admin> ValidateAdmin(Admin admin)
        //{
        //    Admin _admin = new Admin();
        //    AdminDAL adminDAL = new AdminDAL();
        //    try
        //    {
        //        _admin = adminDAL.ValidateAdminDAL(admin);

        //    }
        //    catch(Exception ex)
        //    {

        //    }
        //    return _admin;
        //}


        //[HttpGet("{admin}")]
        //public ActionResult<Admin> ValidateAdmin(Admin admin)
        //{
        //    Admin _admin = new Admin();
        //    AdminDAL adminDAL = new AdminDAL();
        //    try
        //    {
        //        _admin = adminDAL.ValidateAdminDAL(admin);

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return _admin;
        //}




        //[HttpPost]
        //public ActionResult<Admin> ValidateAdmin(Admin admin)
        //{
        //    Admin _admin = new Admin();
        //    AdminDAL adminDAL = new AdminDAL();
        //    try
        //    {
        //        _admin = adminDAL.ValidateAdminDAL(admin.AdminName, admin.Password);

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return _admin;
        //}



        //[HttpGet("{AdminName}/{Password}")]
        //public ActionResult<Admin> ValidateAdmin(string AdminName, string Password)
        //{
        //    Admin _admin = new Admin();
        //    AdminDAL adminDAL = new AdminDAL();
        //    try
        //    {
        //        _admin = adminDAL.ValidateAdminDAL(AdminName, Password);

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return _admin;
        //}






        [HttpGet("{AdminName}/{Password}")]
        public ActionResult<bool> ValidateAdmin(string AdminName, string Password)
        {
            bool response = false;
            AdminDAL adminDAL = new AdminDAL();
            try
            {
                response = adminDAL.ValidateAdminDAL(AdminName, Password);

            }
            catch (Exception ex)
            {

            }
            return response;
        }


    }
}
