using OpenQA.Selenium;

namespace FC_OnlineReferral
{

    public class OnlineReferralData
    {
        

        public string UserFN { get; set; }

        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Organization { get; set; } 
        public string Email { get; set; } 
        public string Title { get; set; } 
        public string Phone { get; set; } 
        public string StreetAddress1 { get; set; } 
        public string StreetAddress2 { get; set; } 
        public string errormessage { get; set; } = string.Empty;

        public string StateName { get; set;}
        public string RefType { get; set; }
        public string InvolvedPartyType { get; set; }
        public string Detected { get; set; }
        public string ReferralSummary { get; set; }
        public string witness_Or_ExternalReferringParty { get; set; }


        public string isAnotherInvolvedPartyAvailable { get; set; }
        public string additionalInvolvedPartyType { get; set; }
        public string isAnotherExternalInvolvedPartyAvailable { get; set; }
        public string id { get; set; }
        public string ssn { get; set; }
        public string email { get; set; }
        public string report { get; set; }
        public string additionalInfo { get; set; }
        public string Organization1 { get; set; }
        public string FirstName1 { get; set; }
        public string LastName1 { get; set; }
        public string MiddleName1 { get; set; }
        public string report1 { get; set; }
        public string additionalInfo1 { get; set; }
        public string isAnotherInvolvedPartyAvailable1 { get; set; }
        public string question1 { get; set; }
        public string question2 { get; set; }
        public string question3 { get; set; }
        public string question4 { get; set; }
        public string question5 { get; set; }
        public string question6 { get; set; }
        public string filePath { get; set; }
        public string NamePrefix { get; set; }
            public string NameSuffix { get; set; }
            public string StreetAddress3 { get; set; }
            public string StreetAddress4 { get; set; }
            public string City { get; set; }

        public string State { get; set; }
            public string County { get; set; }
            public string Zip { get; set; }
            public string Designation1 { get; set; }
            public string Country { get; set; }
            public string PrimaryPhone { get; set; }
            public string SecondaryPhone { get; set; }
            public string Ssn { get; set; }
            public string OtherId { get; set; }
            public string Email1 { get; set; }
            public string Other { get; set; }








    }


}