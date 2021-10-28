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
    public class KitchenOrderDetailController : ApiController
    {
        Database.DB record = new Database.DB();

        public DataSet Get(string Command, int ResId, int OrderId)
        {
            KitchenOrderDetails kitchenOrderDetails = new KitchenOrderDetails();
            kitchenOrderDetails.ResId = ResId;
            kitchenOrderDetails.OrderId = OrderId;
            DataSet ds = record.GetKitchenOrderDetails(Command, kitchenOrderDetails);
            return ds;
        }
    }

}


