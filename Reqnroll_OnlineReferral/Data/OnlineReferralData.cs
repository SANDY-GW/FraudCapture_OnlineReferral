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


        public string StateName { get; set;}= string.Empty;
        public string RefType { get; set; }= string.Empty;
        public string InvolvedPartyType { get; set; }=string.Empty;
        public string Detected { get; set; }= string.Empty;
        public string ReferralSummary { get; set; }= string.Empty;
        public string witness_Or_ExternalReferringParty { get; set; }= string.Empty;


        public string isAnotherInvolvedPartyAvailable { get; set; }= string.Empty;
        public string additionalInvolvedPartyType { get; set; }= string.Empty;
        public string isAnotherExternalInvolvedPartyAvailable { get; set; }= string.Empty;
        public string id { get; set; }= string.Empty;
        public string ssn { get; set; }= string.Empty;
        public string email { get; set; }= string.Empty;
        public string report { get; set; }= string.Empty;
        public string additionalInfo { get; set; }= string.Empty;
        public string Organization1 { get; set; }= string.Empty;
        public string FirstName1 { get; set; }= string.Empty;
        public string LastName1 { get; set; }= string.Empty;
        public string MiddleName1 { get; set; }=string.Empty;
        public string report1 { get; set; }= string.Empty;
        public string additionalInfo1 { get; set; }= string.Empty;
        public string isAnotherInvolvedPartyAvailable1 { get; set; }= string.Empty;
        public string question1 { get; set; }= string.Empty;
        public string question2 { get; set; }= string.Empty;
        public string question3 { get; set; }= string.Empty;
        public string question4 { get; set; }= string.Empty;
        public string question5 { get; set; }= string.Empty;
        public string question6 { get; set; }= string.Empty;
        public string filePath { get; set; }= string.Empty;
        public string NamePrefix { get; set; }= string.Empty;
        public string NameSuffix { get; set; }= string.Empty;
        public string StreetAddress3 { get; set; }= string.Empty;
        public string StreetAddress4 { get; set; }= string.Empty;
        public string CityMember { get; set; }= string.Empty;

        public string State { get; set; }= string.Empty;
        public string County { get; set; }= string.Empty;
        public string Zip { get; set; }= string.Empty;
        public string Designation1 { get; set; }= string.Empty;
        public string Country { get; set; }= string.Empty;
        public string PrimaryPhone { get; set; }=string.Empty;
            public string SecondaryPhone { get; set; }= string.Empty;
        public string Ssn { get; set; }= string.Empty;
            public string OtherId { get; set; }= string.Empty;
        public string Email1 { get; set; }= string.Empty;
        public string Other { get; set; }= string.Empty;
        public string dob { get; set; } = string.Empty;
        public string Organization2 { get; set; } = string.Empty;
        public string NamePrefix2 { get; set; } = string.Empty;
        public string NameSuffix2 { get; set; } = string.Empty;
        public string StreetAddress5 { get; set; } = string.Empty;
        public string StreetAddress6 { get; set; } = string.Empty;
        public string City1 { get; set; } = string.Empty;

        public string State1 { get; set; } = string.Empty;
        public string County1 { get; set; } = string.Empty;
        public string Zip1 { get; set; } = string.Empty;
        public string Designation2 { get; set; } = string.Empty;
        public string Country1 { get; set; } = string.Empty;
        public string PrimaryPhone1 { get; set; } = string.Empty;
        public string SecondaryPhone1 { get; set; } = string.Empty;
        public string Ssn1 { get; set; } = string.Empty;
        public string OtherId1 { get; set; } = string.Empty;
        public string Email11 { get; set; } = string.Empty;
        public string Other1 { get; set; } = string.Empty;
        public string dob1 { get; set; } = string.Empty;
        public string Organization1Lawer { get; set; } = string.Empty;
        public string idLawer { get; set; } = string.Empty;
        public string NamePrefixLawer { get; set; } = string.Empty;
        public string FirstName1Lawer { get; set; } = string.Empty;
        public string MiddleName1Lawer { get; set; } = string.Empty;
        public string LastName1Lawer { get; set; } = string.Empty;
        public string NameSuffixLawer { get; set; } = string.Empty;
        public string StreetAddress3Lawer { get; set; } = string.Empty;
        public string StreetAddress4Lawer { get; set; } = string.Empty;
        public string CityLawer { get; set; } = string.Empty;
        public string StateLawer { get; set; } = string.Empty;
        public string CountyLawer { get; set; } = string.Empty;
        public string ZipLawer { get; set; } = string.Empty;
        public string Designation1Lawer { get; set; } = string.Empty;
        public string CountryLawer { get; set; } = string.Empty;
        public string dobLawer { get; set; } = string.Empty;
        public string PrimaryPhoneLawer { get; set; } = string.Empty;
        public string SecondaryPhoneLawer { get; set; } = string.Empty;
        public string SsnLawer { get; set; } = string.Empty;
        public string OtherIdLawer { get; set; } = string.Empty;
        public string Email1Lawer { get; set; } = string.Empty;
        public string OtherLawer { get; set; } = string.Empty;
        public string OrganizationProvider { get; set; } = string.Empty;
        public string namePrefixProvider { get; set; } = string.Empty;
        public string firstNameProvider { get; set; } = string.Empty;
        public string middleNameProvider { get; set; } = string.Empty;
        public string lastNameProvider { get; set; } = string.Empty;
        public string nameSuffixProvider { get; set; } = string.Empty;
        public string DesignationProvider { get; set; } = string.Empty;
        public string DOBProvider { get; set; } = string.Empty;
        public string SSNProvider { get; set; } = string.Empty;
        public string LicenseNumberProvider { get; set; } = string.Empty;
        public string IDProvider { get; set; } = string.Empty;
        public string NPIProvider { get; set; } = string.Empty;
        public string TIN_EINProvider { get; set; } = string.Empty;
        public string medicaidIDProvider { get; set; } = string.Empty;
        public string medicareIDProvider { get; set; } = string.Empty;
        public string OtherIDProvider { get; set; } = string.Empty;
        public string ProviderTypeProvider { get; set; } = string.Empty;
        public string ProviderSpecialtyProvider { get; set; } = string.Empty;
        public string TaxonomyProvider { get; set; } = string.Empty;
        public string otherProvider { get; set; } = string.Empty;
        public string address1Provider { get; set; } = string.Empty;
        public string address2Provider { get; set; } = string.Empty;
        public string cityProvider { get; set; } = string.Empty;
        public string stateProvider { get; set; } = string.Empty;
        public string countyProvider { get; set; } = string.Empty;
        public string zipCodeProvider { get; set; } = string.Empty;
        public string countryProvider { get; set; } = string.Empty;
        public string phoneNumberProvider { get; set; } = string.Empty;
        public string faxProvider { get; set; } = string.Empty;
        public string emailProvider { get; set; } = string.Empty;
        





        public string EmailAddress { get; set; } = string.Empty;
        public string Invalidemail { get; set; } = string.Empty;
        public string Emailvalidationerrormessage { get; set; } = string.Empty;

        public string Invalidzipcode { get; set; } = string.Empty;
        public string Zipcodevalidationerrormessage { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
       
        public string Zipcode { get; set; } = string.Empty;
        public string IncidentStartDate { get; set; } = string.Empty;
        public string IncidentEndDate { get; set; } = string.Empty;
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
        public string country { get; set; } = string.Empty;

        public string fax { get; set; } = string.Empty;
        public string Emailaddress { get; set; } = string.Empty;
        public string IsthereanyInvolvedPartyDropdown { get; set; } = string.Empty;
        

        public string associatedstate { get; set; } = string.Empty;
        public string Question1 { get; set; } = string.Empty;
        public string Question2 { get; set; } = string.Empty;
        public string Question3 { get; set; } = string.Empty;
        public string TestFile { get; set; } = string.Empty;
        public string Question4 { get; set; } = string.Empty;

        
        public string Question5 { get; set; } = string.Empty;
        

        
        
        



       

        public string Gender { get; set; } = string.Empty;
        public string HowWitnessOrExternalPartyReportedThis { get; set; } = string.Empty;
        public string AnyAdditionalInfo { get; set; } = string.Empty;

        public string planType { get; set; } = string.Empty;
        public string Program { get; set; } = string.Empty;
        public string LOB { get; set; } = string.Empty;
        public string Group { get; set; } = string.Empty;






    }


}