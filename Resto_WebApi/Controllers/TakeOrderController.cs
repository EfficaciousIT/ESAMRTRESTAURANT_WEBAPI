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
    public class TakeOrderController : ApiController
    {
        Database.DB record = new Database.DB();
        public HttpResponseMessage Post(string command, TakeOrder takeOrder)
        {
            try
            {
                DataSet ds = record.TakeOrderDetails(command, takeOrder);
                var message = Request.CreateResponse(HttpStatusCode.OK);
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public DataSet Get(string Command, int ResId)
        {
            TakeOrder takeOrder = new TakeOrder();
            takeOrder.ResId = ResId;
            DataSet ds = record.GetOrderId(Command, takeOrder);
            return ds;
        }

    }
}
