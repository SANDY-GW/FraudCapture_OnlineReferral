using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab
{
    public class CaseTracking_LeadPage :BaseSettings
    {
        public CaseTracking_LeadPage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        //Add xpath here
        private readonly By LeadTab = By.XPath("//a[@id='allLeadsTabId']");

        private readonly By LeadAssignedTo = By.XPath("//*[@id='dropdownLeadListUser']");
        private readonly By LeadAssignedSupervisor = By.XPath("//*[@id='dropdownLeadListSupervisor']");
        private readonly By LeadDivisionDepartmentDDL = By.XPath("//*[@id='dropdownDepartmentDivision']");
        private readonly By LeadTypeDDL = By.XPath("//*[@id='dropDowneadType']");
        private readonly By LeadStatus = By.XPath("//*[@id='leadStatus']");


        private readonly By LeadSearchCriteria = By.XPath("//select[@id='leadSearchCriteria']");
        private readonly By LeadSearchTextBox = By.XPath("//input[@id='searchInputField']");
        private readonly By LeadSearchButton = By.XPath("//button[@id='searchStartButton']");
        private readonly By LeadSearchClearButton = By.XPath("//button[@id='searchClearButton']");
        private readonly By LeadIDLink = By.XPath("//table/tbody/tr[1]/td[2]/small/a");
        private readonly By LeadIDsecondLink = By.XPath("//table/tbody/tr[2]/td[2]/small/a");


        //private readonly By LeadIDLink = By.XPath("//table/tbody/tr/td[2]/small");

        private readonly By LeadGridSearchInput = By.XPath("//div[@id='allLeads']/descendant::input[@id='searchInputField']");
        private readonly By LeadGridSearchButton = By.XPath("//div[@id='allLeads']/descendant::button[@id='searchStartButton']");
        private readonly By LeadOrgName = By.XPath("//tbody/tr[1]/td[8]/div/small");
        private readonly By LeadOrgNameSecondRow = By.XPath("//tbody/tr[2]/td[8]/div/small");

        //tbody/tr[1]/td[8]/div/small
        private readonly By LeadCreateDateFilter = By.XPath("//*[@id='headerTableLeads']/thead/tr/th[10]/small/b");

        private readonly By BeginEditing = By.XPath("//*[@id='leadViewEditEndButton']");
        private readonly By ExitLead = By.XPath("//*[@id='closeBtn']");


        private readonly By ActivitiesDetailsTab = By.XPath("//a[@id='activitiesDetailsTabId']");
        private readonly By ActivitiesEditButton = By.XPath("//button[@id='editActivityId']");
        private readonly By ActivitiesViewButton = By.XPath("//button[@id='editActivityId']//following-sibling::button[contains(text(),'View')");
        private readonly By ActivitiesAttachmentTab = By.XPath("//button[@id='attachmentTabId']");

        //CreateNewLeadButton
        private readonly By CreateNewLeadBtn = By.XPath("//button[contains(normalize-space(.),'Create New Lead')]");
        #endregion
        public void ClickLeadTab()
        {
            Driver.FindElement(LeadTab).Click();
        }

        public void SelectLeadAssignedTo(string assignedTo)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadAssignedTo, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(LeadAssignedTo), assignedTo);
        }
        public void SelectLeadAssignedSupervisor(string assignedSupervisor)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadAssignedSupervisor, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(LeadAssignedSupervisor), assignedSupervisor);
        }
        public void SelectLeadDivisionDept(string divDept)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadDivisionDepartmentDDL, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(LeadDivisionDepartmentDDL), divDept);
        }
        public void SelectLeadType(string caseType)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadTypeDDL, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(LeadTypeDDL), caseType);
        }
        public void SelectLeadStatus(string caseStatus)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadStatus, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(LeadStatus), caseStatus);
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
        public void ClickLeadIDSecondLink()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            Driver.FindElement(LeadIDsecondLink).Click();
        }
        public void ClickBeginEditing()
        {
            CommonHelpers.WaitForPageLoading(Driver);

            /*IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", BeginEditing);*/
            Driver.FindElement(BeginEditing).Click();
        }
        public void ClickLeadActivitiesAttachment()
        {
            Driver.FindElement(ActivitiesAttachmentTab).Click();
        }
        public void ClickLeadcreateDateFilter()
        {

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


            var subjectname = Driver.FindElement(LeadOrgName).Text.Split(':')[1];
            var firsRowFLName = subjectname.Split('-')[0];
            return firsRowFLName;


        }
        public string getLeadSecondRowFirstAndLastNameName()
        {



            var subjectname = Driver.FindElement(LeadOrgNameSecondRow).Text.Split(':')[1];
            var secondRowFLName = subjectname.Split('-')[0];
            return secondRowFLName;



        }
        public void waitForLeadTab()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadTab, 15000);

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

        }
        public void waitForLeadLink()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadIDLink, 15000);

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
                ScrollByElementCoordinates(viewLeadButton);
                viewLeadButton.Click();
            }
            catch (NoSuchElementException) { }
            
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver,50);
        }
        public void ScrollByElementCoordinates(IWebElement element)
        {
            System.Drawing.Point point = element.Location;
            int x_coordinate = point.X - 250;
            int y_coordinate = point.Y - 250;
            IJavaScriptExecutor jsExec = (IJavaScriptExecutor)Driver;
            jsExec.ExecuteScript("window.scrollBy(" + x_coordinate + ", " + y_coordinate + ");");
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
                    CommonHelpers.WaitForPageToLoad(Driver, 50);
                }
            }
            catch (NoSuchElementException)
            {
                //already in Edit mode, move along
            }
        }
        public void LeadActivityTab()
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
            CommonHelpers.WaitForPageToLoad(Driver, 50);
        }
        public void ClickSearchButton()
        {

            Driver.FindElement(LeadGridSearchButton).Click();
            CommonHelpers.WaitForPageToLoad(Driver, 50);
        }
        public string GetActivityName()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            CommonHelpers.WaitForPageToLoad(Driver, 50);
            var activityName = Driver.FindElement(By.XPath("//*[@id='activityForm']/div/div[2]/div[2]/cdk-virtual-scroll-viewport/div[1]/div/table/tbody/tr/td[1]")).Text;

            Console.WriteLine(activityName);
            return activityName;

        }
        //Create New Lead Button
        public void ClickCreateNewLeadBtn()
        {
            Driver.FindElement(CreateNewLeadBtn).Click();
        }
    }
}
