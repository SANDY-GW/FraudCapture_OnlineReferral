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
            Driver.FindElement(ActivitiesTab).Click();
        }

        
        public void ClickWorkLoadREassignmentBtn()
        {
            Driver.FindElement(WorkLoadReassignment).Click();
        }
        public void ClickApplyDynamicFilteringBtn()
        {
            Driver.FindElement(ApplyDynamicFiltering).Click();
        }
        public void ClickActivityEditBtn()
        {
            Driver.FindElement(ActivityEditBtn).Click();
        }
        public void ClickHeaderActivityName()
        {
            Driver.FindElement(HeaderTableActivityName).Click();
        }
        public void ClickHeaderActivityStatus()
        {
            Driver.FindElement(HeaderTableActivityStatus).Click();
        }
        public void ClickHeaderActivityAssignedTo()
        {
            Driver.FindElement(HeaderTableActivityAssignedTo).Click();
        }
        public void ClickHeaderActivityDueDate()
        {
            Driver.FindElement(HeaderTableActivityDueDate).Click();
        }
        public void ClickHeaderActivitySupervisor()
        {
            Driver.FindElement(HeaderTableActivityAssignedSupervisor).Click();
        }
        public void ClickHeaderActivityDivisionDept()
        {
            Driver.FindElement(HeaderTableActivityDivDept).Click();
        }
        public void ClickHeaderActivityCaseLeadID()
        {
            Driver.FindElement(HeaderTableActivityCaseLeadID).Click();
        }
        public void ClickHeaderActivitySubjectName()
        {
            Driver.FindElement(HeaderTableActivitySubjectName).Click();
        }

        public void ClickActivitySearchBtn()
        {
            Driver.FindElement(ActivitySearchBtn).Click();
        }
        public void ClickActivitySearchClearBtn()
        {
            Driver.FindElement(ActivitySearchClearBtn).Click();
        }
        public void ClickActivityExportListBtn()
        {
            Driver.FindElement(ActivityExportListBtn).Click();
        }


        public void EnteryActivitySearchTxt(string activitySearchCriteria)
        {
            Driver.FindElement(ActivitySearchTxtBox).SendKeys(activitySearchCriteria);
        }
        public void SelectActivitySearchCriteria(string searchCriteria)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, ActivitySearchCriteria, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(ActivitySearchCriteria), searchCriteria);

        }
        public void ClickAddActivitiesTab()
        {
            Driver.FindElement(AddActivityButton).Click();
        }
        public void SelectActivityName(string activityName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, ActivityNameDropdown, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(ActivityNameDropdown), activityName);

        }
        public void ClickCreateActivitiesBtn()
        {
            Driver.FindElement(CreateActivityButton).Click();
        }
        public void ClickSaveActivitiesBtn()
        {
            Driver.FindElement(SaveActivityButton).Click();
        }
        public void ClickExitActivitiesBtn()
        {
            Driver.FindElement(ExitActivityButton).Click();
        }
        public void ClickCloseActivitiesBtn()
        {
            Driver.FindElement(CloseActivityButton).Click();
        }
    }
}
