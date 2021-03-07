using System.IO;
using System.Web.Mvc;
using MidAssignment1.Models;

namespace MidAssignment1.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (user.Name == null)
            {
                ViewData["errMessage"] = "Name is Required";
                return View();
            }

            if (user.UserName == null)
            {
                ViewData["errMessage"] = "User Name is Required";
                return View();
            }
            
            if (user.Password == null)
            {
                ViewData["errMessage"] = "Password is Required";
                return View();
            }
            
            if (user.ConfirmPassword == null)
            {
                ViewData["errMessage"] = "Confirm Password is Required";
                return View();
            }

            if (user.Dob == null)
            {
                ViewData["errMessage"] = "DOB is Required";
                return View();
            }
            
            if (user.BloodGroup == null)
            {
                ViewData["errMessage"] = "Blood Group must be Selected";
                return View();
            }
            
            if (user.Gender == null)
            {
                ViewData["errMessage"] = "Gender must be Selected";
                return View();
            }

            if (user.Password != user.ConfirmPassword)
            {
                ViewData["errMessage"] = "Password Did Not match with the confirm password";
                return View();
            }
            
            if (user.Condition == null)
            {
                ViewData["errMessage"] = "Terms and Condition must be checked";
                return View();
            }
            
            if (user.ProfilePic == null)
            {
                ViewData["errMessage"] = "Choose a Picture for your Profile";
                return View();
            }

            /*if (user.ProfilePic != null)
            {
                string filePath = Server.MapPath("../Views/Image");
                string fileName = Path.GetFileName(user.ProfilePic.FileName);

                string fullPath = Path.Combine(filePath, fileName);
                user.ProfilePic.SaveAs(filePath);
            }*/
            
            else
            {
                string filePath = Server.MapPath("~/Image/");
                string fileName = Path.GetFileName(user.ProfilePic.FileName);

                string fullFilePath = Path.Combine(filePath, fileName);
                user.ProfilePic.SaveAs(fullFilePath);
                user.PicturePath = "~/Image/"+user.ProfilePic.FileName;
                //user.PicturePath = fullFilePath;
                //user.PicturePath = user.ProfilePic.FileName;
                
                /*return Content("<h4>"+"Name: " + user.Name+ "</h4>"+ "<h4>"+ "User Name: " + user.UserName + "</h4>"+
                "<h4>"+ "Password: " + user.Password + "</h4>"+ "<h4>"+ "DOB: " + user.Dob + "</h4>" + "<h4>"+
                "Blood Group: " + user.BloodGroup + "</h4>"+ "<h4>"+ "Gender: " + user.Gender + "</h4>" + "<h4>"+
                    "Picture: " + user.PicturePath+ "</h4>"+
                "<img src='user.PicturePath' width='200' height='200'>");*/


                return View("Test", user);
            }
        }
    }
}