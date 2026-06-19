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
            public string? UserFN { get; set; }


        }

        public static Dictionary<string, string> dic = new Dictionary<string, string>
            {
                { "firstName", "Required" },
                { "lastName", "Required" },
                { "orgName", "Required" },
                { "email", "Required" },
                { "address1", "Required" },
            {"referalType","Required"},
            {"involvedType", "Required" },
            {"detected", "Required" },
            {"referralSummary", "Required" },
           
            {"isExternalReferal","Required" },
            { "pOrgName","Required"},
            {"pFirstName","Required" },
            { "pLastName","Required"},
            { "pDateOfBirth","Required"},
            {"pProviderID" ,"Required"},
            {"pTaxonomy","Required" },
            {"pStreetAddress1","Required" },
            {"pCity","Required" },
            { "pState","Required" },
            { "pZip","Required"},
            {"pCountry" ,"Required"},
            {"pPhone","Required" },
            {"pEmail","Required" },
            { "externalReferalReport","Required"},
            {"isAnotherInvolvedParty","Required" },
            {"questionTxt2","Required" },
            {"questiondDrDown3","Required" },
            {"questionTxt4","Required"},
            {"questiondDrDown5","Required" },
            {"questionTxt6","Required" }




            };




    }
}
