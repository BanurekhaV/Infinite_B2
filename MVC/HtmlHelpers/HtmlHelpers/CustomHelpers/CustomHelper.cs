using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.CustomHelpers
{
    public class CustomHelper
    {
        public static IHtmlString LabelWithMark(string content)
        {
            string htmlstr = String.Format("<label><b><i><mark><del>{0}</del></mark></i></b></label>", content);
            return new HtmlString(htmlstr);
        }
    }
}