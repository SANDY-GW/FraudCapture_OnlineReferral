using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.ActivityTab.WorkLoadReassignement
{
    public class ActivityWorkloadReassignment : BaseSettings
    {
        public ActivityWorkloadReassignment(IWebDriver driver) : base(driver) { }

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
            Driver.FindElement(WorkLoadReassignment).Click();
        }
        public void ClickCancle()
        {
            Driver.FindElement(CancelBtn).Click();
        }
        public void ClickYes()
        {
            Driver.FindElement(YesBtn).Click();
        }
        public void ClickPopupCancel()
        {
            Driver.FindElement(PopUpCancelBtn).Click();
        }
        public void ClickReassign()
        {
            Driver.FindElement(ReassignBtn).Click();
        }
        public void SelectWorkLoadReassignmentOption(string option)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(SelectWorkLoadReassignmentOptionDDL), option);
        }
        public void SelectWorkLoadReassignmentAssignedTo(string assignedTo)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(SelectWorkLoadReassignmentAssignedToDDL), assignedTo);
        }
        public void SelectWorkLoadReassignmentCaseUser(string caseUser)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(SelectWorkLoadReassignmentCaseUserDDL), caseUser);
        }
    }
}
