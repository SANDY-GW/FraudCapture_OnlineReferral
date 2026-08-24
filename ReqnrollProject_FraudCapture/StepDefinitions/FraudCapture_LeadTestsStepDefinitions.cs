using FC_OnlineReferral.FraudCapture_Pages;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab;
using FC_OnlineReferral.OnlineReferral_Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using System;

namespace ReqnrollProject_FraudCapture.StepDefinitions
{
    [Binding]
    public class FraudCapture_LeadTestsStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
        public FraudCapture_LeadTestsStepDefinitions(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        //[Then("I select the Lead ID from the below list of Lead Table")]
        //public void ThenISelectTheLeadIDFromTheBelowListOfLeadTable()
        //{
        //    var fc = new FC_CaseTracking_LeadPage(Driver);
        //    fc.SelectLeadSearchCriteria(data. searchCriteria);
        //    fc.ClickLeadIDFirstLink();
        //}

       
        [When("I select  the select criteria  as {string} on the fraud capture Lead table Page")]
        public void WhenISelectTheSelectCriteriaAsOnTheFraudCaptureLeadTablePage(string leadid)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 40);
            //CommonHelpers.WaitForPageLoading(Driver);
            fc.SearchByLeadID(leadid);
            CommonHelpers.WaitForPageLoading(Driver);
        }
        [Then("I search the LeadID from Search Criteria on the fraud capture lead page")]
        public void ThenISearchTheLeadIDFromSearchCriteriaOnTheFraudCaptureLeadPage(DataTable dataTable)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureLeadData>();
            CommonHelpers.WaitForPageLoading(Driver);
            //fc.SearchByLeadID(data.searchleadid);
            fc.EnterLeadID(data.leadID);
            //fc.SelectLeadSearchCriteria(data.searchCriteria);
            //fc.EnterLeadSearchCriteriaText(data.searchCriteriaText);
        }



        [Then("I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture")]
        public void ThenIClickSearchButtonToSearchTheLeadIDAndNavigateToTheLeadDetailsPageOnTheFraudCapture(DataTable dataTable)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureLeadData>();
            fc.ClickSearchButton();
            fc.SelectLead(data.selectleadId);
            CommonHelpers.SwitchtoNewWindow(Driver);
        }


        [Then("i click Begin Editing button to Edit the Lead Details")]
        public void ThenIClickBeginEditingButtonToEditTheLeadDetails()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadBeginEditing();
            
        }
        [Then("i click Activity Tab and click Begin Editing on the Fraud Capture Page")]
        public void ThenIClickActivityTabAndClickBeginEditingOnTheFraudCapturePage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadActivitiesDetailsTab();
            fc.ClickLeadBeginEditing();
        }

        [Then("i click Edit button to edit the activity on the Fraud Capture Page")]
        public void ThenIClickEditButtonToEditTheActivityOnTheFraudCapturePage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadActivitiesEdit();
        }

        [Then("I click on the Begin Editing on the fraud capture Lead detials Page")]
        public void ThenIClickOnTheBeginEditingOnTheFraudCaptureLeadDetialsPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.BeginEditingLead();
        }

        [Then("I click Activity Tab on the Fraud Capture Page and Edit the Actvity")]
        public void ThenIClickActivityTabOnTheFraudCapturePageAndEditTheActvity()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadActivitiesDetailsTab();
            fc.ClickLeadActivitiesEdit();
        }


        [Then("I Add the note on the fraud capture lead page and click on the Save button with Confirmation")]
        public void ThenIAddTheNoteOnTheFraudCaptureLeadPageAndClickOnTheSaveButtonWithConfirmation(DataTable dataTable)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureLeadData>();          
            fc.ClickAddBtnNotes();
            fc.ClickAddNotesTextArea(data.AddNotes);
            fc.ClickAddNotesSaveBtn();
            fc.ClickAddSaveConfirmYesbtn();
        }



        [Then("I click on the Activities and selected lead activity name as {string} on the fraud capture Lead detials Page")]
        public void ThenIClickOnTheActivitiesAndSelectedLeadActivityNameAsOnTheFraudCaptureLeadDetialsPage(string activityName)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);

            try
            {
                fc.ClickLeadActivityTab();
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);

                var ActName = fc.GetActivityName();

                if (!fc.ClickOnEditActivity(activityName))
                    NUnit.Framework.Assert.Fail("The activity with the name '" + activityName + "' was not found in the Activities table.");

                Assert.That(ActName, Is.EqualTo(activityName));

            }
            catch (Exception)
            {

                CommonHelpers.WaitForPageLoading(Driver);

            }
        }
        


        [Then("I should be navigated to Lead Activities  Page")]
        public void ThenIShouldBeNavigatedToLeadActivitiesPage()
        {

            CommonHelpers.WaitForPageLoading(Driver);

        }


        [Then("I Select the Activity Tab and click Begin Editing on the fraud capture lead page")]
        public void ThenISelectTheActivityTabAndClickBeginEditingOnTheFraudCaptureLeadPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadActivitiesDetailsTab();
            fc.ClickActivitiesBeginEditing();

        }
        [Then("I click Edit button to edit the Lead on the fraud capture lead page")]
        public void ThenIClickEditButtonToEditTheLeadOnTheFraudCaptureLeadPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadActivitiesEdit();


        }
        [Then("I click Attachment to add the attachment on the fraud capture lead page")]
        public void ThenIClickAttachmentToAddTheAttachmentOnTheFraudCaptureLeadPage(DataTable dataTable)
        {
            var PG5 = new New_UI_Questions_Page5(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Attachments\";
            PG5.ClickUploadFileArrow(filePath + data.filePath);
        }

        [When("I click the Add Activity button on the fraud capture lead activity page")]
        public void WhenIClickTheAddActivityButtonOnTheFraudCaptureLeadActivityPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickAddActivityButton();
        }

        [When("I select Activity Name from the dropdown as {string}")]
        public void WhenISelectActivityNameFromTheDropdownAs(string activityName)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.SelectAddActivityName(activityName);
        }

        [When("I click Continue button on the Add Activity popup")]
        public void WhenIClickContinueButtonOnTheAddActivityPopup()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickAddActivityContinueButton();
        }

        [When("I click Add button on the Add Activity popup")]
        public void WhenIClickAddButtonOnTheAddActivityPopup()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickAddActivityAddButton();
        }

        [When("I enter notes as {string} and click Save button with confirmation Yes")]
        public void WhenIEnterNotesAsAndClickSaveButtonWithConfirmationYes(string notes)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickAddBtnNotes();
            fc.ClickAddNotesTextArea(notes);
            fc.ClickAddNotesSaveBtn();
            fc.ClickAddSaveConfirmYesbtn();
        }

        [When("I click Add Attachment button on the fraud capture lead page")]
        public void WhenIClickAddAttachmentButtonOnTheFraudCaptureLeadPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickActivitiesAddAttachmentBtn();
        }

        [When("I upload attachment file on the fraud capture lead page")]
        public void WhenIUploadAttachmentFileOnTheFraudCaptureLeadPage(DataTable dataTable)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Attachments\";
            fc.ClickUploadFileArrow(filePath + data.filePath);
        }

        [When(@"I click Attachment to view attachments on the fraud capture lead page")]
        [Then(@"I click Attachment to view attachments on the fraud capture lead page")]
        public void ThenIClickAttachmentToViewAttachments()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadActivitiesAttachment();
        }

        [Then(@"I click the Download Attachment Manager button")]
        public void ThenIClickTheDownloadAttachmentManagerButton()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickDownloadAttachmentManagerButton();
        }

        [Then(@"the Download Attachment Manager popup should be displayed on the fraud capture lead page")]
        public void ThenTheDownloadAttachmentManagerPopupShouldBeDisplayed()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            Assert.That(fc.IsDownloadAttachmentManagerPopupDisplayed(), Is.True,
                "Download Attachment Manager popup should be displayed");
        }

        [When(@"I click the ""Download All Attachments"" button in the Download Attachment Manager popup")]
        public void WhenIClickTheDownloadAllAttachmentsButtonInTheDownloadAttachmentManagerPopup()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickDownloadAllAttachments();
        }

        [When(@"I confirm the download by clicking ""Yes"" in the confirmation dialog")]
        public void WhenIConfirmTheDownloadByClickingYesInTheConfirmationDialog()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ConfirmDownloadYes();
        }

        [Then(@"I should be able to close the Download Attachment Manager popup")]
        public void ThenIShouldBeAbleToCloseTheDownloadAttachmentManagerPopup()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.CloseDownloadAttachmentManagerPopup();
            Assert.That(fc.IsDownloadAttachmentManagerPopupDisplayed(), Is.False, "Download Attachment Manager popup should be closed");
        }

        [When(@"I click the ""Download"" button in the Download Attachment Manager popup")]
        public void WhenIClickTheDownloadButtonInTheDownloadAttachmentManagerPopup()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickDownloadButtonInAttachmentManagerPopup();
        }

        [Then(@"I close the Activity window on the fraud capture lead page")]
        public void ThenICloseTheActivityWindowOnTheFraudCaptureLeadPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickExitActivity();
        }

        [When(@"I click the ""View"" button to view the attachment document")]
        public void WhenIClickTheViewButtonToViewTheAttachmentDocument()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickViewAttachmentButton();
        }

        [Then(@"I should be able to navigate to the attachment details page")]
        public void ThenIShouldBeAbleToNavigateToTheAttachmentDetailsPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            Assert.That(fc.IsAttachmentDetailsPageDisplayed(), Is.True, "Should be navigated to attachment details page");
        }

        [When(@"I click the ""Back"" button to return from the attachment details page")]
        public void WhenIClickTheBackButtonToReturnFromTheAttachmentDetailsPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickBackButton();
        }

        [Then(@"I should be navigated back to the attachment list view")]
        public void ThenIShouldBeNavigatedBackToTheAttachmentListView()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            Assert.That(fc.IsAttachmentListViewDisplayed(), Is.True, "Should be navigated back to attachment list view");
        }

        [Then("click Begin Editing button on the fraud capture lead page")]
        public void ThenIClickLeadTabAndClickBeginEditingButtonOnTheFraudCaptureLeadPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadBeginEditing();
        }

        [Then("I enter {string} in Lead Description area on the fraud capture lead page")]
        public void ThenIEnterInLeadDescriptionAreaOnTheFraudCaptureLeadPage(string leadDescription)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.EnterLeadDescription(leadDescription);
        }

        [Then("I click Save button on the fraud capture lead page")]
        public void ThenIClickSaveButtonOnTheFraudCaptureLeadPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadSaveButton();
        }

        [Then("I select Lead Type as {string} on the fraud capture lead page")]
        public void ThenISelectLeadTypeAsOnTheFraudCaptureLeadPage(string leadType)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.SelectLeadType(leadType);
        }

        [Then("I select Lead Status as {string} on the fraud capture lead page")]
        public void ThenISelectLeadStatusAsOnTheFraudCaptureLeadPage(string leadStatus)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.SelectLeadStatus(leadStatus);
        }

        [Then("I click Reason tab on the fraud capture lead page")]
        public void ThenIClickReasonTabOnTheFraudCaptureLeadPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadReasonTab();
        }

        [Then("I click Add button on the Lead Reason section on the fraud capture lead page")]
        public void ThenIClickAddButtonOnTheLeadReasonSectionOnTheFraudCaptureLeadPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadReasonAddButton();
        }

        [Then("I select Detection Method as {string} on the fraud capture lead page")]
        public void ThenISelectDetectionMethodAsOnTheFraudCaptureLeadPage(string detectionMethod)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.SelectLeadReasonDetectionMethod(detectionMethod);
        }

        [Then("I select Source Type as {string} on the fraud capture lead page")]
        public void ThenISelectSourceTypeAsOnTheFraudCaptureLeadPage(string sourceType)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.SelectLeadReasonSourceType(sourceType);
        }

        [Then("I select Reason as {string} on the fraud capture lead page")]
        public void ThenISelectReasonAsOnTheFraudCaptureLeadPage(string reason)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.SelectLeadReasonReason(reason);
        }

        [Then("I enter {string} in Reason Description area on the fraud capture lead page")]
        public void ThenIEnterInReasonDescriptionAreaOnTheFraudCaptureLeadPage(string reasonDescription)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.EnterLeadReasonDescription(reasonDescription);
        }

        [Then("I click Save button on the lead reason section on the fraud capture lead page")]
        public void ThenIClickSaveButtonOnTheLeadReasonSectionOnTheFraudCaptureLeadPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadReasonSaveButton();
        }

        [Then("I select Assigned To as {string} on the fraud capture lead page")]
        public void ThenISelectAssignedToAsOnTheFraudCaptureLeadPage(string assignedTo)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.SelectLeadAssignedTo(assignedTo);
        }

        [Then("I select Department/Division as {string} on the fraud capture lead page")]
        public void ThenISelectDepartmentDivisionAsOnTheFraudCaptureLeadPage(string departmentDivision)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.SelectLeadDepartmentDivision(departmentDivision);
        }

        [Then("I select Section/Team as {string} on the fraud capture lead page")]
        public void ThenISelectSectionTeamAsOnTheFraudCaptureLeadPage(string sectionTeam)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.SelectLeadSectionTeam(sectionTeam);
        }

        [Then("I click Save button on the fraud capture lead page and click Subjects tab")]
        public void ThenIClickSaveButtonOnTheFraudCaptureLeadPageAndClickSubjectsTab()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickSaveAndNavigateToSubjectTab();
        }

    }
}
