using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto_WebApi.Models
{
    public class KitchenOrderDetails
    {
        public int OrderId { get; set; }
        public string CategoryName { get; set; }
        public string MenuName { get; set; }
        public int Qty { get; set; }
        public string vchFoodDescription { get; set; }
        public string FoodCode { get; set; }
        public int ResId { get; set; }
    }
}