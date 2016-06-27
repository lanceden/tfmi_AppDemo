using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tfmi_demo.Model;
using Table = System.Web.UI.WebControls.Table;

namespace tfmi_demo.Controllers
{
    public class CharityController : BaseController
    {
        public IEnumerable<Model.Charity> GetCharityList() => Instance.Charity.Where(c => true).ToList();

    }
}
