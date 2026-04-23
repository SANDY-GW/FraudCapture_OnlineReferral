using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Activities.AddActivity
{
    public class AddNewActivity : BaseSettings
    {
        public AddNewActivity(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By activityNameDDL = By.XPath("//*[@id=\"name\"]");
        private readonly By cancelBtn = By.XPath("//*[@id=\"activitydetail\"]/div/div[1]/button[1]");
        private readonly By continueBtn = By.XPath("//*[@id=\"activitydetail\"]/div/div[1]/button[2]/span");
        private readonly By exitActivity = By.XPath("//*[@id=\"activitydetail\"]/div[1]/div[1]/button[1]");
        private readonly By otherActivityOptionsDDL = By.XPath("//select[@id='activityOption']");

        private readonly By createDocument = By.XPath("//*[@id=\"createDocumentButton\"]");
        private readonly By saveDocumentStatus = By.XPath("//*[@id=\"document\"]/fc-activity-note-attachment-document/div[3]/div[2]/button");

        private readonly By csvExport = By.XPath("//*[@id=\"attachment\"]/div[1]/button[2]");
        private readonly By downloadAttachmentManager = By.XPath("//*[@id=\"attachment\"]/div[1]/button[3]");
        private readonly By referesh = By.XPath("//*[@id=\"attachment\"]/div[1]/button[3]");
        private readonly By addAttachment = By.XPath("//*[@id=\"attachment\"]/div[1]/button[3]");

        #endregion
        public void SelectActivityName(string activityName)
        {

            CommonHelpers.selectOptionByValue(Driver.FindElement(activityNameDDL), activityName);
        }
        public void ClickContinue()
        {
            Driver.FindElement(continueBtn).Click();
        }

        public void ClickCancel()
        {
            Driver.FindElement(cancelBtn).Click();
        }
        public void ClickExitActivity()
        {
            Driver.FindElement(exitActivity).Click();
        }
        public void SelectOtherActivityOptions(string options)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(otherActivityOptions), options);
        }
        public void ClickCreateDocument()
        {
            Driver.FindElement(createDocument).Click();
        }


        public void ClickSaveDocumentStatus()
        {
            Driver.FindElement(saveDocumentStatus).Click();
        }

        public void ClickCsvExport()
        {
            Driver.FindElement(csvExport).Click();
        }
        public void ClickAttachment()
        {
            Driver.FindElement(referesh).Click();
        }

        public void ClickDownloadAttachmentManager()
        {
            Driver.FindElement(downloadAttachmentManager).Click();
        }
       
        public void ClickAddAttachment()
        {
            Driver.FindElement(addAttachment).Click();
        }
       
    }
}
