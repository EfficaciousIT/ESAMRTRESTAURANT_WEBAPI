using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto_WebApi.Models
{
    public class OrderDetails
    {
        public string OrderId { get; set; }
        public int CategoryName { get; set; }
        public int MenuName { get; set; }
        public string TableName { get; set; }
        public int RegisterId { get; set; }
        public int EmployeeId { get; set; }
        public int Price { get; set; }
        public string Qty { get; set; }
        public string vchFoodDescription { get; set; }
        public string Kitchen_status { get; set; }
        public string status { get; set; }
    }
}