
using System.Data;
using Resto_WebApi.Models;
using System.Web.Http;

namespace Resto_WebApi.Controllers
{
    public class TableStatusController : ApiController
    {
        Database.DB record = new Database.DB();
        public DataSet Get(string Command, int Res_Id)
        {
            TableStatus tableStatus = new TableStatus();
            tableStatus.Res_Id = Res_Id;
            DataSet ds = record.TableStatusDetails(Command, tableStatus);
            return ds;
        }
    }
}
