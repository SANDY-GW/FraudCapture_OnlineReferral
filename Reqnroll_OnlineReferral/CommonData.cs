using OpenQA.Selenium;

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

        public static Dictionary<string, string> dic = new Dictionary<string, string>
            {
                { "firstName", "Required" },
                { "Last Name", "Required" }

            };


    }
}
