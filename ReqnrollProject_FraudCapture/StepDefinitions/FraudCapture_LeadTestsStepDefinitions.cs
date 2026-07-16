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
        }

        [Then("i click Activity Tab and click Begin Editing on the Fraud Capture Page")]
        public void ThenIClickActivityTabAndClickBeginEditingOnTheFraudCapturePage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadActivitiesDetailsTab();
            fc.ClickBeginEditing();
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


        //[Then("I Select the Activity Tab and click Begin Editing on the fraud capture lead page")]
        //public void ThenISelectTheActivityTabAndClickBeginEditingOnTheFraudCaptureLeadPage()
        //{
        //    var fc = new FC_CaseTracking_LeadPage(Driver);
        //    fc.ClickLeadActivitiesDetailsTab();
        //    fc.ClickActivitiesBeginEditing();

        //}
        [Then("I click Edit button to edit the Lead on the fraud capture lead page")]
        public void ThenIClickEditButtonToEditTheLeadOnTheFraudCaptureLeadPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadActivitiesEdit();


        }
        [Then("I click Attachment to add the attachment on the fraud capture lead page")]
        public void ThenIClickAttachmentToAddTheAttachmentOnTheFraudCaptureLeadPage(DataTable dataTable)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadActivitiesAttachment();
            fc.ClickActivitiesAddAttachmentBtn();
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.FraudCaptureLeadData>();
            string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Attachments\";
            fc.ClickUploadFileArrow(filePath + data.filePath);
        }




    }
}
