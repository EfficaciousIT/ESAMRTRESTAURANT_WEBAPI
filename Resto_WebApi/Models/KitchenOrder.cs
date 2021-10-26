using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto_WebApi.Models
{
    public class KitchenOrder
    {
        public int OrderId { get; set; }
        public string TableName { get; set; }
        public int RegisterId { get; set; }
        public int ResId { get; set; }
        public string vchSplitTableName { get; set; }
        public string vchSplit_status { get; set; }

    }
}