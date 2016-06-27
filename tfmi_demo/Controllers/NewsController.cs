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
    public class NewsController : BaseController
    {
        public IEnumerable<Model.News> GetNewsList() => Instance.News.Where(news => true).OrderBy(news => news.Id).Take(3).ToList();
    }
}
