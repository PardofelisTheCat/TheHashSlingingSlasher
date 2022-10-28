using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace TheHashSlingingSlasher.Models
{
    public class BarangModel
    {
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Keterangan { get; set; }
        public int Jumlah { get; set; }
    }

    public class AttributeModel2 : ActionMethodSelectorAttribute
    {
        public string Name { get; set; }
        public string Data { get; set; }
        public override bool IsValidForRequest(ControllerContext context, MethodInfo Info)
        {
            var request = context.RequestContext.HttpContext.Request;
            return request.Form[this.Name.Trim()] == this.Data;
        }
    }

}