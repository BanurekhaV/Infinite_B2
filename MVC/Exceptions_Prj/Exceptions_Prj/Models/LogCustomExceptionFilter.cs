using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exceptions_Prj.Models
{
    public class LogCustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if(!filterContext.ExceptionHandled)
            {
                var exceptionMessage = filterContext.Exception.Message;
                var exceptionStackTrace = filterContext.Exception.StackTrace;
                var exControllerName = filterContext.RouteData.Values["controller"].ToString();
                var exActionName = filterContext.RouteData.Values["action"].ToString();

                string msg = "Date :" + DateTime.Now.ToString() + " " + "ControllerName :" + exControllerName +
                    " " + "Action Name :" + exActionName + "Error Message :" + exceptionMessage +
                    Environment.NewLine + " Stack Trace :" + exceptionStackTrace;

                //now we need to log the above details in log file
                File.AppendAllText(HttpContext.Current.Server.MapPath("~/CustomFilters/ExceptionLog.txt"), msg);
                filterContext.ExceptionHandled = true;
                filterContext.Result = new ViewResult() { ViewName = "Error" };
            }
        }
    }
}