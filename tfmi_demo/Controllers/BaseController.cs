namespace tfmi_demo.Controllers
{
    using System.Web.Http;
    using System;
    using tfmi_demo.Model;

    public class BaseController:ApiController
    { 
        private  readonly Lazy<TFMI> Lazy = new Lazy<TFMI>(() => new TFMI());
        public  TFMI Instance { get { return Lazy.Value; } } 
    }
}
