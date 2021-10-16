using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resto_WebApi.Models
{
    public class TableStatus
    {
        public int Table_Id { get; set; }
        public string Table_Status { get; set; }
        public string Table_Name { get; set; }
        public int Res_Id { get; set; }
    }
}