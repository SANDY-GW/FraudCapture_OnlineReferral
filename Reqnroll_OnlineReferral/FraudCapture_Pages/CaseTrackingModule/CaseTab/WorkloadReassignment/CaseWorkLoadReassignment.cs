using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.WorkloadReassignment
{
    public class CaseWorkLoadReassignment : BaseSettings
    {
        public CaseWorkLoadReassignment(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By WorkLoadReassignment = By.XPath("//*[@id='reassignUserCaseTabId']/b");
        private readonly By SelectWorkLoadReassignmentOptionDDL = By.XPath("//*[@id='option']");
        private readonly By SelectWorkLoadReassignmentAssignedToDDL = By.XPath("//*[@id='assignTo']");
        private readonly By SelectWorkLoadReassignmentCaseUserDDL = By.XPath("//*[@id='dropdownMenuCaseUser']");

        private readonly By CancelBtn = By.XPath("//*[@id='ReAssignUser']/div/div[2]/button[1]");
        private readonly By ReassignBtn = By.XPath("//*[@id='btnOk']");

        private readonly By YesBtn = By.XPath("//div/fc-app-confirmation/div[3]/button[2]");
        private readonly By PopUpCancelBtn = By.XPath("///div/fc-app-confirmation/div[3]/button[1]");

        #endregion
        public void ClickWorkLoadREassignmentBtn()
        {
            driver.FindElement(WorkLoadReassignment).Click();
        }
        public void ClickCancle()
        {
            driver.FindElement(CancelBtn).Click();
        }
        public void ClickYes()
        {
            driver.FindElement(YesBtn).Click();
        }
        public void ClickPopupCancel()
        {
            driver.FindElement(PopUpCancelBtn).Click();
        }
        public void ClickReassign()
        {
            driver.FindElement(ReassignBtn).Click();
        }
        public void SelectWorkLoadReassignmentOption(string option)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(SelectWorkLoadReassignmentOptionDDL), option);
        }
        public void SelectWorkLoadReassignmentAssignedTo(string assignedTo)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(SelectWorkLoadReassignmentAssignedToDDL), assignedTo);
        }
        public void SelectWorkLoadReassignmentCaseUser(string caseUser)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(SelectWorkLoadReassignmentCaseUserDDL), caseUser);
        }

    }
}
