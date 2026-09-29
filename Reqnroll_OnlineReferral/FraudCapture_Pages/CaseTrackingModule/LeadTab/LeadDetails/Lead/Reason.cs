using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead
{
    public class Reason : BaseSettings
    {
        public Reason(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By leadReasonBtn = By.XPath("//*[@id='leadReasonTabId']");
        private readonly By reasonIdField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[1]/small/div/span");
        private readonly By createdField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[2]/small/div/span");
        private readonly By creatorField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[3]/small/div/span");
        private readonly By detectionMethodField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[4]/small/div/span");
        private readonly By sourceField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[5]/small/div/span");
        private readonly By reasonField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[6]/small/div/span");
        private readonly By descriptionField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[3]/small/div/span");

        private readonly By addReasongBtn = By.XPath("//*[@id='leadReasonAddButton']");
        private readonly By detectionDDL = By.XPath("//*[@id='detectionId']");
        private readonly By sourceTypeDDL = By.XPath("//*[@id='dropdownMenuLeadSourceType']");
        private readonly By reasonDDL = By.XPath("//*[@id='dropdownMenuLeadReason']");
        private readonly By descriptionTxt = By.XPath("//*[@id=\"description\"]/div[3]/div");
        private readonly By commentTxt = By.XPath("//*[@id='comment']");
        private readonly By cancelBtn = By.XPath("//*[@id=\"AddLeadReasonModal\"]/div/div[2]/div/button[1]");
        private readonly By saveBtn = By.XPath("//*[@id=\"AddLeadReasonModal\"]/div/div[2]/div/button[2]");

        private readonly By editDetectionDDL = By.XPath("//*[@id=\"sourceNR\"]");
        private readonly By editSourceTypeDDL = By.XPath("//*[@id=\"dropdownMenuLeadSourceType\"]");
        private readonly By editReasonDDL = By.XPath("//*[@id=\"dropdownMenuLeadReason\"]");
        private readonly By editDescriptionTxt = By.XPath("//*[@id=\"description\"]/div[3]/div");
       
        private readonly By editCancelBtn = By.XPath("//*[@id=\"EditLeadReasonModal\"]/div[2]/div/div/button[1]");
        private readonly By editSaveBtn = By.XPath("//*[@id=\"EditLeadReasonModal\"]/div[2]/div/div/button[2]");

        #endregion
        public void ClickLeadReason()
        {
            driver.FindElement(leadReasonBtn).Click();
        }
        public void ClickCancel()
        {
            driver.FindElement(cancelBtn).Click();
        }
        public void ClickSave()
        {
            driver.FindElement(saveBtn).Click();

        }
        public void ClickEditCancel()
        {
            driver.FindElement(editCancelBtn).Click();
        }
        public void ClickEditSave()
        {
            driver.FindElement(editSaveBtn).Click();

        }
        public void EnterDescription(string description)
        {
            driver.FindElement(descriptionTxt).SendKeys(description);
        }
        public void EnterComment(string comment)
        {
            driver.FindElement(commentTxt).SendKeys(comment);
        }
        public void SelectReason(string reason)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(reasonDDL), reason);
        }
        public void SelectEditReason(string reason)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(editReasonDDL), reason);
        }
        public void SelectEditDetection(string detection)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(editDetectionDDL), detection);
        }
        public void SelectEditSourceType(string sourceType)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(editSourceTypeDDL), sourceType);
        }
        public void SelectSourceType(string sourceType)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(sourceTypeDDL), sourceType);
        }
        public void SelectDetection(string detection)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(detectionDDL), detection);
        }
        public void ClickAddReason()
        {
            driver.FindElement(addReasongBtn).Click();
        }
        public void ClickDetectionMethod()
        {
            driver.FindElement(detectionMethodField).Click();
        }
        public void ClickReason()
        {
            driver.FindElement(reasonField).Click();
        }
        public void ClickCreator()
        {
            driver.FindElement(creatorField).Click();
        }
        public void ClickDescription()
        {
            driver.FindElement(descriptionField).Click();
        }
        public void ClickSource()
        {
            driver.FindElement(sourceField).Click();
        }
        public void ClickReasonID()
        {
            driver.FindElement(reasonIdField).Click();
        }
        public void ClickCreated()
        {
            driver.FindElement(createdField).Click();
        }
       
    }
}
