using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using Resto_WebApi.Models;
using System.Web.Http;

namespace Resto_WebApi.Controllers
{
    public class CategoryController : ApiController
    {
        Database.DB record = new Database.DB();
        public DataSet Get(string Command, int Res_Id)
        {
            Category category = new Category();
            category.Res_Id = Res_Id;
            DataSet ds = record.MenuCategotyDetails(Command, category);
            return ds;
        }
    }
}
