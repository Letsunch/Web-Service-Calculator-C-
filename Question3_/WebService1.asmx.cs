﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServ
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int add(int x, int y)
        {
            return (x + y);
        }
        [WebMethod]
        public int subtact(int x, int y)
        {
            return (x - y);
        }
        [WebMethod]
        public int multiply(int x, int y)
        {
            return (x * y);
        }
        [WebMethod]
        public int divide(int x, int y)
        {
            return (x / y);
        }
    }
}
