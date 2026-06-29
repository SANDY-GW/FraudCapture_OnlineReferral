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
            {"questionTxt6","Required" },

            //Subject type as member
            
            
           
            // {"mNamePrefix", "Required" },
            {"mFirstName", "Required" },
           // {"mMiddleName", "Required" },
            {"mLastName", "Required" },
           // {"mNameSuffix", "Required" },
            {"mDateOfBirth", "Required" },
            {"mGender", "Required" },
            {"mOther", "Required" },
           //. {"externalReferalAddInfo", "Required" },
            {"mID", "Required" },
            {"mSSN", "Required" },
            {"mMedicaidId", "Required" },
              {"mMedicareId", "Required" },
                {"mOtherId", "Required" },
                 {"mPlan", "Required" },
                    {"mProgram", "Required" },
                      {"mLOB", "Required" },
                    {"mGroup", "Required" },
                    {"mAddress1", "Required" },
                    //{"mAddress2", "Required" },
                    {"mCity", "Required" },
                    {"mState", "Required" },
                     {"mCounty", "Required" },
                      {"mZip", "Required" },
                       {"mPrimaryPhone", "Required" },
                        {"mSecondaryPhone", "Required" },
{"mEmail", "Required" },



//Non-Enumerated Individual/Member


           {"neiAssociatedOrg", "Required" },
            {"neiNamePrefix", "Required" },
           {"neiFirstName", "Required" },
            {"neiMiddleName", "Required" },
            {"neiLastName", "Required" },
            {"neiNameSuffix", "Required" },
            {"neiDesignation", "Required" },
            {"neiDateOfBirth", "Required" },
           {"neiSsn", "Required" },
            {"neiOtherId", "Required" },
            {"neiOther", "Required" },
            {"neiStreetAddress1", "Required" },
              {"neiStreetAddress2", "Required" },
                {"neiCity", "Required" },
                 {"neiState", "Required" },
                    {"neiCounty", "Required" },
                      {"neiZip", "Required" },
                    {"neiCountry", "Required" },
                    {"neiPrimaryPhone", "Required" },
                    {"neiSecondaryPhone", "Required" },
                    {"neiEmail", "Required" },


                    // Non-Enumertaed Provider

             {"nepOrgName", "Required" },
            {"nepNamePrefix", "Required" },
           {"nepFirstName", "Required" },
            {"nepMiddleName", "Required" },
            {"nepLastName", "Required" },
            {"nepNameSuffix", "Required" },
            {"nepDesignation", "Required" },
            {"nepDateOfBirth", "Required" },
           {"nepSsn", "Required" },
           {"nepLicenseNo", "Required" },
            {"nepOtherId", "Required" },
            {"nepOther", "Required" },
            {"nepStreetAddress1", "Required" },
              {"nepStreetAddress2", "Required" },
                {"nepCity", "Required" },
                 {"nepState", "Required" },
                    {"nepCounty", "Required" },
                      {"nepZip", "Required" },
                    {"nepCountry", "Required"},
                    {"nepPrimaryPhone", "Required" },
                    {"nepSecondaryPhone", "Required" },
                    {"nepEmail", "Required" },

                     {"nepFax", "Required" },

        };




    }
}
