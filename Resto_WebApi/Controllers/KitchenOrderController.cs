using Resto_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Resto_WebApi.Controllers
{
    public class KitchenOrderController : ApiController
    {
        Database.DB record = new Database.DB();
        public DataSet Get(string Command, int ResId)
        {
            TakeOrder takeOrder = new TakeOrder();
            takeOrder.ResId = ResId;
            DataSet ds = record.GetKitchenOrder(Command, takeOrder);
            return ds;
        }
    }
}
