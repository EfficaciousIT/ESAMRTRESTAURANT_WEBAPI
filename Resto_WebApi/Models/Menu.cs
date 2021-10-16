using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto_WebApi.Models
{
    public class Menu
    {
        public int Menu_Id { get; set; }
        public string Cat_Name { get; set; }
        public string Menu_Type { get; set; }
        public string Menu_Name { get; set; }
        public int Price { get; set; }
        public int Cat_Id { get; set; }
        public int Res_Id { get; set; }
    }
}