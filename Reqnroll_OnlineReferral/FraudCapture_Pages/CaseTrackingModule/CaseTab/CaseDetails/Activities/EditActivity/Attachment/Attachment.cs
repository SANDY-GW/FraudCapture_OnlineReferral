using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Activities.EditActivity.Attachment
{
    internal class Attachment : BaseSettings
    {
        public Attachment(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By csvExport = By.XPath("//*[@id=\"attachment\"]/div[1]/button[2]");
        private readonly By downloadAttachmentManager = By.XPath("//*[@id=\"attachment\"]/div[1]/button[3]");
        private readonly By referesh = By.XPath("//*[@id=\"attachment\"]/div[1]/button[4]");
        private readonly By exitActivity = By.XPath("//*[@id=\"activitydetail\"]/div[1]/div[1]/button[1]");
        private readonly By otherActivityOptions = By.XPath("//*[@id=\"activitydetail\"]/div[1]/div[1]/button[1]");
        private readonly By addAttachment= By.XPath("//*[@id=\"attachment\"]/div[1]/button[5]");

        #endregion
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
        public void ClickExitActivity()
        {
            Driver.FindElement(exitActivity).Click();
        }
        public void ClickAddAttachment()
        {
            Driver.FindElement(addAttachment).Click();
        }
        public void SelectOtherActivityOptions(string options)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(otherActivityOptions), options);
        }
    }
}

