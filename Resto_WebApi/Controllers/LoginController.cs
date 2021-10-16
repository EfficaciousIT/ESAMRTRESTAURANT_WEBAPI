using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Resto_WebApi.Models;
using System.Data;
namespace Resto_WebApi.Controllers
{
    public class LoginController : ApiController
    {
        Database.DB record = new Database.DB();
        public DataSet Get(string Command, string Username, string Password)
        {
            Login login = new Login();
            login.User_Name = Username;
            login.Password = Password;
            DataSet ds = record.LoginDetails(Command, login);
            return ds;
        }
    }
}
