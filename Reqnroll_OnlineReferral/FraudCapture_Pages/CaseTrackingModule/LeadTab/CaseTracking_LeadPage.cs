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
            driver.FindElement(LeadTab).Click();
        }

        public void SelectLeadAssignedTo(string assignedTo)
        {
            CommonHelpers.WaitForElementVisiblity(driver, LeadAssignedTo, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(LeadAssignedTo), assignedTo);
        }
        public void SelectLeadAssignedSupervisor(string assignedSupervisor)
        {
            CommonHelpers.WaitForElementVisiblity(driver, LeadAssignedSupervisor, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(LeadAssignedSupervisor), assignedSupervisor);
        }
        public void SelectLeadDivisionDept(string divDept)
        {
            CommonHelpers.WaitForElementVisiblity(driver, LeadDivisionDepartmentDDL, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(LeadDivisionDepartmentDDL), divDept);
        }
        public void SelectLeadType(string caseType)
        {
            CommonHelpers.WaitForElementVisiblity(driver, LeadTypeDDL, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(LeadTypeDDL), caseType);
        }
        public void SelectLeadStatus(string caseStatus)
        {
            CommonHelpers.WaitForElementVisiblity(driver, LeadStatus, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(LeadStatus), caseStatus);
        }
        public void SelectLeadSearchCriteria(string searchCriteria)
        {
            CommonHelpers.WaitForElementVisiblity(driver, LeadSearchCriteria, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(LeadSearchCriteria), searchCriteria);

        }
        public void EnterLeadSearchCriteriaText(string searchCriteriaText)
        {
            driver.FindElement(LeadSearchTextBox).SendKeys(searchCriteriaText);
        }
        public void ClickLeadActivitiesEdit()
        {
            driver.FindElement(ActivitiesEditButton).Click();
        }

        public void ClickLeadActivitiesDetailsTab()
        {
            driver.FindElement(ActivitiesDetailsTab).Click();
        }
        public void ClickLeadActivitiesView()
        {
            driver.FindElement(ActivitiesViewButton).Click();
        }
        public void ClickLeadSearch()
        {
            driver.FindElement(LeadSearchButton).Click();
        }
        public void ClickLeadSearchClear()
        {
            driver.FindElement(LeadSearchClearButton).Click();
        }
        public void ClickLeadIDLink()
        {       
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(LeadIDLink).Click();
        }
        public void ClickLeadIDSecondLink()
        {
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(LeadIDsecondLink).Click();
        }
        public void ClickBeginEditing()
        {
            CommonHelpers.WaitForPageLoading(driver);

            /*IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", BeginEditing);*/
            driver.FindElement(BeginEditing).Click();
        }
        public void ClickLeadActivitiesAttachment()
        {
            driver.FindElement(ActivitiesAttachmentTab).Click();
        }
        public void ClickLeadcreateDateFilter()
        {

            driver.FindElement(LeadCreateDateFilter).Click();



        }
        public string getLeadFirstRowOrganizatioName()
        {


            var subjectname = driver.FindElement(LeadOrgName).Text.Split(':')[1];
            var firsRowOrgName = subjectname.Split('-')[0];
            return firsRowOrgName;


        }
        public string getLeadSecondRowOrganizatioName()
        {



            var subjectname = driver.FindElement(LeadOrgNameSecondRow).Text.Split(':')[1];
            var secondRowOrgName = subjectname.Split('-')[0];
            return secondRowOrgName;



        }

        public string getLeadFirstRowFirstAndLastNameName()
        {


            var subjectname = driver.FindElement(LeadOrgName).Text.Split(':')[1];
            var firsRowFLName = subjectname.Split('-')[0];
            return firsRowFLName;


        }
        public string getLeadSecondRowFirstAndLastNameName()
        {



            var subjectname = driver.FindElement(LeadOrgNameSecondRow).Text.Split(':')[1];
            var secondRowFLName = subjectname.Split('-')[0];
            return secondRowFLName;



        }
        public void waitForLeadTab()
        {
            CommonHelpers.WaitForElementVisiblity(driver, LeadTab, 15000);

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

        }
        public void waitForLeadLink()
        {
            CommonHelpers.WaitForElementVisiblity(driver, LeadIDLink, 15000);

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

        }
        public void SelectLead(string leadId)
        {
            var tableRows = driver.FindElements(By.XPath("//table/tbody/tr"));

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
            
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,50);
        }
        public void ScrollByElementCoordinates(IWebElement element)
        {
            System.Drawing.Point point = element.Location;
            int x_coordinate = point.X - 250;
            int y_coordinate = point.Y - 250;
            IJavaScriptExecutor jsExec = (IJavaScriptExecutor)driver;
            jsExec.ExecuteScript("window.scrollBy(" + x_coordinate + ", " + y_coordinate + ");");
        }

        public void BeginEditingLead()
        {

            try
            {

                if (driver.FindElement(BeginEditing).Displayed)
                {
                    driver.FindElement(BeginEditing).Click();
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

                if (driver.FindElement(ExitLead).Displayed)
                {
                    driver.FindElement(ExitLead).Click();
                    CommonHelpers.WaitForPageToLoad(driver, 50);
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
            driver.FindElement(ActivitiesDetailsTab).Click();
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
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("leadSearchCriteria")));
            selectCriteria.SelectByValue(leadid);
        }

        public void EnterLeadID(string leadID)
        {
            driver.FindElement(LeadGridSearchInput).SendKeys(leadID);
            CommonHelpers.WaitForPageToLoad(driver, 50);
        }
        public void ClickSearchButton()
        {

            driver.FindElement(LeadGridSearchButton).Click();
            CommonHelpers.WaitForPageToLoad(driver, 50);
        }
        public string GetActivityName()
        {
            var fc = new FC_CaseTracking_LeadPage(driver);
            CommonHelpers.WaitForPageToLoad(driver, 50);
            var activityName = driver.FindElement(By.XPath("//*[@id='activityForm']/div/div[2]/div[2]/cdk-virtual-scroll-viewport/div[1]/div/table/tbody/tr/td[1]")).Text;

            Console.WriteLine(activityName);
            return activityName;

        }
        //Create New Lead Button
        public void ClickCreateNewLeadBtn()
        {
            driver.FindElement(CreateNewLeadBtn).Click();
        }
    }
}
