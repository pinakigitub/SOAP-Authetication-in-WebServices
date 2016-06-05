using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace AuthForWebServices
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        public AuthHeader Authentication;

        public WebService()
        {
            
            InitializeComponent();
        }

        private IContainer components = null;

        private void InitializeComponent()
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        [SoapHeader("Authentication", Required = true)]
        [WebMethod(Description = "Returns some sample data")]
        public string SensitiveData()
        {
            string data = null;
            if (Authentication.Username == "test" && Authentication.Password == "test")
            {
                data = "Success";
            }
            else
            {
                data = "Error";
            }
            return data;
        }
    }

    public class AuthHeader : SoapHeader
    {
        public string Username {get;set;}
        public string Password {get;set;}
    }
}
