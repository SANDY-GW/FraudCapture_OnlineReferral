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

        //Search By ID Search Elements for Member
        private readonly By SearchByIDSelectionDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        private readonly By MemberSearchByID = By.XPath("//input[@id='searchIdCase']");
        private readonly By MemberSearchBtn = By.XPath("//button[@id='btnSearch']");
        private readonly By MemberClearBtn= By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        private readonly By MemberSelectBtn = By.XPath("(//button[@id='SelectSbjectResultBtn'])[1]");

        //Search By Name Search Elements for Member
        private readonly By SearchByNameSelectionDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        private readonly By MemberSearchByFirstName = By.XPath("//input[@id='searchFname']");
        private readonly By MemberSearchByLastName = By.XPath("//input[@id='searchLname']");
        private readonly By MemberSearchByNameSearchBtn = By.XPath("//button[@id='btnSearch']");
        private readonly By MemberSearchByNameSearchClearBtn = By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        private readonly By MemberSearchByNameSelectBtn = By.XPath("(//button[@id='SelectSbjectResultBtn'])[1]");

        //Search By Address Elements for Member-5615 High Point Dr
        private readonly By SearchByAddressSelectionDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        private readonly By MemberSearchByAddressfield = By.XPath("//input[@id='searchAddress']");
        private readonly By MemberSearchByCity = By.XPath("//input[@id='searchCity']");
        private readonly By MemberSearchByAddressSearchBtn = By.XPath("//button[@id='btnSearch']");
        private readonly By MemberSearchByAddressSearchClearBtn = By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        private readonly By MemberSearchByAddressSelectBtn = By.XPath("(//button[@id='SelectSbjectResultBtn'])[1]");

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
        private readonly By ProviderSearchByAddressSelectBtn = By.XPath("(//button[@id='SelectSbjectResultBtn'])[1]");

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

        // getting the leadID
        private readonly By leadIdField = By.XPath("//input[@id='leadId']");
        #endregion
        public void SelectLeadWorkflowType(string workflowType)
        {
            
            CommonHelpers.WaitForElementVisiblity(driver, LeadWorkflowTypeDropDown, 120);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(LeadWorkflowTypeDropDown).Click();
            CommonHelpers.selectOptionByValue(driver.FindElement(LeadWorkflowTypeDropDown), workflowType);
        }
        public void SelectDetectionMethod(string detectionMethod)
        {
            
            driver.FindElement(DetectionMethodDropDown);
            CommonHelpers.selectOptionByValue(driver.FindElement(DetectionMethodDropDown), detectionMethod);

        }
        public void SelectSourceType(string sourceType)
        {
            
            driver.FindElement(SourceTypeDropDown);
            CommonHelpers.selectOptionByValue(driver.FindElement(SourceTypeDropDown), sourceType);
        }
        public void SelectReason(string reason)
        {
            
            driver.FindElement(ReasonDropDown);
            CommonHelpers.selectOptionByValue(driver.FindElement(ReasonDropDown), reason);
        }
        public void SelectAssignedTo(string assignedTo)
        {
           
            driver.FindElement(AssignedToDropDown);
            CommonHelpers.selectOptionByValue(driver.FindElement(AssignedToDropDown), assignedTo);
        }
        public void ClickNextBtn()
        {
            driver.FindElement(NextBtn).Click();
        }
        public void SelectSubjectType(string subjectType)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(SubjectTypeDropDown), subjectType);
        }
        // Renamed to avoid name collision with the PrimarySubjectDropDown field (method group -> By conversion error)
        public void SelectPrimarySubject(string subjectTypeselect)
        {
            CommonHelpers.WaitForElementVisiblity(driver, PrimarySubjectDropDown, 120);
            CommonHelpers.selectOptionByValue(driver.FindElement(PrimarySubjectDropDown), subjectTypeselect);
        }
        public void ClickManuallyAddBySubjectPrefix(string namePrefix)
        {
            driver.FindElement(ManuallyAddBySubjectPrefix).SendKeys(namePrefix);
        }
        public void ClickManuallyAddBySubjectFirstName(string firstName)
        {
            driver.FindElement(ManuallyAddBySubjectFirstName).SendKeys(firstName);
        }
        public void ClickManuallyAddBySubjectLastName(string lastName)
        {
            driver.FindElement(ManuallyAddBySubjectLastName).SendKeys(lastName);
        }
        //Search By ID for Member
        public void ClickSearchByIDSelectionDropDown(string searchByIdOption)
        {
            CommonHelpers.WaitForElementVisiblity(driver, SearchByIDSelectionDropDown, 120);
            CommonHelpers.selectOptionByValue(driver.FindElement(SearchByIDSelectionDropDown), searchByIdOption);
        }
        public void ClickMemberSearchByID(string memberId)
        {
            driver.FindElement(MemberSearchByID).SendKeys(memberId);
        }
        public void ClickMemberSearchBtn()
        {
            
            driver.FindElement(MemberSearchBtn).Click();
        }
        public void ClickMemberClearBtn()
        {
            driver.FindElement(MemberClearBtn).Click();
        }
        public void ClickMemberSelectBtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(MemberSelectBtn).Click();
        }
        //Search By Name for Member
        public void ClickSearchByNameSelectionDropDown(string searchByNameOption)
        {
            CommonHelpers.WaitForElementVisiblity(driver, SearchByNameSelectionDropDown, 120);
            CommonHelpers.selectOptionByValue(driver.FindElement(SearchByNameSelectionDropDown), searchByNameOption);
        }
        public void ClickMemberSearchByFirstName(string firstName)
        {
            driver.FindElement(MemberSearchByFirstName).SendKeys(firstName);
        }
        public void ClickMemberSearchByLastName(string lastName)
        {
            driver.FindElement(MemberSearchByLastName).SendKeys(lastName);
        }
        public void ClickMemberSearchByNameSearchBtn()
        {
            driver.FindElement(MemberSearchByNameSearchBtn).Click();
        }
        public void ClickMemberSearchByNameSearchClearBtn()
        {
            driver.FindElement(MemberSearchByNameSearchClearBtn).Click();
        }
        public void ClickMemberSearchByNameSelectBtn()
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120); 
            driver.FindElement(MemberSearchByNameSelectBtn).Click();
        }
        //Search By Address for Member
        public void ClickSearchByAddressSelectionDropDown(string searchByAddressOption)
        {
            CommonHelpers.WaitForElementVisiblity(driver, SearchByAddressSelectionDropDown, 120);
            CommonHelpers.selectOptionByValue(driver.FindElement(SearchByAddressSelectionDropDown), searchByAddressOption);
        }
        
        public void ClickMemberSearchByAddressfield(string addressField)
        {
            driver.FindElement(MemberSearchByAddressfield).SendKeys(addressField);
        }
        public void ClickMemberSearchByCity(string city)
        {
            driver.FindElement(MemberSearchByCity).SendKeys(city);
        }
        public void ClickMemberSearchByAddressSearchBtn()
        {
            driver.FindElement(MemberSearchByAddressSearchBtn).Click();
        }
        public void ClickMemberSearchByAddressClearBtn()
        {
            driver.FindElement(MemberSearchByAddressSearchClearBtn).Click();
        }
        public void ClickMemberSearchByAddressSelectBtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(MemberSearchByAddressSelectBtn).Click();
        }
        //Provider-Manually Add Subject
        
        public void SelectSubjectTypeDropDownProvider(string subjectTypeprovider)
        {
            //CommonHelpers.WaitForElementVisiblity(Driver, SubjectTypeDropDownProvider, 120);
            CommonHelpers.selectOptionByValue(driver.FindElement(SubjectTypeDropDownProvider), subjectTypeprovider);
        }
        public void SelectPrimarySubjectDropDownProvider(string subjectTypeselectprovider)
        {
            CommonHelpers.WaitForElementVisiblity(driver, PrimarySubjectDropDownProvider, 120);
            CommonHelpers.selectOptionByValue(driver.FindElement(PrimarySubjectDropDownProvider), subjectTypeselectprovider);
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
            driver.FindElement(ProviderSearchByID).SendKeys(providerId1);
        }
        public void ClickProviderSearchBtn()
        {
            driver.FindElement(ProviderSearchBtn).Click();
        }
        public void ClickProviderClearBtn()
        {
            driver.FindElement(ProviderClearBtn).Click();
        }
        public void ClickProviderSelectBtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(ProviderSelectBtn).Click();
        }
        //Search By TIN/EIN for Provider
        public void ClickProviderSearchByTIN(string tin)
        {
            driver.FindElement(ProviderSearchByTIN).SendKeys(tin);
        }
        public void ClickProviderSearchBtnforTIN()
        {
            driver.FindElement(ProviderSearchBtnforTIN).Click();
        }
        public void ClickProviderClearBtnforTIN()
        {
            driver.FindElement(ProviderClearBtnforTIN).Click();
        }
        public void ClickProviderSelectBtnforTIN()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(ProviderSelectBtnforTIN).Click();
        }
        //Search By NPI for Provider
        public void ClickProviderSearchByNPI(string npi)
        {
            driver.FindElement(ProviderSearchByNPI).SendKeys(npi);
        }
        public void ClickProviderSearchBtnforNPI()
        {
            driver.FindElement(ProviderSearchBtnforNPI).Click();
        }
        public void ClickProviderClearBtnforNPI()
        {
            driver.FindElement(ProviderClearBtnforNPI).Click();
        }
        public void ClickProviderSelectBtnforNPI()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(ProviderSelectBtnforNPI).Click();
        }
        //Search By Organization for Provider
        public void ClickProviderSearchByOrganization(string organization)
        {
            driver.FindElement(ProviderSearchByOrganization).SendKeys(organization);
        }
        public void ClickProviderSelectBtnforName()
        {
            driver.FindElement(ProviderSelectBtnforName).Click();
        }
        //Search By Address for Provider
        public void ClickProviderSearchByAddress(string provideraddressField)
        {
            driver.FindElement(ProviderSearchByAddress).SendKeys(provideraddressField);
        }
        public void ClickProviderSearchByCity(string providercity)
        {
            driver.FindElement(ProviderSearchByCity).SendKeys(providercity);
        }
        public void ClickProviderSearchByAddressSelectBtn()
        {
            driver.FindElement(ProviderSearchByAddressSelectBtn).Click();
        }
        
        public void ClickNextBtnforPrimarySubjectPage()
        {
            driver.FindElement(NextBtnforPrimarySubjectPage).Click();
        }
        //Description Tab
        public void ClickDescriptionTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(DescriptionTab).Click();
        }
        public void ClickDescriptionField(string description)
        {
            CommonHelpers.WaitForElementVisiblity(driver, DescriptionField, 120);
            var DescriptionTextArea = driver.FindElement(DescriptionField);
            DescriptionTextArea.Click();
            DescriptionTextArea.SendKeys(description);
            

        }
        public void ClickNextBtnforDescriptionPage()
        {
            driver.FindElement(NextBtnforDescriptionPage).Click();
            
        }
        //Referring Party
        public void SelectReferringParty(string referringParty)
        {
            driver.FindElement(ReferringPartyDropDown);
            CommonHelpers.selectOptionByValue(driver.FindElement(ReferringPartyDropDown), referringParty);
            

        }
        public void ClickReferringPartySearchByID(string memberIdRefParty)
        {
            driver.FindElement(ReferringPartySearchByID).SendKeys(memberIdRefParty);
        }
        public void ClickReferringPartySearchBtn()
        {
            driver.FindElement(ReferringPartySearchBtn).Click();
        }
        public void ClickReferringPartyClearBtn()
        {
            driver.FindElement(ReferringPartyClearBtn).Click();
        }
        public void ClickReferringPartySelectBtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(ReferringPartySelectBtn).Click();
        }
        public void ClickReferringPartySearchByFirstname(string Firstname)
        {
            driver.FindElement(ReferringPartySearchByFirstname).SendKeys(Firstname);
        }
        public void ClickReferringPartySearchBtnFirstname()
        {
            driver.FindElement(ReferringPartySearchBtnFirstname).Click();
        }
        public void ClickReferringPartyClearBtnFirstname()
        {
            driver.FindElement(ReferringPartyClearBtnFirstname).Click();
        }
        public void ClickReferringPartySelectBtnFirstname()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(ReferringPartySelectBtnFirstname).Click();
        }
        public void ClickReferringPartySearchByProviderID(string providerId)
        {
            driver.FindElement(ReferringPartySearchByProviderID).SendKeys(providerId);
        }
        public void ClickReferringPartySearchBtnProviderID()
        {
            driver.FindElement(ReferringPartySearchBtnProviderID).Click();
        }
        public void ClickReferringPartyClearBtnProviderID()
        {
            driver.FindElement(ReferringPartyClearBtnProviderID).Click();
        }
        public void ClickReferringPartySelectBtnProviderID()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(ReferringPartySelectBtnProviderID).Click();
        }
        public void ClickReferringPartySearchByProviderTIN(string providerTIN)
        {
            driver.FindElement(ReferringPartySearchByProviderTIN).SendKeys(providerTIN);
        }
        public void ClickReferringPartySearchBtnProviderTIN()
        {
            driver.FindElement(ReferringPartySearchBtnProviderTIN).Click();
        }
        public void ClickReferringPartyClearBtnProviderTIN()
        {
            driver.FindElement(ReferringPartyClearBtnProviderTIN).Click();
        }
        public void ClickReferringPartySelectBtnProviderTIN()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(ReferringPartySelectBtnProviderTIN).Click();
        }
        public void ClickReferringPartySearchByProviderName(string providerName)
        {
            driver.FindElement(ReferringPartySearchByProviderName).SendKeys(providerName);
        }
        public void ClickReferringPartySearchBtnProviderName()
        {
            driver.FindElement(ReferringPartySearchBtnProviderName).Click();
        }
        public void ClickReferringPartyClearBtnProviderName()
        {
            driver.FindElement(ReferringPartyClearBtnProviderName).Click();
        }
        public void ClickReferringPartySelectBtnProviderName()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(ReferringPartySelectBtnProviderName).Click();
        }
        public void ClickSelectBtnforReferringPartyByName()
        {
            driver.FindElement(ReferringPartySelectBtnFirstname).Click();
        }
        
        public void ClickClearBtnforReferringParty()
        {
            driver.FindElement(ReferringPartyClearBtn).Click();
        }
        public void ClickSearchBtnforReferringParty()
        {
            driver.FindElement(ReferringPartySearchBtn).Click();
        }
        public void ClickSearchByIDforReferringParty(string memberId)
        {
            driver.FindElement(ReferringPartySearchByID).SendKeys(memberId);
        }
        public void ClickReferringPartySearchByProviderNPI(string providerNPI)
        {
            driver.FindElement(ReferringPartySearchByProviderNPI).SendKeys(providerNPI);
        }
        public void ClickReferringPartySearchBtnProviderNPI()
        {
            driver.FindElement(ReferringPartySearchBtnProviderNPI).Click();
        }
        public void ClickReferringPartyClearBtnProviderNPI()
        {
            driver.FindElement(ReferringPartyClearBtnProviderNPI).Click();
        }
        public void ClickReferringPartySelectBtnProviderNPI()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);
            driver.FindElement(ReferringPartySelectBtnProviderNPI).Click();
        }
        

        public void ClickNextBtnforReferringPartyPage()
        {
            driver.FindElement(NextBtnforReferringPartyPage).Click();
            


        }
        public void ClickCreateLeadBtninPrioritizationTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(CreateLeadBtninPrioritizationTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
        }
        public string CaptureleadID()
        {
            try
            {
                CommonHelpers.WaitForElementVisiblity(driver, leadIdField, 30);
                string capturedLeadId = driver.FindElement(leadIdField).GetAttribute("value")?.Trim();
                Console.WriteLine("Captured Lead ID: " + capturedLeadId);
                return capturedLeadId;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Lead ID field not found: " + ex.Message);
                return null;
            }
        }


    }



    }
