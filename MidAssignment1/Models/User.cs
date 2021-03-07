using System.Web;

namespace MidAssignment1.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string UserName { get; set; }
        public string Dob { get; set; }

        public string Password { get; set; }
        public string BloodGroup { get; set; }
        public string ConfirmPassword { get; set; }
        public string Condition { get; set; }
        public HttpPostedFileBase ProfilePic { get; set; }
        public string PicturePath { get; set; }
    }
}