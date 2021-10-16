
using System.Data;
using Resto_WebApi.Models;
using System.Web.Http;

namespace Resto_WebApi.Controllers
{
    public class MenuController : ApiController
    {
        Database.DB record = new Database.DB();
        public DataSet Get(string Command, int Cat_Id, int Res_Id)
        {
            Menu menu = new Menu();
            menu.Cat_Id = Cat_Id;
            menu.Res_Id = Res_Id;
            DataSet ds = record.MenuDetails(Command, menu);
            return ds;
        }
    }
}
