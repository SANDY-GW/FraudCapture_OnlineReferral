using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab
{
    public class CreateNewLeadPage : BaseSettings
    {
        public CreateNewLeadPage(IWebDriver driver) : base(driver) { }

        #region Elements
        
        private readonly By LeadWorkflowTypeDropDown = By.XPath("//select[@id='leadCaseType']");
        private readonly By DetectionMethodDropDown = By.XPath("//select[@id='leadDetection']");
        private readonly By SourceTypeDropDown = By.XPath("//select[@id='leadSource']");
        private readonly By ReasonDropDown = By.XPath("//select[@id='leadReason']");
        private readonly By AssignedToDropDown = By.XPath("//select[@id='leadAssignedTo']");
        private readonly By NextBtn = By.XPath("//button[@id='next']");
        
        private readonly By NextBtnforPrimarySubjectPage = By.XPath("//button[@id='next']");
        private readonly By DescriptionTab = By.XPath("//a[@id='descriptionTabId']");
        private readonly By DescriptionField = By.XPath("//div[@class='fr-element fr-view fr-element-scroll-visible']/p");
        private readonly By NextBtnforDescriptionPage = By.XPath("//button[@id='next']");
        private readonly By ReferringPartyDropDown = By.XPath("//select[@id='referringPartyVal']");
        private readonly By NextBtnforReferringPartyPage = By.XPath("//button[@id='next']");
        private readonly By CreateLeadBtninPrioritizationTab = By.XPath("//button[@id='createLeadBtninPrioritizationTab']");
        //Member-Manually add the subject
        private readonly By SubjectTypeDropDown = By.XPath("//select[@id='subjectTypeVal']");
        private readonly By PrimarySubjectDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        private readonly By ManuallyAddBySubjectPrefix = By.XPath("//input[@id='ViewSubjectNamePrefix']");
        private readonly By ManuallyAddBySubjectFirstName = By.XPath("//input[@id='ViewSubjectFirstName']");
        private readonly By ManuallyAddBySubjectLastName = By.XPath("//input[@id='ViewSubjectLastName']");
        private readonly By ManuallyAddBySubjectMiddleName = By.XPath("//input[@id='ViewSubjectMiddleName']");
        private readonly By ManuallyAddBySubjectSuffix = By.XPath("//input[@id='ViewSubjectSuffix']");
        private readonly By ManuallyAddBySubjectDateofBirth = By.XPath("//input[@name='ViewSubjectDateofBirth']");
        private readonly By ManuallyAddBySubjectGender = By.XPath("//input[@id='ViewSubjectGender']");
        private readonly By ManuallyAddBySubjectOther = By.XPath("//input[@id='ViewSubjectOther']");
        private readonly By ManuallyAddBySubjectId = By.XPath("//input[@id='ViewSubjectId']");
        private readonly By ManuallyAddBySubjectSSN = By.XPath("//input[@id='ViewSubjectSSN']");
        private readonly By ManuallyAddBySubjectMedicaidNo = By.XPath("//input[@id='SubjectMedicaidNo']");
        private readonly By ManuallyAddBySubjectMedicareNo = By.XPath("//input[@id='SubjectMedicareNo']");
        private readonly By ManuallyAddBySubjectOtherId = By.XPath("//input[@id='ViewSubjectOtherId']");
        private readonly By ManuallyAddBySubjectplan = By.XPath("//input[@id='ViewSubjectplan']");
        private readonly By ManuallyAddBySubjectprogram = By.XPath("//input[@id='ViewSubjectprogram']");
        private readonly By ManuallyAddBySubjectLob = By.XPath("//input[@id='ViewSubjectLob']");
        private readonly By ManuallyAddBySubjectGroup = By.XPath("//input[@id='ViewSubjectGroup']");
        private readonly By ManuallyAddBySubjectAddress1 = By.XPath("//input[@id='ViewSubjectAddress1']");
        private readonly By ManuallyAddBySubjectAddress2 = By.XPath("//input[@id='ViewSubjectAddress2']");
        private readonly By ManuallyAddBySubjectCity = By.XPath("//input[@id='ViewSubjectCity']");
        private readonly By ManuallyAddBySubjectState = By.XPath("//select[@id='ViewSubjectState']");
        private readonly By ManuallyAddBySubjectCounty = By.XPath("//select[@id='ViewSubjectCounty']");
        private readonly By ManuallyAddBySubjectZipCode = By.XPath("//input[@id='ViewSubjectZipCode']");
        private readonly By ManuallyAddByViewSubjectPhone = By.XPath("//input[@id='ViewSubjectPhone']");
        private readonly By ManuallyAddBySecondaryPhone = By.XPath("//input[@id='SecondaryPhone']");
        private readonly By ManuallyAddBySubjectEmail = By.XPath("//input[@id='ProviderViewSubjectEmail']");
        

        //Search By ID Search Elements for Member
        private readonly By SearchByIDSelectionDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        private readonly By MemberSearchByID = By.XPath("//input[@id='searchIdCase']");
        private readonly By MemberSearchBtn = By.XPath("//button[@id='btnSearch']");
        private readonly By MemberClearBtn= By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        private readonly By MemberSelectBtn = By.XPath("//button[@id='SelectSbjectResultBtn']");

        //Search By Name Search Elements for Member
        private readonly By SearchByNameSelectionDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        private readonly By MemberSearchByFirstName = By.XPath("//input[@id='searchFname']");
        private readonly By MemberSearchByLastName = By.XPath("//input[@id='searchLname']");
        private readonly By MemberSearchByNameSearchBtn = By.XPath("//button[@id='btnSearch']");
        private readonly By MemberSearchByNameSearchClearBtn = By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        private readonly By MemberSearchByNameSelectBtn = By.XPath("//div//button[@id='SelectSbjectResultBtn']");

        //Search By Address Elements for Member-5615 High Point Dr
        private readonly By SearchByAddressSelectionDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        private readonly By MemberSearchByAddressfield = By.XPath("//input[@id='searchAddress']");
        private readonly By MemberSearchByCity = By.XPath("//input[@id='searchCity']");
        private readonly By MemberSearchByAddressSearchBtn = By.XPath("//button[@id='btnSearch']");
        private readonly By MemberSearchByAddressSearchClearBtn = By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        private readonly By MemberSearchByAddressSelectBtn = By.XPath("//div//button[@id='SelectSbjectResultBtn']");

        //Provider-Manually add the subject 
        private readonly By SubjectTypeDropDownProvider = By.XPath("//select[@id='subjectTypeVal']");
        private readonly By PrimarySubjectDropDownProvider = By.XPath("//select[@id='subjectTypeSelection']");
        private readonly By ProviderOrganizationName = By.XPath("//input[@id='ReferralOrganizationName']");
        //private readonly By ProviderID = By.XPath("//input[@id='ViewSubjectId']");
        //private readonly By ProviderFirstname = By.XPath("//input[@id='ViewSubjectFirstName']");
        //private readonly By ProviderLastname = By.XPath("//input[@id='ViewSubjectLastName']");


        //Search By ID to Search Elements for Provider-10006
        private readonly By ProviderSearchByID = By.XPath("//input[@id='searchIdCase']");
        private readonly By ProviderSearchBtn = By.XPath("//button[@id='btnSearch']");
        private readonly By ProviderClearBtn = By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        private readonly By ProviderSelectBtn = By.XPath("//button[@id='SelectSbjectResultBtn']");

        //Search By TIN/EIN to Elements for Provider-66602459
        private readonly By ProviderSearchByTIN = By.XPath("//input[@id='searchIdCase']");
        private readonly By ProviderSearchBtnforTIN = By.XPath("//button[@id='btnSearch']");
        private readonly By ProviderClearBtnforTIN = By.XPath("(//button[text()='Clear'])[5]");
        private readonly By ProviderSelectBtnforTIN = By.XPath("//button[@id='SelectSbjectResultBtn']");

        //Search By NPI to Elements for Provider-9999004811
        private readonly By ProviderSearchByNPI = By.XPath("//input[@id='searchIdCase']");
        private readonly By ProviderSearchBtnforNPI = By.XPath("//button[@id='btnSearch']");
        private readonly By ProviderClearBtnforNPI = By.XPath("(//button[text()='Clear'])[5]");
        private readonly By ProviderSelectBtnforNPI = By.XPath("//button[@id='SelectSbjectResultBtn']");

        //Search By Name Organization to Elements for Provider-PR13163
        private readonly By ProviderSearchByOrganization = By.XPath("//input[@id='searchOrgName']");
        private readonly By ProviderSelectBtnforName = By.XPath("//button[@id='SelectSbjectResultBtn']");

        //Search By Address to Elements for Provider-5615 High Point Dr
        private readonly By ProviderSearchByAddress = By.XPath("//input[@id='searchAddress']");
        private readonly By ProviderSearchByCity = By.XPath("//input[@id='searchCity']");
        private readonly By ProviderSearchByAddressSelectBtn = By.XPath("//div//button[@id='SelectSbjectResultBtn']");

        //Referring Party-Search By Member ID to Search Elements for Referring Party
        private readonly By ReferringPartySearchByID = By.XPath("//input[@name='searchIdCase']");
        private readonly By ReferringPartySearchBtn = By.XPath("//button[@id='btnSearch']");
        private readonly By ReferringPartyClearBtn = By.XPath("//button[text()='Clear Search Fields']");
        private readonly By ReferringPartySelectBtn = By.XPath("//button[@id='btnAddReferral']");

        //Referring Party-Search By Name to Search Elements for Referring Party-FN33480
        private readonly By ReferringPartySearchByFirstname = By.XPath("//input[@id='searchFname']");
        private readonly By ReferringPartySearchBtnFirstname= By.XPath("//button[@id='btnSearch']");
        private readonly By ReferringPartyClearBtnFirstname = By.XPath("//button[text()='Clear Search Fields']");
        private readonly By ReferringPartySelectBtnFirstname = By.XPath("//button[@id='btnAddReferral']");

        //Referring Party-Search By Provider ID to Search Elements for Referring Party-10006
        private readonly By ReferringPartySearchByProviderID = By.XPath("//input[@id='searchByMemberId']");
        private readonly By ReferringPartySearchBtnProviderID = By.XPath("//button[@id='btnSearch']");
        private readonly By ReferringPartyClearBtnProviderID = By.XPath("//button[text()='Clear Search Fields']");
        private readonly By ReferringPartySelectBtnProviderID = By.XPath("//button[@id='btnAddReferral']");

        //Referring Party-Search By Provider TIN to Search Elements for Referring Party-66602459
        private readonly By ReferringPartySearchByProviderTIN = By.XPath("//input[@id='searchTinEinCase']");
        private readonly By ReferringPartySearchBtnProviderTIN = By.XPath("//button[@id='btnSearch']");
        private readonly By ReferringPartyClearBtnProviderTIN = By.XPath("//button[text()='Clear Search Fields']");
        private readonly By ReferringPartySelectBtnProviderTIN = By.XPath("//button[@id='btnAddReferral']");

        //Referring Party-Search By Provider NPI to Search Elements for Referring Party-9999004811
        private readonly By ReferringPartySearchByProviderNPI = By.XPath("//input[@id='searchNpiCase']");
        private readonly By ReferringPartySearchBtnProviderNPI = By.XPath("//button[@id='btnSearch']");
        private readonly By ReferringPartyClearBtnProviderNPI = By.XPath("//button[text()='Clear Search Fields']");
        private readonly By ReferringPartySelectBtnProviderNPI = By.XPath("//button[@id='btnAddReferral']");

        //Referring Party-Search By Provider Name to Search Elements for Referring Party-PR13163
        private readonly By ReferringPartySearchByProviderName = By.XPath("//input[@id='searchOrgName']");
        private readonly By ReferringPartySearchBtnProviderName = By.XPath("//button[@id='btnSearch']");
        private readonly By ReferringPartyClearBtnProviderName = By.XPath("//button[text()='Clear Search Fields']");
        private readonly By ReferringPartySelectBtnProviderName = By.XPath("//button[@id='btnAddReferral']");
        #endregion
        public void SelectLeadWorkflowType(string workflowType)
        {
            
            CommonHelpers.WaitForElementVisiblity(Driver, LeadWorkflowTypeDropDown, 120);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(LeadWorkflowTypeDropDown).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(LeadWorkflowTypeDropDown), workflowType);
        }
        public void SelectDetectionMethod(string detectionMethod)
        {
            
            Driver.FindElement(DetectionMethodDropDown);
            CommonHelpers.selectOptionByValue(Driver.FindElement(DetectionMethodDropDown), detectionMethod);

        }
        public void SelectSourceType(string sourceType)
        {
            
            Driver.FindElement(SourceTypeDropDown);
            CommonHelpers.selectOptionByValue(Driver.FindElement(SourceTypeDropDown), sourceType);
        }
        public void SelectReason(string reason)
        {
            
            Driver.FindElement(ReasonDropDown);
            CommonHelpers.selectOptionByValue(Driver.FindElement(ReasonDropDown), reason);
        }
        public void SelectAssignedTo(string assignedTo)
        {
           
            Driver.FindElement(AssignedToDropDown);
            CommonHelpers.selectOptionByValue(Driver.FindElement(AssignedToDropDown), assignedTo);
        }
        public void ClickNextBtn()
        {
            Driver.FindElement(NextBtn).Click();
        }
        public void SelectSubjectType(string subjectType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(SubjectTypeDropDown), subjectType);
        }
        // Renamed to avoid name collision with the PrimarySubjectDropDown field (method group -> By conversion error)
        public void SelectPrimarySubject(string subjectTypeselect)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, PrimarySubjectDropDown, 120);
            CommonHelpers.selectOptionByValue(Driver.FindElement(PrimarySubjectDropDown), subjectTypeselect);
        }
        public void ClickManuallyAddBySubjectPrefix(string namePrefix)
        {
            Driver.FindElement(ManuallyAddBySubjectPrefix).SendKeys(namePrefix);
        }
        public void ClickManuallyAddBySubjectFirstName(string firstName)
        {
            Driver.FindElement(ManuallyAddBySubjectFirstName).SendKeys(firstName);
        }
        public void ClickManuallyAddBySubjectLastName(string lastName)
        {
            Driver.FindElement(ManuallyAddBySubjectLastName).SendKeys(lastName);
        }
        public void ClickManuallyAddBySubjectMiddleName(string middleName)
        {
            Driver.FindElement(ManuallyAddBySubjectMiddleName).SendKeys(middleName);
        }
        public void ClickManuallyAddBySubjectSuffix(string suffix)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectSuffix);
            Driver.FindElement(ManuallyAddBySubjectSuffix).SendKeys(suffix);
        }
        public void ClickManuallyAddBySubjectDateofBirth(string dateOfBirth)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectDateofBirth);
            Driver.FindElement(ManuallyAddBySubjectDateofBirth).Click();
            Driver.FindElement(ManuallyAddBySubjectDateofBirth).SendKeys(dateOfBirth);
        }
        public void ClickManuallyAddBySubjectGender(string gender)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectGender);
            Driver.FindElement(ManuallyAddBySubjectGender).SendKeys(gender);
        }
        public void ClickManuallyAddBySubjectOther(string other)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectOther);  
            Driver.FindElement(ManuallyAddBySubjectOther).SendKeys(other);
        }
        public void ClickManuallyAddBySubjectId(string subjectId)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectId);
            Driver.FindElement(ManuallyAddBySubjectId).SendKeys(subjectId);
        }
        public void ClickManuallyAddBySubjectSSN(string ssn)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectSSN);
            Driver.FindElement(ManuallyAddBySubjectSSN).SendKeys(ssn);
        }
        public void ClickManuallyAddBySubjectMedicaidNo(string medicaidNo)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectMedicaidNo);
            Driver.FindElement(ManuallyAddBySubjectMedicaidNo).SendKeys(medicaidNo);
        }
        public void ClickManuallyAddBySubjectMedicareNo(string medicareNo)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectMedicareNo);
            Driver.FindElement(ManuallyAddBySubjectMedicareNo).SendKeys(medicareNo);
        }
        public void ClickManuallyAddBySubjectOtherId(string OtherId)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectOtherId);
            Driver.FindElement(ManuallyAddBySubjectOtherId).SendKeys(OtherId);
        }
        public void ClickManuallyAddBySubjectplan(string plan)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectplan);
            Driver.FindElement(ManuallyAddBySubjectplan).SendKeys(plan);

        }
        public void ClickManuallyAddBySubjectprogram(string program)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectprogram);
            Driver.FindElement(ManuallyAddBySubjectprogram).SendKeys(program);

        }
        public void ClickManuallyAddBySubjectLob(string Lob)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectLob);
            Driver.FindElement(ManuallyAddBySubjectLob).SendKeys(Lob);

        }
        public void ClickManuallyAddBySubjectGroup(string Group)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectGroup);
            Driver.FindElement(ManuallyAddBySubjectGroup).SendKeys(Group);

        }
        public void ClickManuallyAddBySubjectAddress1(string Address1)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectAddress1);
            Driver.FindElement(ManuallyAddBySubjectAddress1).SendKeys(Address1);

        }
        public void ClickManuallyAddBySubjectAddress2(string Address2)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectAddress2);
            Driver.FindElement(ManuallyAddBySubjectAddress2).SendKeys(Address2);

        }
        
        public void ClickManuallyAddBySubjectCity(string City )
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectCity);
            Driver.FindElement(ManuallyAddBySubjectCity).SendKeys(City);

        }
        public void SelectManuallyAddBySubjectState(string State)
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.selectOptionByValue(Driver.FindElement(ManuallyAddBySubjectState), State);
        }
        public void SelectManuallyAddBySubjectCounty(string County)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.selectOptionByValue(Driver.FindElement(ManuallyAddBySubjectCounty), County);

        }
        public void ClickManuallyAddBySubjectZipCode(string ZipCode)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectZipCode);
            Driver.FindElement(ManuallyAddBySubjectZipCode).SendKeys(ZipCode);

        }
        public void ClickManuallyAddByViewSubjectPhone(string Phone)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddByViewSubjectPhone);
            Driver.FindElement(ManuallyAddByViewSubjectPhone).SendKeys(Phone);

        }
        public void ClickManuallyAddBySecondaryPhone(string SecondaryPhone)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySecondaryPhone);
            Driver.FindElement(ManuallyAddBySecondaryPhone).SendKeys(SecondaryPhone);

        }
        public void ClickManuallyAddBySubjectEmail(string Email)
        {
            CommonHelpers.ScrollToElement(Driver, ManuallyAddBySubjectEmail);
            Driver.FindElement(ManuallyAddBySubjectEmail).SendKeys(Email);

        }

        //Search By ID for Member
        public void ClickSearchByIDSelectionDropDown(string searchByIdOption)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, SearchByIDSelectionDropDown, 120);
            CommonHelpers.selectOptionByValue(Driver.FindElement(SearchByIDSelectionDropDown), searchByIdOption);
        }
        public void ClickMemberSearchByID(string memberId)
        {
            Driver.FindElement(MemberSearchByID).SendKeys(memberId);
        }
        public void ClickMemberSearchBtn()
        {
            
            Driver.FindElement(MemberSearchBtn).Click();
        }
        public void ClickMemberClearBtn()
        {
            Driver.FindElement(MemberClearBtn).Click();
        }
        public void ClickMemberSelectBtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(MemberSelectBtn).Click();
        }
        //Search By Name for Member
        public void ClickSearchByNameSelectionDropDown(string searchByNameOption)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, SearchByNameSelectionDropDown, 120);
            CommonHelpers.selectOptionByValue(Driver.FindElement(SearchByNameSelectionDropDown), searchByNameOption);
        }
        public void ClickMemberSearchByFirstName(string firstName)
        {
            Driver.FindElement(MemberSearchByFirstName).SendKeys(firstName);
        }
        public void ClickMemberSearchByLastName(string lastName)
        {
            Driver.FindElement(MemberSearchByLastName).SendKeys(lastName);
        }
        public void ClickMemberSearchByNameSearchBtn()
        {
            Driver.FindElement(MemberSearchByNameSearchBtn).Click();
        }
        public void ClickMemberSearchByNameSearchClearBtn()
        {
            Driver.FindElement(MemberSearchByNameSearchClearBtn).Click();
        }
        public void ClickMemberSearchByNameSelectBtn()
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120); 
            Driver.FindElement(MemberSearchByNameSelectBtn).Click();
        }
        //Search By Address for Member
        public void ClickSearchByAddressSelectionDropDown(string searchByAddressOption)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, SearchByAddressSelectionDropDown, 120);
            CommonHelpers.selectOptionByValue(Driver.FindElement(SearchByAddressSelectionDropDown), searchByAddressOption);
        }
        
        public void ClickMemberSearchByAddressfield(string addressField)
        {
            Driver.FindElement(MemberSearchByAddressfield).SendKeys(addressField);
        }
        public void ClickMemberSearchByCity(string city)
        {
            Driver.FindElement(MemberSearchByCity).SendKeys(city);
        }
        public void ClickMemberSearchByAddressSearchBtn()
        {
            Driver.FindElement(MemberSearchByAddressSearchBtn).Click();
        }
        public void ClickMemberSearchByAddressClearBtn()
        {
            Driver.FindElement(MemberSearchByAddressSearchClearBtn).Click();
        }
        public void ClickMemberSearchByAddressSelectBtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(MemberSearchByAddressSelectBtn).Click();
        }
        //Provider-Manually Add Subject
        
        public void SelectSubjectTypeDropDownProvider(string subjectTypeprovider)
        {
            //CommonHelpers.WaitForElementVisiblity(Driver, SubjectTypeDropDownProvider, 120);
            CommonHelpers.selectOptionByValue(Driver.FindElement(SubjectTypeDropDownProvider), subjectTypeprovider);
        }
        public void SelectPrimarySubjectDropDownProvider(string subjectTypeselectprovider)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, PrimarySubjectDropDownProvider, 120);
            CommonHelpers.selectOptionByValue(Driver.FindElement(PrimarySubjectDropDownProvider), subjectTypeselectprovider);
        }
        //public void ClickProviderOrganizationName(string organization)
        //{
        //    Driver.FindElement(ProviderOrganizationName).SendKeys(organization);
        //}
        ////public void ClickProviderID(string providerId)
        //{
        //    Driver.FindElement(ProviderID).SendKeys(providerId);
        //}
        //public void ClickProviderFirstname(string providerfirstName)
        //{
        //    Driver.FindElement(ProviderFirstname).SendKeys(providerfirstName);
        //}
        //public void ClickProviderLastname(string providerlastName)
        //{
        //    Driver.FindElement(ProviderLastname).SendKeys(providerlastName);
        //}
        //Search By ID for Provider
       
        
        public void ClickProviderSearchByID(string providerId1)
        {
            Driver.FindElement(ProviderSearchByID).SendKeys(providerId1);
        }
        public void ClickProviderSearchBtn()
        {
            Driver.FindElement(ProviderSearchBtn).Click();
        }
        public void ClickProviderClearBtn()
        {
            Driver.FindElement(ProviderClearBtn).Click();
        }
        public void ClickProviderSelectBtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(ProviderSelectBtn).Click();
        }
        //Search By TIN/EIN for Provider
        public void ClickProviderSearchByTIN(string tin)
        {
            Driver.FindElement(ProviderSearchByTIN).SendKeys(tin);
        }
        public void ClickProviderSearchBtnforTIN()
        {
            Driver.FindElement(ProviderSearchBtnforTIN).Click();
        }
        public void ClickProviderClearBtnforTIN()
        {
            Driver.FindElement(ProviderClearBtnforTIN).Click();
        }
        public void ClickProviderSelectBtnforTIN()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(ProviderSelectBtnforTIN).Click();
        }
        //Search By NPI for Provider
        public void ClickProviderSearchByNPI(string npi)
        {
            Driver.FindElement(ProviderSearchByNPI).SendKeys(npi);
        }
        public void ClickProviderSearchBtnforNPI()
        {
            Driver.FindElement(ProviderSearchBtnforNPI).Click();
        }
        public void ClickProviderClearBtnforNPI()
        {
            Driver.FindElement(ProviderClearBtnforNPI).Click();
        }
        public void ClickProviderSelectBtnforNPI()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(ProviderSelectBtnforNPI).Click();
        }
        //Search By Organization for Provider
        public void ClickProviderSearchByOrganization(string organization)
        {
            Driver.FindElement(ProviderSearchByOrganization).SendKeys(organization);
        }
        public void ClickProviderSelectBtnforName()
        {
            Driver.FindElement(ProviderSelectBtnforName).Click();
        }
        //Search By Address for Provider
        public void ClickProviderSearchByAddress(string provideraddressField)
        {
            Driver.FindElement(ProviderSearchByAddress).SendKeys(provideraddressField);
        }
        public void ClickProviderSearchByCity(string providercity)
        {
            Driver.FindElement(ProviderSearchByCity).SendKeys(providercity);
        }
        public void ClickProviderSearchByAddressSelectBtn()
        {
            Driver.FindElement(ProviderSearchByAddressSelectBtn).Click();
        }
        
        public void ClickNextBtnforPrimarySubjectPage()
        {
            Driver.FindElement(NextBtnforPrimarySubjectPage).Click();
        }
        //Description Tab
        public void ClickDescriptionTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(DescriptionTab).Click();
        }
        public void ClickDescriptionField(string description)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, DescriptionField, 120);
            var DescriptionTextArea = Driver.FindElement(DescriptionField);
            DescriptionTextArea.Click();
            DescriptionTextArea.SendKeys(description);
            

        }
        public void ClickNextBtnforDescriptionPage()
        {
            Driver.FindElement(NextBtnforDescriptionPage).Click();
            
        }
        //Referring Party
        public void SelectReferringParty(string referringParty)
        {
            Driver.FindElement(ReferringPartyDropDown);
            CommonHelpers.selectOptionByValue(Driver.FindElement(ReferringPartyDropDown), referringParty);
            

        }
        public void ClickReferringPartySearchByID(string memberIdRefParty)
        {
            Driver.FindElement(ReferringPartySearchByID).SendKeys(memberIdRefParty);
        }
        public void ClickReferringPartySearchBtn()
        {
            Driver.FindElement(ReferringPartySearchBtn).Click();
        }
        public void ClickReferringPartyClearBtn()
        {
            Driver.FindElement(ReferringPartyClearBtn).Click();
        }
        public void ClickReferringPartySelectBtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(ReferringPartySelectBtn).Click();
        }
        public void ClickReferringPartySearchByFirstname(string Firstname)
        {
            Driver.FindElement(ReferringPartySearchByFirstname).SendKeys(Firstname);
        }
        public void ClickReferringPartySearchBtnFirstname()
        {
            Driver.FindElement(ReferringPartySearchBtnFirstname).Click();
        }
        public void ClickReferringPartyClearBtnFirstname()
        {
            Driver.FindElement(ReferringPartyClearBtnFirstname).Click();
        }
        public void ClickReferringPartySelectBtnFirstname()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(ReferringPartySelectBtnFirstname).Click();
        }
        public void ClickReferringPartySearchByProviderID(string providerId)
        {
            Driver.FindElement(ReferringPartySearchByProviderID).SendKeys(providerId);
        }
        public void ClickReferringPartySearchBtnProviderID()
        {
            Driver.FindElement(ReferringPartySearchBtnProviderID).Click();
        }
        public void ClickReferringPartyClearBtnProviderID()
        {
            Driver.FindElement(ReferringPartyClearBtnProviderID).Click();
        }
        public void ClickReferringPartySelectBtnProviderID()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(ReferringPartySelectBtnProviderID).Click();
        }
        public void ClickReferringPartySearchByProviderTIN(string providerTIN)
        {
            Driver.FindElement(ReferringPartySearchByProviderTIN).SendKeys(providerTIN);
        }
        public void ClickReferringPartySearchBtnProviderTIN()
        {
            Driver.FindElement(ReferringPartySearchBtnProviderTIN).Click();
        }
        public void ClickReferringPartyClearBtnProviderTIN()
        {
            Driver.FindElement(ReferringPartyClearBtnProviderTIN).Click();
        }
        public void ClickReferringPartySelectBtnProviderTIN()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(ReferringPartySelectBtnProviderTIN).Click();
        }
        public void ClickReferringPartySearchByProviderName(string providerName)
        {
            Driver.FindElement(ReferringPartySearchByProviderName).SendKeys(providerName);
        }
        public void ClickReferringPartySearchBtnProviderName()
        {
            Driver.FindElement(ReferringPartySearchBtnProviderName).Click();
        }
        public void ClickReferringPartyClearBtnProviderName()
        {
            Driver.FindElement(ReferringPartyClearBtnProviderName).Click();
        }
        public void ClickReferringPartySelectBtnProviderName()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(ReferringPartySelectBtnProviderName).Click();
        }
        public void ClickSelectBtnforReferringPartyByName()
        {
            Driver.FindElement(ReferringPartySelectBtnFirstname).Click();
        }
        
        public void ClickClearBtnforReferringParty()
        {
            Driver.FindElement(ReferringPartyClearBtn).Click();
        }
        public void ClickSearchBtnforReferringParty()
        {
            Driver.FindElement(ReferringPartySearchBtn).Click();
        }
        public void ClickSearchByIDforReferringParty(string memberId)
        {
            Driver.FindElement(ReferringPartySearchByID).SendKeys(memberId);
        }
        public void ClickReferringPartySearchByProviderNPI(string providerNPI)
        {
            Driver.FindElement(ReferringPartySearchByProviderNPI).SendKeys(providerNPI);
        }
        public void ClickReferringPartySearchBtnProviderNPI()
        {
            Driver.FindElement(ReferringPartySearchBtnProviderNPI).Click();
        }
        public void ClickReferringPartyClearBtnProviderNPI()
        {
            Driver.FindElement(ReferringPartyClearBtnProviderNPI).Click();
        }
        public void ClickReferringPartySelectBtnProviderNPI()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 120);
            Driver.FindElement(ReferringPartySelectBtnProviderNPI).Click();
        }
        

        public void ClickNextBtnforReferringPartyPage()
        {
            Driver.FindElement(NextBtnforReferringPartyPage).Click();
            


        }
        public void ClickCreateLeadBtninPrioritizationTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            Driver.FindElement(CreateLeadBtninPrioritizationTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 200);
        }

    }



    }
