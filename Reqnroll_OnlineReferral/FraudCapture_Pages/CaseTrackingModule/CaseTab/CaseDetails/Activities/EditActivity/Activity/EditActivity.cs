using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Activities.EditActivity.Activity
{
    public class EditActivity : BaseSettings
    {
        public EditActivity(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By activityBtn = By.XPath("//*[@id=\"activityDetailTabId\"]");
        private readonly By documentGenerationBtn = By.XPath("//*[@id=\"documentGenerationTabId\"]");
        private readonly By attachmentBtn = By.XPath("//*[@id=\"attachmentTabId\"]");
        private readonly By exitActivity = By.XPath("//*[@id=\"activitydetail\"]/div[1]/div[1]/button[1]");
        private readonly By otherActivityOptions = By.XPath("//*[@id=\"activitydetail\"]/div[1]/div[1]/button[1]");
        private readonly By searchClearBtn = By.XPath("//*[@id=\"searchClearButton\"]");

        #endregion
        public void ClickActivity()
        {
            Driver.FindElement(activityBtn).Click();
        }
        public void ClickAttachment()
        {
            Driver.FindElement(attachmentBtn).Click();
        }
        
        public void ClickDocumentGeneration()
        {
            Driver.FindElement(documentGenerationBtn).Click();
        }
        public void ClickExitActivity()
        {
            Driver.FindElement(exitActivity).Click();
        }
        public void SelectOtherActivityOptions(string options)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(otherActivityOptions), options);
        }
    }
}

