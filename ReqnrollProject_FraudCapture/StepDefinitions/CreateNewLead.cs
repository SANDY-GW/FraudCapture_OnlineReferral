using FC_OnlineReferral.FraudCapture_Pages;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead;
using FC_OnlineReferral.OnlineReferral_Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraudCapture_BDD.StepDefinitions
{
    [Binding]
    public class CreateNewLead
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
        public CreateNewLead(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [Given("when I open the Fraud Capture application")]
        public void GivenWhenIOpenTheFraudCaptureApplication()
        {
            var fc = new FraudCapture_Core(Driver);
            fc.FC_OnlineLogin();
            CommonHelpers.WaitForPageToLoad(Driver, 100);
        }
        
        [When("I enter the {string} on the welcome fraude capture page:")]
        public void WhenIEnterTheOnTheWelcomeFraudeCapturePage(string UserEmail, DataTable dataTable)
        {
            var fc = new FC_LoginPage(Driver);
            var data = dataTable.CreateInstance <FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            fc.EnterLoginUserEmail(data.UserEmail);
        }

        [When("I click on the Procced to login button on the welcome fraude capture page")]
        public void WhenIClickOnTheProccedToLoginButtonOnTheWelcomeFraudeCapturePage()
        {
            var fc = new FC_LoginPage(Driver);
            fc.ClickProceedToLogin();
        }


        [When("I click on the I Agree button on the fraud capture Page")]
        public void WhenIClickOnTheIAgreeButtonOnTheFraudCapturePage()
        {
            var fc = new FC_LoginPage(Driver);

            fc.waitForIAgreeButton();
            var homePage = new HomePage(Driver);
            homePage.AcceptDisclosure();
        }

        [When("I click on CaseTracking and select the {string} option on the fraud capture home page")]
        public void WhenIClickOnCaseTrackingAndSelectTheOptionOnTheFraudCaptureHomePage(string TabToSelect)
        {
            var navigateBtn = Driver.FindElement(By.XPath("//button[@id='navigationMenuId']"));
            navigateBtn.Click();

            var caseTrackingLink = Driver.FindElement(By.XPath("//ul[@id='menuDropdownOptions']//a[@id='Case Tracking']"));
            caseTrackingLink.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);

            var leadsTabBUtton = Driver.FindElement(By.XPath("//a[@id='allLeadsTabId']"));
            var tabToSelect = Driver.FindElement(By.XPath("//a[contains(@id,'" + TabToSelect + "')]"));
            tabToSelect.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 200);
        }
        [When("I click CreateNewLead button to go to Lead Creation Page")]
        public void WhenIClickCreateNewLeadButtonToGoToLeadCreationPage()
        {
            var fc = new CaseTracking_LeadPage(Driver);
            fc.ClickCreateNewLeadBtn();
        }
        [When("I enter initial user details in Lead Creation Tab:")]
        public void WhenIEnterInitialUserDetailsInLeadCreationTab(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectLeadWorkflowType(data.WorkflowType);
            fc.SelectDetectionMethod(data.DetectionMethod);
            fc.SelectSourceType(data.SourceType);
            fc.SelectReason(data.Reason);
            fc.SelectAssignedTo(data.AssignedTo);
        }
        [When("I Click the Next button in the first page of CreateNewLead Page")]
        public void WhenIClickTheNextButtonInTheFirstPageOfCreateNewLeadPage()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickNextBtn();
        }
        [When("I enter Subject details in Primary Subject Tab:")]
        public void WhenIEnterSubjectDetailsInPrimarySubjectTab(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectSubjectType(data.SubjectType);
            fc.SelectPrimarySubject(data.SubjectTypeSelect);
            fc.ClickManuallyAddBySubjectPrefix(data.namePrefix);
            fc.ClickManuallyAddBySubjectFirstName(data.FirstName);
            fc.ClickManuallyAddBySubjectLastName(data.LastName);
        }
        [When("I click on the Next button on the Primary Subject Page Manually add the Subject details")]
        public void WhenIClickOnTheNextButtonOnThePrimarySubjectPageManuallyAddTheSubjectDetails()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickNextBtn();
        }

        [When("I enter Subject details in Primary Subject Tab for Member ID:")]
        public void WhenIEnterSubjectDetailsInPrimarySubjectTabForMemberID(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectSubjectType(data.SubjectType);
            fc.SelectPrimarySubject(data.SubjectTypeSelect);
            fc.ClickMemberSearchByID(data.memberIdRefParty);
            
        }
        [When("I enter Subject details in Primary Subject Tab for Search By Name:")]
        public void WhenIEnterSubjectDetailsInPrimarySubjectTabForSearchByName(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectSubjectType(data.SubjectType);
            fc.SelectPrimarySubject(data.SubjectTypeSelect);
            fc.ClickMemberSearchByFirstName(data.firstName);
            fc.ClickMemberSearchByLastName(data.lastName);
        }

        [When("I click Search button from the Search By ID screen")]
        public void WhenIClickSearchButtonFromTheSearchByIDScreen()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickMemberSearchBtn();
        }
        [When("I Selecting the respective Member ID to see the Case Details")]
        public void WhenISelectingTheRespectiveMemberIDToSeeTheCaseDetails()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickMemberSelectBtn();
        }
        [When("I click Search button from the Search By Name screen")]
        public void WhenIClickSearchButtonFromTheSearchByNameScreen()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickMemberSearchByNameSearchBtn();
        }

        [When("I giving the name to see the Case Details")]
        public void WhenIGivingTheNameToSeeTheCaseDetails()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickMemberSearchByNameSelectBtn();
        }
        [When("I enter Subject details in Primary Subject Tab for Search By Address:")]
        public void WhenIEnterSubjectDetailsInPrimarySubjectTabForSearchByAddress(DataTable dataTable)
        {
          var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectSubjectType(data.SubjectType);
            fc.SelectPrimarySubject(data.SubjectTypeSelect);
            fc.ClickMemberSearchByAddressfield(data.addressField);
            fc.ClickMemberSearchByCity(data.city);
        }

        [When("I click Search button from the Search By Address screen")]
        public void WhenIClickSearchButtonFromTheSearchByAddressScreen()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickMemberSearchByAddressSearchBtn();
        }

        [When("I giving the address to see the Case Details")]
        public void WhenIGivingTheAddressToSeeTheCaseDetails()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickMemberSearchByAddressSelectBtn();
        }
        [When("I enter Subject details in Primary Subject Tab for Provider-Manually add the Subject:")]
        public void WhenIEnterSubjectDetailsInPrimarySubjectTabForProvider_ManuallyAddTheSubject(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectSubjectTypeDropDownProvider(data.subjectTypeprovider);
            fc.SelectPrimarySubjectDropDownProvider(data.subjectTypeselectprovider);
            //fc.ClickProviderOrganizationName(data.organization);
            //fc.ClickProviderID(data.providerId);
            //fc.ClickProviderFirstname(data.providerfirstName);
            //fc.ClickProviderLastname(data.providerlastName);
        }
        [When("I enter Subject details in Primary Subject Tab for Provider-Search By ID:")]
        public void WhenIEnterSubjectDetailsInPrimarySubjectTabForProvider_SearchByID(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectSubjectTypeDropDownProvider(data.subjectTypeprovider);
            fc.SelectPrimarySubjectDropDownProvider(data.subjectTypeselectprovider);
            fc.ClickProviderSearchByID(data.providerId1);
        }
        [When("I click Search button from the Search By ID screen for Provider")]
        public void WhenIClickSearchButtonFromTheSearchByIDScreenForProvider()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickProviderSearchBtn();
        }

        [When("I Selecting the respective provider ID to see the Case Details")]
        public void WhenISelectingTheRespectiveProviderIDToSeeTheCaseDetails()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickProviderSelectBtn();
        }
        [When("I enter Subject details in Primary Subject Tab for Provider-Search By TIN:")]
        public void WhenIEnterSubjectDetailsInPrimarySubjectTabForProvider_SearchByTIN(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectSubjectTypeDropDownProvider(data.subjectTypeprovider);
            fc.SelectPrimarySubjectDropDownProvider(data.subjectTypeselectprovider);
            fc.ClickProviderSearchByTIN(data.tin);
        }
        [When("I enter Subject details in Primary Subject Tab for Provider-Search By NPI:")]
        public void WhenIEnterSubjectDetailsInPrimarySubjectTabForProvider_SearchByNPI(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectSubjectTypeDropDownProvider(data.subjectTypeprovider);
            fc.SelectPrimarySubjectDropDownProvider(data.subjectTypeselectprovider);
            fc.ClickProviderSearchByNPI(data.npi);
        }
        [When("I enter Subject details in Primary Subject Tab for Provider-Search By Name:")]
        public void WhenIEnterSubjectDetailsInPrimarySubjectTabForProvider_SearchByName(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectSubjectTypeDropDownProvider(data.subjectTypeprovider);
            fc.SelectPrimarySubjectDropDownProvider(data.subjectTypeselectprovider);
            fc.ClickProviderSearchByOrganization(data.providerorganization);
        }
        [When("I enter Subject details in Primary Subject Tab for Provider-Search By Address:")]
        public void WhenIEnterSubjectDetailsInPrimarySubjectTabForProvider_SearchByAddress(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectSubjectTypeDropDownProvider(data.subjectTypeprovider);
            fc.SelectPrimarySubjectDropDownProvider(data.subjectTypeselectprovider);
            fc.ClickProviderSearchByAddress(data.provideraddressField);
            fc.ClickProviderSearchByCity(data.providercity);
        }

       
        [When("I click on the Next button on the Primary Subject Page")]
        public void WhenIClickOnTheNextButtonOnThePrimarySubjectPage()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickNextBtnforPrimarySubjectPage();
        }
        [When("I click Description tab in the Description Page")]
        public void WhenIClickDescriptionTabInTheDescriptionPage()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickDescriptionTab();
        }

        [When("I enter Description details in Description tab:")]
        public void WhenIEnterDescriptionDetailsInDescriptionTab(DataTable dataTable)
        {

            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickDescriptionField(data.Description);
        }


        [When("I click on the Next button on the Description Page")]
        public void WhenIClickOnTheNextButtonOnTheDescriptionPage()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickNextBtnforDescriptionPage();
        }

        [When("I enter Referring Party details in Referring Party tab:")]

        public void WhenIEnterReferringPartyDetailsInReferringPartyTab(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectReferringParty(data.ReferringParty);
           
            
        }
        [When("I enter Referring Party details in Referring Party tab for Search By Member ID")]
        public void WhenIEnterReferringPartyDetailsInReferringPartyTabForSearchByMemberID(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectReferringParty(data.ReferringParty);
            fc.ClickReferringPartySearchByID(data.memberIdRefParty);
        }

        [When("I click Search button in the Search By ID Window")]
        public void WhenIClickSearchButtonInTheSearchByIDWindow()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySearchBtn();
        }

        [When("I Selecting the respective Member ID for the Referring Party Screen")]
        public void WhenISelectingTheRespectiveMemberIDForTheReferringPartyScreen()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySelectBtn();
        }

        [When("I enter Referring Party details in Referring Party tab for Search By Member Name")]
        public void WhenIEnterReferringPartyDetailsInReferringPartyTabForSearchByMemberName(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectReferringParty(data.ReferringParty);
            fc.ClickReferringPartySearchByFirstname(data.Firstname);
        }

        [When("I click Search button in the Search By Name Window")]
        public void WhenIClickSearchButtonInTheSearchByNameWindow()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySearchBtnFirstname();
        }

        [When("I Selecting the respective Member Name for the Referring Party Screen")]
        public void WhenISelectingTheRespectiveMemberNameForTheReferringPartyScreen()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySelectBtnFirstname();
        }

        [When("I enter Referring Party details in Referring Party tab for Search by Provider ID:")]
        public void WhenIEnterReferringPartyDetailsInReferringPartyTabForSearchByProviderID(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectReferringParty(data.ReferringParty);
            fc.ClickReferringPartySearchByProviderID(data.providerId);
        }
        [When("I click Search button in the Search By Provider ID Window")]
        public void WhenIClickSearchButtonInTheSearchByProviderIDWindow()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySearchBtnProviderID();
        }

        [When("I Selecting the respective Provider ID for the Referring Party Screen")]
        public void WhenISelectingTheRespectiveProviderIDForTheReferringPartyScreen()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySelectBtnProviderID();
        }
        [When("I enter Referring Party details in Referring Party tab for Search by Provider Name:")]
        public void WhenIEnterReferringPartyDetailsInReferringPartyTabForSearchByProviderName(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectReferringParty(data.ReferringParty);
            fc.ClickReferringPartySearchByProviderName(data.providerName);
        }

        [When("I click Search button in the Search By Provider Name Window")]
        public void WhenIClickSearchButtonInTheSearchByProviderNameWindow()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySearchBtnProviderName();
        }
        [When("I Selecting the respective Provider Name for the Referring Party Screen")]
        public void WhenISelectingTheRespectiveProviderNameForTheReferringPartyScreen()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySelectBtnProviderName();
        }
        [When("I enter Referring Party details in Referring Party tab for Search By NPI:")]
        public void WhenIEnterReferringPartyDetailsInReferringPartyTabForSearchByNPI(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectReferringParty(data.ReferringParty);
            fc.ClickReferringPartySearchByProviderNPI(data.providerNPI);
        }

        [When("I click Search button in the Search By Provider NPI Window")]
        public void WhenIClickSearchButtonInTheSearchByProviderNPIWindow()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySearchBtnProviderNPI();
        }

        [When("I Selecting the respective Provider NPI for the Referring Party Screen")]
        public void WhenISelectingTheRespectiveProviderNPIForTheReferringPartyScreen()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySelectBtnProviderNPI();
        }
        [When("I enter Referring Party details in Referring Party tab for Search By TIN:")]
        public void WhenIEnterReferringPartyDetailsInReferringPartyTabForSearchByTIN(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureCreateNewLead>();
            var fc = new CreateNewLeadPage(Driver);
            fc.SelectReferringParty(data.ReferringParty);
            fc.ClickReferringPartySearchByProviderTIN(data.providerTIN);
        }

        [When("I click Search button in the Search By Provider TIN Window")]
        public void WhenIClickSearchButtonInTheSearchByProviderTINWindow()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySearchBtnProviderTIN();
        }

        [When("I Selecting the respective Provider TIN for the Referring Party Screen")]
        public void WhenISelectingTheRespectiveProviderTINForTheReferringPartyScreen()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickReferringPartySelectBtnProviderTIN();
        }


        [When("I click on the Next button on the Referring Party Page")]
        public void WhenIClickOnTheNextButtonOnTheReferringPartyPage()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickNextBtnforReferringPartyPage();
        }

        [When("I click Prioritization and click Create New Lead button in the Prioritization Page")]
        public void WhenIClickPrioritizationAndClickCreateNewLeadButtonInThePrioritizationPage()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickCreateLeadBtninPrioritizationTab();
        }



       










    }
}
