using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace TheHashSlingingSlasher.Models
{
    public class KategoriModel
    {
        public string KodeKategori { get; set; }
        public string NamaKategori { get; set; }
        public string Keterangan { get; set; }
    }

    public class AttributeModel : ActionMethodSelectorAttribute
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