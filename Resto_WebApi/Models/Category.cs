using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto_WebApi.Models
{
    public class Category
    {
        public string Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        public int Url_Category { get; set; }
        public int Res_Id { get; set; }
    }
}