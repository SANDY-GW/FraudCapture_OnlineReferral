using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral
{
    public class CommonData
    {
        protected readonly IWebDriver Driver;
        public CommonData(IWebDriver driver)
        {
            Driver = driver;
        }

        public class UserCredentials
        {
            public string? Username { get; set; }
            public string? Password { get; set; }
            public bool? IsActive { get; set; }
            //public UserRole Role { get; set; }
            public  string? UserFN { get; set; }
        }


    }
}
