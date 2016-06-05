using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AuthForWebServices.MyservicyProxy;

namespace AuthForWebServices
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AuthForWebServices.MyservicyProxy.WebService webService = new MyservicyProxy.WebService();
            AuthForWebServices.MyservicyProxy.AuthHeader authentication = new MyservicyProxy.AuthHeader();
            authentication.Username = "test111";
            authentication.Password = "test111";
            webService.AuthHeaderValue = authentication;
            string data = webService.SensitiveData();
            var fgg = data;
        }
    }
}