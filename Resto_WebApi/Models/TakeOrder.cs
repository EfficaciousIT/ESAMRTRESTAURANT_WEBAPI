using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto_WebApi.Models
{
    public class TakeOrder
    {
        public string TableName { get; set; }
        public int RegisterId { get; set; }
        public int EmployeeId { get; set; }
        public string DeviceId { get; set; }
        public int IsActive { get; set; }
        public int intPersonCOunt { get; set; }
        public int ResId { get; set; }
        public string vchSplitTableName { get; set; }
        public string vchSplit_status { get; set; }
        public string Status { get; set; }
    }
}