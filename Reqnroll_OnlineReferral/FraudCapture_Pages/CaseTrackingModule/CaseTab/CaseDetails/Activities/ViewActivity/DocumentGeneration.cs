using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Activities.ViewActivity.DocumentGeneration
{
    public class DocumentGeneration : BaseSettings
    {
        public DocumentGeneration(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By createDocument = By.XPath("//*[@id=\"createDocumentButton\"]");
        private readonly By saveDocumentStatus = By.XPath("//*[@id=\"document\"]/fc-activity-note-attachment-document/div[3]/div[2]/button");
        private readonly By exitActivity = By.XPath("//*[@id=\"activitydetail\"]/div[1]/div[1]/button[1]");

        #endregion
        public void ClickCreateDocument()
        {
            Driver.FindElement(createDocument).Click();
        }


        public void ClickSaveDocumentStatus()
        {
            Driver.FindElement(saveDocumentStatus).Click();
        }
        public void ClickExitActivity()
        {
            Driver.FindElement(exitActivity).Click();
        }


    }
}
