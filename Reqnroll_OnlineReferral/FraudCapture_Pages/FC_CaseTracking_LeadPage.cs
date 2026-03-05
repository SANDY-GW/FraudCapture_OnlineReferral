using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FC_OnlineReferral.FraudCapture_Pages
{
    public class FC_CaseTracking_LeadPage : BaseSettings
    {
        public FC_CaseTracking_LeadPage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        //Add xpath here
        private readonly By LeadTab = By.XPath("//a[@id='allLeadsTabId']");
        private readonly By LeadSearchCriteria = By.XPath("//select[@id='leadSearchCriteria']");
        private readonly By LeadSearchTextBox = By.XPath("//input[@id='searchInputField']");
        private readonly By LeadSearchButton = By.XPath("//button[@id='searchStartButton']");
        private readonly By LeadSearchClearButton = By.XPath("//button[@id='searchClearButton']");
        private readonly By LeadIDLink = By.XPath("//*[@id='allLeadlist-wrapper']//div[1]/table/tbody/tr[1]/td[2]/small");
        private readonly By LeadIDsecondLink = By.XPath("//table/tbody/tr[2]/td[2]/small/a");

        private By LeadIDLinkByRow(int row) => By.XPath("//*[@id='allLeadlist-wrapper']//div[1]/table/tbody/tr[" + row + "]/td[2]//a");

        //private readonly By LeadIDLink = By.XPath("//table/tbody/tr/td[2]/small");

        private readonly By LeadGridSearchInput = By.XPath("//div[@id='allLeads']/descendant::input[@id='searchInputField']");
        private readonly By LeadGridSearchButton = By.XPath("//div[@id='allLeads']/descendant::button[@id='searchStartButton']");
        private readonly By LeadOrgName = By.XPath("//tbody/tr[1]/td[8]/div/small");
        private readonly By LeadOrgNameSecondRow = By.XPath("//tbody/tr[2]/td[8]/div/small[1]");
        private readonly By LeadSubFirstNameLastNameFirstRow = By.XPath("//*[@id='allLeadlist-wrapper']//tbody/tr[1]/td[8]/div/small[1]");
        private readonly By LeadSubFirstNameLastNameSecondRow = By.XPath("//*[@id='allLeadlist-wrapper']//tbody/tr[2]/td[8]/div/small[1]");

        //tbody/tr[1]/td[8]/div/small
        private readonly By LeadCreateDateFilter = By.XPath("//*[@id='headerTableLeads']//*[@title='Created Date']");

        private readonly By BeginEditing = By.XPath("//*[@id='leadViewEditEndButton']");
        private readonly By ExitLead = By.XPath("//*[@id='closeBtn']");


        private readonly By ActivitiesDetailsTab = By.XPath("//a[@id='activitiesDetailsTabId']");
        private readonly By ActivitiesEditButton = By.XPath("//button[@id='editActivityId']");
        private readonly By ActivitiesViewButton = By.XPath("//button[@id='editActivityId']//following-sibling::button[contains(text(),'View')");
        private readonly By ActivitiesAttachmentTab = By.XPath("//button[@id='attachmentTabId']");
        #endregion
        public void ClickLeadTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 60);
            CommonHelpers.WaitForElementVisiblity(Driver, LeadTab, 120);            
            Driver.FindElement(LeadTab).Click();
        }
        public void SelectLeadSearchCriteria(string searchCriteria)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadSearchCriteria, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(LeadSearchCriteria), searchCriteria);

        }
        public void EnterLeadSearchCriteriaText(string searchCriteriaText)
        {
            Driver.FindElement(LeadSearchTextBox).SendKeys(searchCriteriaText);
        }
        public void ClickLeadActivitiesEdit()
        {
            Driver.FindElement(ActivitiesEditButton).Click();
        }

        public void ClickLeadActivitiesDetailsTab()
        {
            Driver.FindElement(ActivitiesDetailsTab).Click();
        }
        public void ClickLeadActivitiesView()
        {
            Driver.FindElement(ActivitiesViewButton).Click();
        }
        public void ClickLeadSearch()
        {
            Driver.FindElement(LeadSearchButton).Click();
        }
        public void ClickLeadSearchClear()
        {
            Driver.FindElement(LeadSearchClearButton).Click();
        }
        public void ClickLeadIDLink()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            Driver.FindElement(LeadIDLink).Click();
        }
        public void ClickLeadIDLinkbyRow(int row)
        {
            CommonHelpers.WaitForPageLoading(Driver);
            Driver.FindElement(LeadIDLinkByRow(row)).Click();
            CommonHelpers.SwitchtoNewWindow(Driver);
        }
        
        public void ClickLeadIDSecondLink()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            Driver.FindElement(LeadIDsecondLink).Click();
        }
        public void ClickBeginEditing()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            Driver.FindElement(BeginEditing).Click();
        }
        public void ClickLeadActivitiesAttachment()
        {
            
            Driver.FindElement(ActivitiesAttachmentTab).Click();
        }
        public void ClickLeadcreateDateFilter()
        {
            CommonHelpers.WaitForPageToLoad(Driver, 3000);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 3000);
            CommonHelpers.ScrollDown(Driver);
            Driver.FindElement(LeadCreateDateFilter).Click();



        }
        public string getLeadFirstRowOrganizatioName()
        {


            var subjectname = Driver.FindElement(LeadOrgName).Text.Split(':')[1];
            var firsRowOrgName = subjectname.Split('-')[0];
            return firsRowOrgName;


        }
        public string getLeadSecondRowOrganizatioName()
        {



            var subjectname = Driver.FindElement(LeadOrgNameSecondRow).Text.Split(':')[1];
            var secondRowOrgName = subjectname.Split('-')[0];
            return secondRowOrgName;



        }

        public string getLeadFirstRowFirstAndLastNameName()
        {
            return Driver.FindElement(LeadSubFirstNameLastNameFirstRow).Text;

            //var subjectname1 = Driver.FindElement(LeadSubFirstNameLastNameFirstRow).Text;
            //var subjectname = Driver.FindElement(LeadSubFirstNameLastNameFirstRow).Text.Split(':')[1];
            //var firsRowFLName = subjectname.Split('-')[0];
            //return firsRowFLName;


        }
        public string getLeadSecondRowFirstAndLastNameName()
        {


            return Driver.FindElement(LeadSubFirstNameLastNameSecondRow).Text;
            //var subjectname2 = Driver.FindElement(LeadSubFirstNameLastNameFirstRow).Text;
            //var subjectname = Driver.FindElement(LeadSubFirstNameLastNameSecondRow).Text.Split(':')[1];
            //var secondRowFLName = subjectname.Split('-')[0];
            //return secondRowFLName;



        }
        public void waitForLeadTab()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadTab, 120);

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

        }
        public void waitForLeadLink()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadIDLink, 120);

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

        }
        public void SelectLead(string leadId)
        {
            var tableRows = Driver.FindElements(By.XPath("//table/tbody/tr"));

            try
            {
                var selectedRow = tableRows.Where(row =>
                {
                    var selectedLeadId = row.FindElements(By.TagName("small"))[1].Text;
                    return leadId == selectedLeadId;
                }).First();

                var viewLeadButton = selectedRow.FindElements(By.TagName("small"))[1];                
                CommonHelpers.ScrollByElementCoordinates(Driver, viewLeadButton);
                viewLeadButton.Click();
            }
            catch (NoSuchElementException) { }
          //  var common = new CommonHelpers(Driver);
          //common.WaitForLoadingOverlayToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 1000);  
        }
        
        public void BeginEditingLead()
        {

            try
            {

                if (Driver.FindElement(BeginEditing).Displayed)
                {
                    Driver.FindElement(BeginEditing).Click();
                    // WaitForPageLoading();
                }
            }
            catch (NoSuchElementException)
            {
                //already in Edit mode, move along
            }
        }
        public void ExitLeadActivity()
        {

            try
            {

                if (Driver.FindElement(ExitLead).Displayed)
                {
                    Driver.FindElement(ExitLead).Click();
                    CommonHelpers.WaitForPageLoading(Driver);
                }
            }
            catch (NoSuchElementException)
            {
                //already in Edit mode, move along
            }
        }
        public void ClickLeadActivityTab()
        {
            //  WaitForPageLoading();
            Driver.FindElement(ActivitiesDetailsTab).Click();
            /* try
              {
                  WaitForPageLoading();
                  //if (Driver.FindElement(ActivitiesDetailsTab).Displayed)
                  //{
                  Driver.FindElement(ActivitiesDetailsTab).Click();
                      WaitForPageLoading();
                  //}
              }
              catch (NoSuchElementException)
              {
                  //already in Edit mode, move along
              }*/
        }
        public void SearchByLeadID(string leadid)
        {
            var selectCriteria = new SelectElement(Driver.FindElement(By.Id("leadSearchCriteria")));
            selectCriteria.SelectByValue(leadid);
        }

        public void EnterLeadID(string leadID)
        {
            Driver.FindElement(LeadGridSearchInput).SendKeys(leadID);
            CommonHelpers.WaitForPageLoading(Driver);
        }
        public void ClickSearchButton()
        {

            Driver.FindElement(LeadGridSearchButton).Click();
            CommonHelpers.WaitForPageLoading(Driver);
        }
        public string GetActivityName()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            CommonHelpers.WaitForPageLoading(Driver);
            var activityName = Driver.FindElement(By.XPath("//*[@id='activityForm']/div/div[2]/div[2]/cdk-virtual-scroll-viewport/div[1]/div/table/tbody/tr/td[1]")).Text;

            Console.WriteLine(activityName);
            return activityName;

        }
    }
}

