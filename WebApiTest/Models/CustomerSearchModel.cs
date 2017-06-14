using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Web.Configuration;
using WebApiTest.Service.Interfaces;

namespace WebApiTest.Models
{
    public class CustomerSearchModel
    {
        public string Name { get; set; } 
        public string Address { get; set; }
    }
}