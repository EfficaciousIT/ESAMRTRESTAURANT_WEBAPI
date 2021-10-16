
namespace Resto_WebApi.Models
{
    public partial class Login
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public int Employee_Id { get; set; }
        public int UserType_Id { get; set; }
        public int Res_Id { get; set; }
        public string User_Type { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
    }
}