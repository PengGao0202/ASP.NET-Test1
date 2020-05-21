using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStoreWeb
{
    public partial class BrowserInfo : System.Web.UI.Page
    {
        [Obsolete]
        protected void Page_Load(object sender, EventArgs e)
        {
            
            StringBuilder sbText = new StringBuilder();
            // Get the reference to the HttpBrowserCapabilities object 
            HttpBrowserCapabilities browser = Request.Browser;
            // Display the properties of the HttpBrowserCapabilities Class
            sbText.AppendFormat("Browser : " + browser.Browser + "<br>");
            sbText.AppendFormat("Browser Version: " + browser.Version + "<br>");
            sbText.AppendFormat("Client's Platform: " + browser.Platform + "<br>");
            sbText.AppendFormat(".NET CLR Version: " + browser.ClrVersion + "<br>");
            sbText.AppendFormat("ECMA Script Version: " + browser.EcmaScriptVersion + "<br>");
            sbText.AppendFormat("JavaScript Support: " + browser.JavaScript + "<br>");
            sbText.AppendFormat("Microsoft HTML Document Object Model Version: " + browser.MSDomVersion + "<br>");
            sbText.AppendFormat("World Wide Web (W3C) XML Document " + " Object Model Version: " + browser.W3CDomVersion + "<br>");
            Label1.Text = sbText.ToString();

            StringBuilder sbText2 = new StringBuilder();
            sbText2 = BusinessLayer.BrowerInfo.GetBrowserInfo();
            sbText2.AppendFormat("Browser : " + browser.Browser + "<br>");
            sbText2.AppendFormat("Browser Version: " + browser.Version + "<br>");
            sbText2.AppendFormat("Client's Platform: " + browser.Platform + "<br>");
            sbText2.AppendFormat(".NET CLR Version: " + browser.ClrVersion + "<br>");
            sbText2.AppendFormat("ECMA Script Version: " + browser.EcmaScriptVersion + "<br>");
            sbText2.AppendFormat("JavaScript Support: " + browser.JavaScript + "<br>");
            sbText2.AppendFormat("Microsoft HTML Document Object Model Version: " + browser.MSDomVersion + "<br>");
            sbText2.AppendFormat("World Wide Web (W3C) XML Document " + " Object Model Version: " + browser.W3CDomVersion + "<br>");
            Label2.Text = sbText.ToString();

        }

    }
}