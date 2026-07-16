using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FC_OnlineReferral
{

    public class OnlineReferralData
    {



        public string UserFirstName { get; set; } = string.Empty;
        public string UserLastName { get; set; } = string.Empty;
        public string Orgname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public string Phonenumber { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string errormessage { get; set; } = string.Empty;
        public string Invalidfax { get; set; } = string.Empty;
        public string FaxValidationErrorMessage { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string Invalidemail { get; set; } = string.Empty;
        public string Emailvalidationerrormessage { get; set; } = string.Empty;

        public string Invalidzipcode { get; set; } = string.Empty;
        public string Zipcodevalidationerrormessage { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        public string incidentStartDate { get; set; } = string.Empty;
        public string incidentEndDate { get; set; } = string.Empty;
        public string DOB { get; set; } = string.Empty;
        public string DOBValidationMessage { get; set; } = string.Empty;

        public string involvedPartyType { get; set; } = string.Empty;
        public string referralType { get; set; } = string.Empty;
        public string caseOrReferenceNumber { get; set; } = string.Empty;
        public string detectedAs { get; set; } = string.Empty;
        public string summary { get; set; } = string.Empty;
        public string amount { get; set; } = string.Empty;

        public string detectionDate { get; set; } = string.Empty;
        public string City2 { get; set; } = string.Empty;
        public string State2 { get; set; } = string.Empty;
        public string DollarsymbolinAmountFieldValidationMessage { get; set; } = string.Empty;
        public string InvalidDOB { get; set; } = string.Empty;
        public string witnessDropdown { get; set; } = string.Empty;

        public string witnessType { get; set; } = string.Empty;
        public string orgname { get; set; } = string.Empty;
        public string namePrefix { get; set; } = string.Empty;
        public string firstName { get; set; } = string.Empty;
        public string middleName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;

        public string nameSuffix { get; set; } = string.Empty;
        public string designation { get; set; } = string.Empty;

        public string SSN { get; set; } = string.Empty;
        public string licenseNumber { get; set; } = string.Empty;


        public string IDTest { get; set; } = string.Empty;
        public string NPI { get; set; } = string.Empty;
        public string TIN { get; set; } = string.Empty;
        public string medicaidID { get; set; } = string.Empty;
        public string MedicareID { get; set; } = string.Empty;

        public string otherID { get; set; } = string.Empty;
        public string providerType { get; set; } = string.Empty;
        public string providerSpecialty { get; set; } = string.Empty;
        public string Taxonomy { get; set; } = string.Empty;
        public string other { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        public string fax { get; set; } = string.Empty;
        public string Emailaddress { get; set; } = string.Empty;
        public string IsthereanyInvolvedPartyDropdown { get; set; } = string.Empty;
        public string County { get; set; } = string.Empty;

        public string associatedstate { get; set; } = string.Empty;
        public string Question1 { get; set; } = string.Empty;
        public string Question2 { get; set; } = string.Empty;
        public string Question3 { get; set; } = string.Empty;
        public string TestFile { get; set; } = string.Empty;
        public string Question4 { get; set; } = string.Empty;

        public string isAnotherInvolvedPartyAvailable { get; set; } = string.Empty;

        public string Question5 { get; set; } = string.Empty;
        public string additionalInvolvedPartyType { get; set; } = string.Empty;
        public string isAnotherExternalInvolvedPartyAvailable { get; set; } = string.Empty;

        public string Organization1 { get; set; } = string.Empty;

        public string NamePrefix { get; set; } = string.Empty;
        public string FirstName1 { get; set; } = string.Empty;
        public string MiddleName1 { get; set; } = string.Empty;
        public string LastName1 { get; set; } = string.Empty;
        virtual public string NameSuffix { get; set; } = string.Empty;
        public string StreetAddress3 { get; set; } = string.Empty;
        public string StreetAddress4 { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string Designation1 { get; set; } = string.Empty;
        public string Country1 { get; set; } = string.Empty;
        public string PrimaryPhone { get; set; } = string.Empty;
        public string SecondaryPhone { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;
        public string Ssn { get; set; } = string.Empty;

        public string OtherId { get; set; } = string.Empty;

        public string Email1 { get; set; } = string.Empty;
        public string Other { get; set; } = string.Empty;

        public string report { get; set; }
        public string additionalInfo { get; set; } = string.Empty;
        public string report1 { get; set; } = string.Empty;
        public string additionalInfo1 { get; set; } = string.Empty;


        public string isAnotherInvolvedPartyAvailable1 { get; set; } = string.Empty;


        public string Gender { get; set; } = string.Empty;
        public string HowWitnessOrExternalPartyReportedThis { get; set; } = string.Empty;
        public string AnyAdditionalInfo { get; set; } = string.Empty;

        public string planType { get; set; } = string.Empty;
        public string Program { get; set; } = string.Empty;
        public string LOB { get; set; } = string.Empty;
        public string Group { get; set; } = string.Empty;

        public string updatedOrgname { get; set; } = string.Empty;
        public string updatedFirstName { get; set; } = string.Empty;

        public string incidentValidStartDate { get; set; } = string.Empty;
        public string incidentValidEndDate { get; set; } = string.Empty;

        public string InvalidIncidentEndDate { get; set; }= string.Empty;
        public string InvalidIncidentStartDate { get; set; } = string.Empty;
        public string UserEmailID { get; set; } = string.Empty;
        public string Payor { get; set; } = string.Empty;
        public string Leads { get; set; } = string.Empty;
        public string ActivityName { get; set; } = string.Empty;





    }


}