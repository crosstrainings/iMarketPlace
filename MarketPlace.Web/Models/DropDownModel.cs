using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace iMarketPlace.Web.Models
{
    public class DropDownModel
    {
        public string Name { get; set; }
        public List<SelectListItem> List { get; set; }

    }
}
