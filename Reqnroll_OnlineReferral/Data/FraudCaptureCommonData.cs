using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.Data
{
    public class FraudCaptureCreateNewLead
    {
        public string UserEmail { get; set; }
        public string WorkflowType { get; set; }
        public string DetectionMethod { get; set; }
        public string SourceType { get; set; }
        public string Reason { get; set; }
        public string AssignedTo { get; set; }
        public string SubjectType { get; set; }
        public string SubjectTypeSelect { get; set; }
        public string namePrefix { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ReferringParty { get; set; }
        public string FirstName2 { get; set; }
        public string LastName2 { get; set; }
        public string searchByIdOption { get; set; }
        public string memberId { get; set; }
        public string searchByNameOption { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string addressField { get; set; }
        public string city { get; set; }
        public string organization { get; set; }
        public string providerId { get; set; }

        public string providerfirstName { get; set; }
        public string providerlastName { get; set; }
        public string subjectTypeprovider { get; set; }
        public string subjectTypeselectprovider { get; set; }
        public string searchByIdOptionProvider { get; set; }
        public string providerId1 { get; set; }
        public string tin { get; set; }
        public string npi { get; set; }
        public string providerorganization { get; set; }
        public string provideraddressField { get; set; }
        public string providercity { get; set; }
        public string Firstname { get; set; }
        public string providerName { get; set; }
        public string providerNPI { get; set; }
        public string providerTIN { get; set; }
        public string memberIdRefParty { get; set; }




    }
    
}

