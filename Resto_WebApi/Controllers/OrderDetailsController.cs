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
    public class OrderDetailsController : ApiController
    {
        Database.DB record = new Database.DB();
        public HttpResponseMessage Post(string command, OrderDetails orderDetails)
        {
            try
            {
                DataSet ds = record.OrderDetails(command, orderDetails);
                var message = Request.CreateResponse(HttpStatusCode.OK);
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
