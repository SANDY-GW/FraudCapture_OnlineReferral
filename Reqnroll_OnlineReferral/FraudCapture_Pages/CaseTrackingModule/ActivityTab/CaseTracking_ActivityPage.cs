using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.ActivityTab
{
    internal class CaseTracking_ActivityPage : BaseSettings
    {
        public CaseTracking_ActivityPage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements

      
       //Add xpath here
        private readonly By ActivitiesTab = By.XPath("//a[@id='activityTabId']");
        

        private readonly By WorkLoadReassignment = By.XPath("//*[@id='reassignUserCaseTabId']/b");
        
        private readonly By ApplyDynamicFiltering = By.XPath("//*[@id='applyActivityDynamicId']/b");
        private readonly By ActivitySearchCriteria = By.XPath(" //*[@id='activitySearchCriteria']");
        private readonly By ActivitySearchTxtBox = By.XPath(" //*[@id='searchInputField']");
       
        private readonly By ActivitySearchBtn = By.XPath(" //*[@id='searchStartButton']");
        private readonly By ActivitySearchClearBtn = By.XPath(" //*[@id='searchClearButton']");
        private readonly By ActivityExportListBtn = By.XPath("//*[@id='activityListTable']/div[1]/div/div[2]/div/button");

        private readonly By ActivityEditBtn = By.XPath("//*[@id='allActivities-wrapper']/cdk-virtual-scroll-viewport/div[1]/table/tbody/tr[1]/td[11]/button");
        private readonly By HeaderTableActivityStatus = By.XPath("//*[@id='headerTableActivities']/thead/tr/th[2]/small/b");
        private readonly By HeaderTableActivityAssignedTo= By.XPath(" //*[@id='headerTableActivities']/thead/tr/th[3]/small/b");
        private readonly By HeaderTableActivityAssignedSupervisor = By.XPath("//*[@id='headerTableActivities']/thead/tr/th[4]");
        private readonly By HeaderTableActivityDivDept = By.XPath("//*[@id='headerTableActivities']/thead/tr/th[5]");
        private readonly By HeaderTableActivityCaseLeadID = By.XPath("//*[@id='headerTableActivities']/thead/tr/th[7]/small/b");
        private readonly By HeaderTableActivitySubjectName = By.XPath("//*[@id='headerTableActivities']/thead/tr/th[8]/small/b");


        private readonly By HeaderTableActivityDueDate = By.XPath("//*[@id='headerTableActivities']/thead/tr/th[6]/small/b");
        private readonly By HeaderTableActivityName = By.XPath(" //*[@id='headerTableActivities']/thead/tr/th[1]/small/b");
        private readonly By AddActivityButton = By.XPath("//a[@id='addActivityId']");
        private readonly By ActivityNameDropdown = By.XPath("//a[@id='name']");
        private readonly By CreateActivityButton = By.XPath("//sapn[contains(text(),'Create Activity')]");
        private readonly By SaveActivityButton = By.XPath("//span[contains(text(),'Save')]");
        private readonly By ExitActivityButton = By.XPath("//*[@id='activitydetail']//button[contains(text(),'Exit Activity')]");
        private readonly By CloseActivityButton = By.XPath("//*[@id='noteAttachmentWidgetId']/div[1]/div[2]/img");
        #endregion

        public void ClickActivitiesTab()
        {
            driver.FindElement(ActivitiesTab).Click();
        }

        
        public void ClickWorkLoadREassignmentBtn()
        {
            driver.FindElement(WorkLoadReassignment).Click();
        }
        public void ClickApplyDynamicFilteringBtn()
        {
            driver.FindElement(ApplyDynamicFiltering).Click();
        }
        public void ClickActivityEditBtn()
        {
            driver.FindElement(ActivityEditBtn).Click();
        }
        public void ClickHeaderActivityName()
        {
            driver.FindElement(HeaderTableActivityName).Click();
        }
        public void ClickHeaderActivityStatus()
        {
            driver.FindElement(HeaderTableActivityStatus).Click();
        }
        public void ClickHeaderActivityAssignedTo()
        {
            driver.FindElement(HeaderTableActivityAssignedTo).Click();
        }
        public void ClickHeaderActivityDueDate()
        {
            driver.FindElement(HeaderTableActivityDueDate).Click();
        }
        public void ClickHeaderActivitySupervisor()
        {
            driver.FindElement(HeaderTableActivityAssignedSupervisor).Click();
        }
        public void ClickHeaderActivityDivisionDept()
        {
            driver.FindElement(HeaderTableActivityDivDept).Click();
        }
        public void ClickHeaderActivityCaseLeadID()
        {
            driver.FindElement(HeaderTableActivityCaseLeadID).Click();
        }
        public void ClickHeaderActivitySubjectName()
        {
            driver.FindElement(HeaderTableActivitySubjectName).Click();
        }

        public void ClickActivitySearchBtn()
        {
            driver.FindElement(ActivitySearchBtn).Click();
        }
        public void ClickActivitySearchClearBtn()
        {
            driver.FindElement(ActivitySearchClearBtn).Click();
        }
        public void ClickActivityExportListBtn()
        {
            driver.FindElement(ActivityExportListBtn).Click();
        }


        public void EnteryActivitySearchTxt(string activitySearchCriteria)
        {
            driver.FindElement(ActivitySearchTxtBox).SendKeys(activitySearchCriteria);
        }
        public void SelectActivitySearchCriteria(string searchCriteria)
        {
            CommonHelpers.WaitForElementVisiblity(driver, ActivitySearchCriteria, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(ActivitySearchCriteria), searchCriteria);

        }
        public void ClickAddActivitiesTab()
        {
            driver.FindElement(AddActivityButton).Click();
        }
        public void SelectActivityName(string activityName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, ActivityNameDropdown, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(ActivityNameDropdown), activityName);

        }
        public void ClickCreateActivitiesBtn()
        {
            driver.FindElement(CreateActivityButton).Click();
        }
        public void ClickSaveActivitiesBtn()
        {
            driver.FindElement(SaveActivityButton).Click();
        }
        public void ClickExitActivitiesBtn()
        {
            driver.FindElement(ExitActivityButton).Click();
        }
        public void ClickCloseActivitiesBtn()
        {
            driver.FindElement(CloseActivityButton).Click();
        }
    }
}
