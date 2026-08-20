using FC_OnlineReferral.Data;
using FC_OnlineReferral.Data.CaseTrackingData.Data;
using FC_OnlineReferral.FraudCapture_Pages;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead;
using FC_OnlineReferral.OnlineReferral_Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FraudCapture_BDD.StepDefinitions
{
    [Binding]
    public class CaseEditStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
        
        private readonly CaseEditPage caseEditPage;
        private readonly CaseTrackingPage caseTrackingPage;
        private readonly CaseTrackingData caseTrackingData;

        public CaseEditStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            caseEditPage = new CaseEditPage(Driver);
            caseTrackingPage = new CaseTrackingPage(Driver);
            caseTrackingData = new CaseTrackingData();
        }


        #region Given Steps - Setup and Preconditions

        /// <summary>
        /// Step: Given the user navigates to the Case Tracking page
        /// </summary>
        [Given("the user navigates to the Case Tracking page")]
        public void GivenTheUserNavigatesToTheCaseTrackingPage()
        {
            caseTrackingPage.GoTo();
        }

        /// <summary>
        /// Step: Given the user shows cases
        /// </summary>
        [Given("the user shows cases")]
        public void GivenTheUserShowsCases()
        {
            caseTrackingPage.ShowCases();
        }

        /// <summary>
        /// Step: Given the user switches to user {user}
        /// </summary>
        [Given("the user switches to user \"(.*)\"")]
        public void GivenTheUserSwitchesToUser(string user)
        {
            string userData;
            if (user == "User_1")
                userData = caseTrackingData.User_1;
            else
                userData = caseTrackingData.User_1;

            caseTrackingPage.SwitchCasesUser(userData);
        }

        #endregion

        #region When Steps - Actions

        /// <summary>
        /// Step: When the user searches by Case ID
        /// </summary>
        [When("the user searches by Case ID")]
        public void WhenTheUserSearchesByCaseID()
        {
            caseTrackingPage.SearchByCaseID();
        }

        /// <summary>
        /// Step: When the user searches for case {caseId} on all cases grid
        /// </summary>
        [When("the user searches for case \"(.*)\" on all cases grid")]
        public void WhenTheUserSearchesForCaseOnAllCasesGrid(string caseId)
        {
            string caseIdData;
            if (caseId == "Case_2")
                caseIdData = caseTrackingData.CaseId_2;
            else if (caseId == "Case_3")
                caseIdData = caseTrackingData.CaseId_3;
            else
                caseIdData = caseTrackingData.CaseId_2;

            caseTrackingPage.SearchOnAllCasesGrid(caseIdData);
            _scenarioContext["CurrentCaseId"] = caseIdData;
        }

        /// <summary>
        /// Step: When the user selects case {caseId}
        /// </summary>
        [When("the user selects case \"(.*)\"")]
        public void WhenTheUserSelectsCase(string caseId)
        {
            string caseIdData;
            if (caseId == "Case_2")
                caseIdData = caseTrackingData.CaseId_2;
            else if (caseId == "Case_3")
                caseIdData = caseTrackingData.CaseId_3;
            else
                caseIdData = caseTrackingData.CaseId_2;

            caseTrackingPage.SelectCase(caseIdData, caseEditPage);
        }

        /// <summary>
        /// Step: When the user shows activities
        /// </summary>
        [When("the user shows activities")]
        public void WhenTheUserShowsActivities()
        {
            caseEditPage.ShowActivities();
        }

        /// <summary>
        /// Step: When the user adds activity with title {activityTitle} and assigned to {assignedTo}
        /// </summary>
        [When("the user adds activity with title and assigned to")]
        public void WhenTheUserAddsActivityWithTitleAndAssignedTo(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var title = data.InvestigativeCaseActivityManual_Title;
            var assignee = data.ActivityAssignedTo;
            caseEditPage.AddActivity(title, assignee);
            _scenarioContext["ActivityTitle"] = title;
        }

        /// <summary>
        /// Step: When the user sorts activities by created date column
        /// </summary>
        [When("the user sorts activities by created date column")]
        public void WhenTheUserSortsActivitiesByCreatedDateColumn()
        {
            caseEditPage.sortActivitesCreatedDateColumn();
        }

        /// <summary>
        /// Step: When the user selects the first activity
        /// </summary>
        [When("the user selects the first activity")]
        public void WhenTheUserSelectsTheFirstActivity()
        {
            caseEditPage.SelectFirstActivity();
        }

        /// <summary>
        /// Step: When the user adds a new attachment
        /// </summary>
        [When("the user adds a new attachment")]
        public void WhenTheUserAddsANewAttachment()
        {
            caseEditPage.AddNewAttachment();
        }

        /// <summary>
        /// Step: When the user adds a new note with text {noteText}
        /// </summary>
        [When("the user adds a new note with text")]
        public void WhenTheUserAddsANewNoteWithText(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var note = data.CaseActivityManual_Title;
            caseEditPage.AddNewNote(note);
            _scenarioContext["NoteText"] = note;
        }

        /// <summary>
        /// Step: When the user downloads from activity level download attachment manager
        /// </summary>
        [When("the user downloads from activity level download attachment manager")]
        public void WhenTheUserDownloadsFromActivityLevelDownloadAttachmentManager()
        {
            caseEditPage.DownloadFromActivityLevelDownloadAttachmentManager();
        }

        /// <summary>
        /// Step: When the user closes the activity
        /// </summary>
        [When("the user closes the activity")]
        public void WhenTheUserClosesTheActivity()
        {
            caseEditPage.CloseActivity();
        }

        /// <summary>
        /// Step: When the user downloads from case level download attachment manager
        /// </summary>
        [When("the user downloads from case level download attachment manager")]
        public void WhenTheUserDownloadsFromCaseLevelDownloadAttachmentManager()
        {
            caseEditPage.DownloadFromCaseLevelDownloadAttachmentManager();
        }

        /// <summary>
        /// Step: When the user clicks claims button
        /// </summary>
        [When("the user clicks claims button")]
        public void WhenTheUserClicksClaimsButton()
        {
            caseEditPage.clickClaimsButton();
        }

        /// <summary>
        /// Step: When the user clicks case claim tab
        /// </summary>
        [When("the user clicks case claim tab")]
        public void WhenTheUserClicksCaseClaimTab()
        {
            caseEditPage.clickCaseClaimTab();
        }

        /// <summary>
        /// Step: When the user searches by case claim number {claimNumber} with value {claimValue}
        /// </summary>
        [When("the user searches by case claim number with value")]
        public void WhenTheUserSearchesByCaseClaimNumberWithValue(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var claimNum = caseTrackingData.ClaimDropdownValue;
            var claimVal = caseTrackingData.claimvalue1;
            caseEditPage.SearchByCaseId(claimNum, claimVal);
        }

        /// <summary>
        /// Step: When the user hovers over attachment and notes column
        /// </summary>
        [When("the user hovers over attachment and notes column")]
        public void WhenTheUserHoversOverAttachmentAndNotesColumn()
        {
            caseEditPage.HoveingOverAttachmentAndNotesColumn();
        }

        /// <summary>
        /// Step: When the user deletes the note
        /// </summary>
        [When("the user deletes the note")]
        public void WhenTheUserDeletesTheNote()
        {
            caseEditPage.DeleteNote();
        }

        /// <summary>
        /// Step: When the user begins editing case
        /// </summary>
        [When("the user begins editing case")]
        public void WhenTheUserBeginsEditingCase()
        {
            caseEditPage.BeginEditingCase();
        }

        /// <summary>
        /// Step: When the user clicks findings tab
        /// </summary>
        [When("the user clicks findings tab")]
        public void WhenTheUserClicksFindingsTab()
        {
            caseEditPage.clickFindingsTab();
        }

        /// <summary>
        /// Step: When the user adds findings with the following details
        /// </summary>
        [When("the user adds findings with the following details:")]
        public void WhenTheUserAddsFindingsWithTheFollowingDetails(DataTable table)
        {
            var data =table.CreateInstance<CaseTrackingData>();
            caseEditPage.addFindingsButtonAndCreateTheForm(
                data.FindingSubject,
                data.FindingReason,
                data.LineOfBusiness,
                data.UnderpaymentAmount,
                data.OverpaymentAmount,
                data.SoftSavingAmount,
                data.MembersCount,
                data.ClaimsCount,
                data.LinesCount,
                data.ProvidersCount,
                data.Comments);
        }

        /// <summary>
        /// Step: When the user clicks on claim selector button
        /// </summary>
        [When("the user clicks on claim selector button")]
        public void WhenTheUserClicksOnClaimSelectorButton()
        {
            caseEditPage.clickOnClaimSelectorButton();
        }

        /// <summary>
        /// Step: When the user selects claims
        /// </summary>
        [When("the user selects claims")]
        public void WhenTheUserSelectsClaims()
        {
            caseEditPage.selectingTheClaims();
        }

        /// <summary>
        /// Step: When the user clicks case claim link
        /// </summary>
        [When("the user clicks case claim link")]
        public void WhenTheUserClicksCaseClaimLink()
        {
            caseEditPage.ClickCaseClaimLink();
        }

        /// <summary>
        /// Step: When the user downloads case claims detail
        /// </summary>
        [When("the user downloads case claims detail")]
        public void WhenTheUserDownloadsCaseClaimsDetail()
        {
            var result = caseEditPage.downloadCaseClaimsDetailAndValidateDataPopulates();
            _scenarioContext["ClaimSummaryResult"] = result;
        }

        /// <summary>
        /// Step: When the user runs patient histories report with expected data {expectedData}
        /// </summary>
        [When("the user runs patient histories report with expected data")]
        public void WhenTheUserRunsPatientHistoriesReportWithExpectedData()
        {
           var success = caseEditPage.RunPatientHistoriesReport();
            Console.WriteLine($"Patient Histories Report run successfully: {success}");
            _scenarioContext["ReportSuccess"] = success;
        }

        /// <summary>
        /// Step: When the user downloads patient histories excel report with expected data {expectedData}
        /// </summary>
        [When("the user downloads patient histories excel report with expected data")]
        public void WhenTheUserDownloadsPatientHistoriesExcelReportWithExpectedData()
        {
            var success = caseEditPage.DownloadPatientHistoriesExcelReport();
            _scenarioContext["ExcelReportSuccess"] = success;
        }

        #endregion

        #region Then Steps - Assertions and Verifications

        /// <summary>
        /// Step: Then the new activity {activityTitle} should appear in the activities list
        /// </summary>
        [Then("the new activity should appear in the activities list")]
        public void ThenTheNewActivityShouldAppearInTheActivitiesList(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var title = data.InvestigativeCaseActivityManual_Title;
            var appears = caseEditPage.NewActivityAppears(title);
            Assert.IsTrue(appears, "Could not add a new activity");
        }

        /// <summary>
        /// Step: Then the new attachment {attachmentTitle} should appear in the list
        /// </summary>
        [Then("the new attachment should appear in the list")]
        public void ThenTheNewAttachmentShouldAppearInTheList(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var attachment = data.AttachmentTitle;
            var appears = caseEditPage.NewAttachmentAppearsInTheList(attachment);
            Assert.IsTrue(appears, "Could not add a new attachment");
        }

        /// <summary>
        /// Step: Then the activity note should match {expectedNote}
        /// </summary>
        [Then("the activity note should match")]
        public void ThenTheActivityNoteShouldMatch(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var activityNote = caseEditPage.GetActivityNote();
           
            caseEditPage.CloseActivityForHandlingConfirmationPopup();
            var expected = data.CaseActivityManual_Title;
            Assert.AreEqual(expected, activityNote);
        }

        /// <summary>
        /// Step: Then the new download {activityTitle} should appear in download attachment manager
        /// </summary>
        [Then("the new download should appear in download attachment manager")]
        public void ThenTheNewDownloadShouldAppearInDownloadAttachmentManager(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var activityTitle = data.InvestigativeCaseActivityManual_Title;

            var downloadAppears = caseEditPage.NewDownloadAppearsInDownloadAttachmentManager(activityTitle);
            Assert.IsTrue(downloadAppears, "Could not download attachments using Download Attachment Manager");
        }
        /// <summary>
        /// Step: Then the new download {activityTitle} should appear in download attachment manager
        /// </summary>
        [Then("the new case download should appear in download attachment manager")]
        public void ThenTheNewCaseDownloadShouldAppearInDownloadAttachmentManager(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var activityTitle = data.ActivityName_2;

            var downloadAppears = caseEditPage.NewDownloadAppearsInDownloadAttachmentManager(activityTitle);
            Assert.IsTrue(downloadAppears, "Could not download attachments using Download Attachment Manager");
        }
        [Then("the user closes the activity")]
        public void ThenTheUserClosesTheActivity()
        {
             caseEditPage.CloseActivity();
        }


        /// <summary>
        /// Step: Then the case claim search button should be enabled
        /// </summary>
        [Then("the case claim search button should be enabled")]
        public void ThenTheCaseClaimSearchButtonShouldBeEnabled()
        {
            var caseclaimSearchbutton = caseEditPage.caseClaimSearchButton();
            Assert.IsTrue(caseclaimSearchbutton, "Search button is not enabled");
        }

        /// <summary>
        /// Step: Then the attachment and notes column text should match {expectedText}
        /// </summary>
        [Then("the attachment and notes column text should match")]
        public void ThenTheAttachmentAndNotesColumnTextShouldMatch()
        {
            var actualText = caseEditPage.GetAttachmentAndNotesColumnText();
            Assert.AreEqual(AppConstants.NotesandAttachmenttext, actualText);
        }

        /// <summary>
        /// Step: Then the total underpayment value should be displayed correctly
        /// </summary>
        [Then("the total underpayment value should be displayed correctly")]
        public void ThenTheTotalUnderpaymentValueShouldBeDisplayedCorrectly()
        {
            var isDisplayed = caseEditPage.GetTotatalUnderpaymentvalue();
            Assert.IsTrue(isDisplayed, "Total Underpayment is not displayed correctly");
        }

        /// <summary>
        /// Step: Then the total overpayment value should be displayed correctly
        /// </summary>
        [Then("the total overpayment value should be displayed correctly")]
        public void ThenTheTotalOverpaymentValueShouldBeDisplayedCorrectly()
        {
            var isDisplayed = caseEditPage.GetTotatalOverPaymenvalue();
            Assert.IsTrue(isDisplayed, "Total Overpayment is not displayed correctly");
        }

        /// <summary>
        /// Step: Then the user deletes the findings
        /// </summary>
        [Then("the user deletes the findings")]
        public void ThenTheUserDeletesTheFindings()
        {
            caseEditPage.DeleteFindings();
        }

        /// <summary>
        /// Step: Then the claim line preview popup should be displayed
        /// </summary>
        [Then("the claim line preview popup should be displayed")]
        public void ThenTheClaimLinePreviewPopupShouldBeDisplayed()
        {
            var claimLinePreview = caseEditPage.reviewCaseClaimReview();
            Assert.IsTrue(claimLinePreview, "ClaimLine Preview Popup is not displayed");
        }

        /// <summary>
        /// Step: Then the case claim review popup column names should not be repeated
        /// </summary>
        [Then("the case claim review popup column names should not be repeated")]
        public void ThenTheCaseClaimReviewPopupColumnNamesShouldNotBeRepeated()
        {
            var columnHeader = caseEditPage.caseClaimReviewColumnNamesreNotRepeated();
            Assert.IsTrue(columnHeader, "Case Claim Review popup column names are repeated");
        }

        /// <summary>
        /// Step: Then the downloaded claim summary should match {expectedClaimId}
        /// </summary>
        [Then("the downloaded claim summary should match")]
        public void ThenTheDownloadedClaimSummaryShouldMatch(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var result = _scenarioContext["ClaimSummaryResult"].ToString();
            var expected = data.ClaimSummaryClaimIDforInvestigativecase;
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Step: Then the user closes window handles
        /// </summary>
        [Then("the user closes window handles")]
        public void ThenTheUserClosesWindowHandles()
        {
            caseEditPage.CloseWindowHandles();
        }

        /// <summary>
        /// Step: Then the patient histories report should run successfully
        /// </summary>
        [Then("the patient histories report should run successfully")]
        public void ThenThePatientHistoriesReportShouldRunSuccessfully(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var success = _scenarioContext["ReportSuccess"].ToString();
            var expected = data.PatientHistoriesReport_ExpectedData;
            Assert.AreEqual(expected, success, "Could not run Patient Histories Report");
        }

        /// <summary>
        /// Step: Then the excel report should be downloaded and data should render properly
        /// </summary>
        [Then("the excel report should be downloaded and data should render properly")]
        public void ThenTheExcelReportShouldBeDownloadedAndDataShouldRenderProperly(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<CaseTrackingData>();
            var success = _scenarioContext["ExcelReportSuccess"].ToString();
            var expected = data.PatientHistoriesReport_ExpectedData;
            Assert.AreEqual(expected,success, "Could not download excel report and data doesn't render properly");
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Clears the scenario context for a new test
        /// </summary>
        public void ClearScenarioContext()
        {
            _scenarioContext.Clear();
        }

        /// <summary>
        /// Gets the Case Tracking Data instance
        /// </summary>
        public CaseTrackingData GetCaseTrackingData()
        {
            return caseTrackingData;
        }

        #endregion
    }
}
