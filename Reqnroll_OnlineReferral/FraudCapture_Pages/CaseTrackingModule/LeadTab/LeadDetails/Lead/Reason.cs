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
            Driver.FindElement(leadReasonBtn).Click();
        }
        public void ClickCancel()
        {
            Driver.FindElement(cancelBtn).Click();
        }
        public void ClickSave()
        {
            Driver.FindElement(saveBtn).Click();

        }
        public void ClickEditCancel()
        {
            Driver.FindElement(editCancelBtn).Click();
        }
        public void ClickEditSave()
        {
            Driver.FindElement(editSaveBtn).Click();

        }
        public void EnterDescription(string description)
        {
            Driver.FindElement(descriptionTxt).SendKeys(description);
        }
        public void EnterComment(string comment)
        {
            Driver.FindElement(commentTxt).SendKeys(comment);
        }
        public void SelectReason(string reason)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(reasonDDL), reason);
        }
        public void SelectEditReason(string reason)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(editReasonDDL), reason);
        }
        public void SelectEditDetection(string detection)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(editDetectionDDL), detection);
        }
        public void SelectEditSourceType(string sourceType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(editSourceTypeDDL), sourceType);
        }
        public void SelectSourceType(string sourceType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(sourceTypeDDL), sourceType);
        }
        public void SelectDetection(string detection)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(detectionDDL), detection);
        }
        public void ClickAddReason()
        {
            Driver.FindElement(addReasongBtn).Click();
        }
        public void ClickDetectionMethod()
        {
            Driver.FindElement(detectionMethodField).Click();
        }
        public void ClickReason()
        {
            Driver.FindElement(reasonField).Click();
        }
        public void ClickCreator()
        {
            Driver.FindElement(creatorField).Click();
        }
        public void ClickDescription()
        {
            Driver.FindElement(descriptionField).Click();
        }
        public void ClickSource()
        {
            Driver.FindElement(sourceField).Click();
        }
        public void ClickReasonID()
        {
            Driver.FindElement(reasonIdField).Click();
        }
        public void ClickCreated()
        {
            Driver.FindElement(createdField).Click();
        }
       
    }
}
