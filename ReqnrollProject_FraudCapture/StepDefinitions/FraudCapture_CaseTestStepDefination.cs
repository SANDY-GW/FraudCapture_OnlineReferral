using FC_OnlineReferral.FraudCapture_Pages;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Case;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.CaseSubjects;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraudCapture_BDD.StepDefinitions
{
    [Binding]
    public class FraudCapture_CaseTestStepDefination
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));

        public FraudCapture_CaseTestStepDefination(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("I filter Assigned To Dropdown")]
        public void WhenIFilterAssignedToDropdownWith(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            Driver.FindElement(By.Id("dropdownLeadListUser")).Click();
            Driver.FindElement(By.XPath($"//ul[@id='leadListAssignedTo']//a[normalize-space()='{data.AssignedToFilter}']")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }


        [When("I filter Assigned To Case Dropdown")]
        public void WhenIFilterAssignedToCaseDropdownWith(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            Driver.FindElement(By.Id("dropdownCaseListUser")).Click();
            Driver.FindElement(By.XPath($"//ul[@id='caseListAssignedTo']//a[normalize-space()='{data.AssignedToFilter}']")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }

        [When("I search for leadID under Select Criteria dropdown")]
        public void WhenISearchForUnderSelectCriteriaDropdown(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var select = new SelectElement(Driver.FindElement(By.Id("leadSearchCriteria")));
            select.SelectByText(data.LeadTableSearchOptions);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }

        [When("I search for caseID under Select Criteria dropdown")]
        public void WhenISearchCaseForUnderSelectCriteriaDropdown(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var select = new SelectElement(Driver.FindElement(By.Id("caseSearchCriteria")));
            select.SelectByText(data.CaseTableSearchOptions);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }


        [When("I search for Lead ID")]
        public void WhenISearchForLeadIDAs(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            CommonHelpers.WaitForElementVisiblity(Driver, By.XPath("//form[@id='LeadSearchForm']/descendant::input[@id='searchInputField']"), 20);
            var input = Driver.FindElement(By.XPath("//form[@id='LeadSearchForm']/descendant::input[@id='searchInputField']"));
            input.SendKeys(data.LeadID);
        }

        [When("I search for Case ID")]
        public void WhenISearchForCaseIDAs(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            CommonHelpers.WaitForElementVisiblity(Driver, By.XPath("//form[@id='CaseSearchForm']/descendant::input[@id='searchInputField']"), 20);
            var input = Driver.FindElement(By.XPath("//form[@id='CaseSearchForm']/descendant::input[@id='searchInputField']"));
            input.Clear();
            input.SendKeys(data.CaseID);
        }
        [When("I search for Lead ID Created")]
        public void WhenISearchForLeadID()
        {
            
            CommonHelpers.WaitForElementVisiblity(Driver, By.XPath("//form[@id='LeadSearchForm']/descendant::input[@id='searchInputField']"), 20);
            var input = Driver.FindElement(By.XPath("//form[@id='LeadSearchForm']/descendant::input[@id='searchInputField']"));
            string capturedLeadId = _scenarioContext["CapturedLeadId"] as string;
            input.Clear();
            input.SendKeys(capturedLeadId);
        }
        [When("I click on Case search button")]
        public void WhenIClickOnSearchButton()
        {
            CommonHelpers.WaitForElementClickable(Driver, By.XPath("//form[@id='CaseSearchForm']/descendant::button[@id='searchStartButton']"), 20);
            Driver.FindElement(By.XPath("//form[@id='CaseSearchForm']/descendant::button[@id='searchStartButton']")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }

        [When("I click on Lead search button")]
        public void WhenIClickOnLeadSearchButton()
        {
            CommonHelpers.WaitForElementClickable(Driver, By.XPath("//form[@id='LeadSearchForm']/descendant::button[@id='searchStartButton']"), 20);
            Driver.FindElement(By.XPath("//form[@id='LeadSearchForm']/descendant::button[@id='searchStartButton']")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }


        [When("I click on the Lead ID Link")]
        public void WhenIClickOnTheLeadIDLink()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadIDLinkbyRow(1);
        }
        [When("I click on the Case ID Link")]
        public void WhenIClickOnTheCaseIDLink()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickCaseIDLinkbyRow(1);
        }

        [When("I click on the Begin Editing on the fraud capture Lead detials Page")]
        public void WhenIClickOnTheBeginEditingOnTheFraudCaptureLeadDetialsPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.BeginEditingLead();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        [When("I click on the Begin Editing on the fraud capture Case detials Page")]
        public void WhenIClickOnTheBeginEditingOnTheFraudCaptureCaseDetialsPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.BeginEditingCase();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        [When("I verify the Lead ID link is opened")]
        public void WhenIVerifyTheLeadIDLinkIsOpened()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            string leadId = _scenarioContext["CapturedLeadId"] as string;
            var leadIdElement = Driver.FindElement(By.XPath($"//div[@id='leadcomponent']//h1[contains(.,'{leadId}')]"));
            if (leadIdElement.Displayed)
            {
                _scenarioContext["VerifiedLeadId"] = leadId;
            }

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        [When("I verify the given Lead ID link is opened")]
        public void WhenIVerifyTheGivenLeadIDLinkIsOpened(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            var leadIdElement = Driver.FindElement(By.XPath($"//div[@id='leadcomponent']//h1[contains(.,'{data.LeadID}')]"));
            if (leadIdElement.Displayed)
            {
                _scenarioContext["VerifiedLeadId"] = data.LeadID;
            }

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }
        //[When("I click on Begin Editing button")]
        //public void WhenIClickOnBeginEditingButton()
        //{
        //    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        //    var BeginEditingButton = Driver.FindElement(By.XPath("//div[@id='leadcomponent']/descendant::button[@id='leadViewEditEndButton']"));


        //    try
        //    {
        //        if (BeginEditingButton.Displayed)
        //        {
        //            BeginEditingButton.Click();
        //            CommonHelpers.WaitForPageLoading(Driver);
        //        }
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        //already in Edit mode, move along
        //    }
        //}


        [When("I store all lead summary dropdown values")]
        public void WhenIStoreAllLeadSummaryDropdownValues()
        {
            var leadSummary = new LeadSummary(Driver);
            var leadData = leadSummary.GetAllLeadSummaryData();
            _scenarioContext["LeadSummaryData"] = leadData;

            // Log all values for reference
            foreach (var kvp in leadData)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        [When("I change the Lead Status dropdown")]
        public void WhenIChangeTheLeadStatusDropdownTo(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var leadStatusElement = Driver.FindElement(By.XPath("//select[@name='lead statusid']"));
            var select = new SelectElement(leadStatusElement);
            select.SelectByText(data.LeadStatus);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }

        [When("I validate Status Change and Case Creation popup is displayed")]
        public void WhenIValidateStatusChangeAndCaseCreationPopupIsDisplayed()
        {
            try
            {
                CommonHelpers.WaitForElementVisiblity(Driver,
                    By.XPath("//div[contains(@class,'darkNavy-fc title1') and contains(normalize-space(),'Status Change & Case Creation')]"),
                    20);
                var popup = Driver.FindElement(By.XPath("//div[contains(@class,'darkNavy-fc title1') and contains(normalize-space(),'Status Change & Case Creation')]"));
                if (popup.Displayed)
                {
                    _scenarioContext["PopupDisplayed"] = true;
                }
            }
            catch
            {
                _scenarioContext["PopupDisplayed"] = false;
            }
        }

        [When("I select a case Workflow Type on the create case popup")]
        public void WhenISelectACaseWorkflowTypeOnTheCreateCasePopup(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            var caseSummary = new CaseSummary(Driver);
            caseSummary.SelectFirstWorkflowType(data.CaseWorkflowType);
        }

        [When("I select the primary Case Reason on the create case popup")]
        public void WhenISelectThePrimaryCaseReasonOnTheCreateCasePopup(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var caseSummary = new CaseSummary(Driver);
            caseSummary.SelectFirstCaseReason(data.CaseReason);
        }

        [When("I select Assign workflow To on the create case popup")]
        public void WhenISelectAssignWorkflowToOnTheCreateCasePopup(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var caseSummary = new CaseSummary(Driver);
            caseSummary.SelectFirstAssignWorkflowTo(data.AssignWorkflowTo);
        }

        [When("I select assign a Supervisor on the create case popup")]
        public void WhenISelectAssignASupervisorOnTheCreateCasePopup(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var caseSummary = new CaseSummary(Driver);
            caseSummary.SelectFirstAssignSupervisor(data.AssignSupervisor);
        }

        [When("I select a Department or Division on the create case popup")]
        public void WhenISelectADepartmentOrDivisionOnTheCreateCasePopup(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var caseSummary = new CaseSummary(Driver);
            caseSummary.SelectFirstDepartmentOrDivision(data.Depart_OR_Div);
        }

        [When("I select a Section or Team on the create case popup")]
        public void WhenISelectASectionOrTeamOnTheCreateCasePopup(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var caseSummary = new CaseSummary(Driver);
            caseSummary.SelectFirstSectionOrTeam(data.Section_OR_Team);
        }

        [When("I click create case button on the create case popup")]
        public void WhenIClickCreateCaseButtonOnTheCreateCasePopup()
        {
            var caseSummary = new CaseSummary(Driver);
            caseSummary.ClickCreateCaseButton();
        }

        [Then("I validate the created case is linked to the same lead id")]
        public void ThenIValidateTheCreatedCaseIsLinkedToTheSameLeadId()
        {
            var caseSummary = new CaseSummary(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            string leadId = _scenarioContext["CapturedLeadId"] as string;
            string caseId = caseSummary.GetCaseID();
            Assert.That(caseId, Is.Not.Null.And.Not.Empty, "Created case id was not displayed.");
            Assert.That(caseId, Is.EqualTo(leadId), "Associated Lead id on the created case did not match the selected Lead id.");
        }
        [Then("I validate the created case is linked to the same lead id entered")]
        public void ThenIValidateTheCreatedCaseIsLinkedToTheSameLeadIdEntered(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var caseSummary = new CaseSummary(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);

            string caseId = caseSummary.GetCaseID();
            Assert.That(caseId, Is.Not.Null.And.Not.Empty, "Created case id was not displayed.");
            Assert.That(caseId, Is.EqualTo(data.LeadID), "Associated Lead id on the created case did not match the selected Lead id.");
        }
        [Then("I validate the case workflow type matches {string}")]
        public void ThenIValidateTheCaseWorkflowTypeMatches(string workflowType)
        {
            var caseSummary = new CaseSummary(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);

            string actualCaseType = caseSummary.GetCaseType();
            Console.WriteLine($"Actual Case Type: {actualCaseType}");
            Console.WriteLine($"Expected Case Type: {workflowType}");
            Assert.That(actualCaseType, Is.EqualTo(workflowType).IgnoreCase, "Created case type/workflow type did not match the selected workflow type.");
        }


        [When("I update case summary with alternate case id,case type, case status, assigned to, assigned supervisor, department_Or_division, section_Or_team, and lob")]
            public void WhenIUpdateCaseSummaryWithAlternateCaseIDCaseTypeCaseStatusAssignedToAssignedSupervisorDepartmentDivisionSectionTeamAndLob(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>(); 
            var caseSummary = new CaseSummary(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);

            caseSummary.alertCaseID(data.ALT_Case_ID);
            caseSummary.SelectCaseType(data.CaseType);
            caseSummary.SelectCaseStatus(data.CaseStatus);
            caseSummary.SelectAssignedToDropdown(data.AssignedCaseTo);
            caseSummary.SelectAssignedSupervisorDropdown(data.AssignedCaseSupervisor);
            caseSummary.SelectDepartmentOrDivisionDropdown(data.CaseDep_OR_Dev);
            caseSummary.SelectSectionOrTeamsDropdown(data.CaseSection_Or_Team);
            caseSummary.SelectLineOfBusiness(data.lob);

            _scenarioContext["ExpectedAlternateCaseId"] = data.ALT_Case_ID;
            _scenarioContext["ExpectedCaseType"] = data.CaseType;
            _scenarioContext["ExpectedCaseStatus"] = data.CaseStatus;
            _scenarioContext["ExpectedAssignedTo"] = data.AssignedCaseTo;
            _scenarioContext["ExpectedAssignedSupervisor"] = data.AssignedCaseSupervisor;
            _scenarioContext["ExpectedDepartmentDivision"] = data.CaseDep_OR_Dev;
            _scenarioContext["ExpectedSectionTeam"] = data.CaseSection_Or_Team  ;
            _scenarioContext["ExpectedLob"] = data.lob;
        }

        [When("I remove all the added values alternate case id,case type, case status, section_Or_team, and lob")]
        public void WhenIRemoveAllTheAddedValuesAlternateCaseIDCaseTypeCaseStatusSectionTeamAndLob(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var caseSummary = new CaseSummary(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);

            caseSummary.RemoveAlternativeCaseID(data.ReassignALT_CaseID);
            caseSummary.SelectCaseType(data.ReassignCaseType);
            caseSummary.SelectCaseStatus(data.ReassigncaseStatus);

            caseSummary.SelectSectionOrTeamsDropdown(data.Reassign_Section_OR_Team);
            caseSummary.UnSelectLOB(data.Uncheck_LOB);
            caseSummary.ClickSaveButton();
        }



        [When("I click on Save Button on case summary page")]
        public void WhenIClickOnSaveButtonOnCaseSummaryPage()
        {
            var caseSummary = new CaseSummary(Driver);
            caseSummary.ClickSaveButton();
        }

        [Then("I validate case summary changes are saved")]
        public void ThenIValidateCaseSummaryChangesAreSaved()
        {
            var caseSummary = new CaseSummary(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);

            var expectedAlternateCaseId = _scenarioContext["ExpectedAlternateCaseId"] as string;
            var expectedCaseType = _scenarioContext["ExpectedCaseType"] as string;
            var expectedCaseStatus = _scenarioContext["ExpectedCaseStatus"] as string;
            var expectedAssignedTo = _scenarioContext["ExpectedAssignedTo"] as string;
            var expectedAssignedSupervisor = _scenarioContext["ExpectedAssignedSupervisor"] as string;
            var expectedDepartmentDivision = _scenarioContext["ExpectedDepartmentDivision"] as string;
            var expectedSectionTeam = _scenarioContext["ExpectedSectionTeam"] as string;
            var expectedLob = _scenarioContext["ExpectedLob"] as string;

            Assert.That(caseSummary.GetAlternateCaseID().Contains(expectedAlternateCaseId), "Alternate Case ID was not updated.");
         
            Assert.That(caseSummary.GetCaseType(), Is.EqualTo(expectedCaseType), "Case Type was not updated.");
            Assert.That(caseSummary.GetCaseStatus(), Is.EqualTo(expectedCaseStatus), "Case Status was not updated.");
            Assert.That(caseSummary.GetAssignedToDropdownValue(), Does.Contain(expectedAssignedTo), "Assigned To was not updated.");
            Assert.That(caseSummary.GetAssignedSupervisorDropdownValue(), Does.Contain(expectedAssignedSupervisor), "Assigned Supervisor was not updated.");
            Assert.That(caseSummary.GetDepartmentOrDivisionDropdownValue(), Does.Contain(expectedDepartmentDivision), "Department/Division was not updated.");
            Assert.That(caseSummary.GetSectionOrTeamsDropdownValue(), Does.Contain(expectedSectionTeam), "Section/Team was not updated.");
            Assert.That(caseSummary.IsLineOfBusinessChecked(expectedLob), Is.True, "Requested LOB is not selected.");
            caseSummary.ClickSaveButton();
        }

        [When("I click on Close the Lead & Create a Case button")]
        public void WhenIClickOnButton(DataTable dataTable)
        {
            var data =dataTable.CreateInstance<FC_CaseSummary.Data.CaseSummaryData>();
            var buttonLocator = By.XPath($"//button[contains(normalize-space(),'{data.CloseLeadCreateCaseButton}')]");
            CommonHelpers.WaitForElementVisiblity(Driver, buttonLocator, 20);
            Driver.FindElement(buttonLocator).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        [Then(@"the lead with captured ID should be displayed in the search results")]
        public void ThenTheLeadWithCapturedIDShouldBeDisplayedInTheSearchResults()
        {
            string capturedLeadId = _scenarioContext["CapturedLeadId"] as string;
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);

        }

        [When("navigate to Subjects Tab")]
        public void WhenNavigateToSubjectsTab()
        {
            AddSubject addsubject = new AddSubject(Driver);
            addsubject.ClickOnSubjectsTab();
        }

        [When("Manually add Subject Type as {string}, select option as {string} and enter the subject details in the manually add subject page: org name as {string}, subject id as {string}, first name as {string}, last name as {string}")]
        public void WhenManuallyAddSubjectTypeAsSelectOptionAsAndEnterTheSubjectDetailsInTheManuallyAddSubjectPageOrgNameAsSubjectIdAsFirstNameAsLastNameAs(string provider, string p1, string testOrg, string p3, string john, string doe)
        {
            AddSubject addsubject = new AddSubject(Driver);
            addsubject.ManuallyAddSubjectDetails(provider, p1, testOrg, p3, john, doe);
           

        }

        [Then("validate newly added subject {string} {string} is present in the subject table")]
        public void ThenValidateNewlyAddedSubjectIsPresentInTheSubjectTable(string firstName, string lastName)
        {
            AddSubject addsubject = new AddSubject(Driver);
            bool isPresent = addsubject.IsSubjectPresentInList(firstName, lastName);
            Assert.That(isPresent, Is.True, $"Subject {firstName} {lastName} was not found in the subject table.");
        }

        [Then("I validate the subject {string} {string} is present and delete it if already present")]
        public void ThenIValidateTheSubjectIsPresentAndDeleteItIfAlreadyPresent(string firstName, string lastName)
        {
            AddSubject addsubject = new AddSubject(Driver);
            bool wasPresentAndDeleted = addsubject.DeleteSubjectIfAlreadyPresent(firstName, lastName);
            _scenarioContext["SubjectWasPresentAndDeleted"] = wasPresentAndDeleted;
        }

    }
}
