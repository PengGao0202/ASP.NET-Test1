using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace PetStoreWeb.BusinessLayer
{
    public class BrowerInfo
    {
        public static StringBuilder GetBrowserInfo()
        {
            StringBuilder sbText = new StringBuilder();
            // Get the reference to the HttpBrowserCapabilities object
            HttpBrowserCapabilities browser = System.Web.HttpContext.Current.Request.Browser;
            return sbText;
        }
    }
}