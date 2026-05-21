using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.LinkAnalysis
{
    public class LinkAnalysis : BaseSettings
    {
        public LinkAnalysis(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By LinkAnalysisTab = By.XPath("//a[contains(text(),'Link Analysis')]");
        private readonly By CreatedBy = By.XPath("//select[@id='createdBy']");
        private readonly By AccessType = By.XPath("//select[@id='accessType']");
        private readonly By LinkAnalysisSearch = By.XPath("(//button[@id='searchStartButton'])[2]");
        private readonly By LinkAnalysisClear = By.XPath("(//button[@id='searchClearButton'])[2]");
        private readonly By LinkAnalysisSearchTextbox = By.XPath("(//input[@id='searchInputField'])[2]");
        private readonly By TitleLabel = By.XPath("(//span[contains(text(),' Title')])[3]");
        private readonly By CreatedByLabel = By.XPath("//span[contains(text(),' Created By ')]");
        private readonly By AccessLabel = By.XPath("//span[contains(text(),' Access')]");
        private readonly By LastModifiedByLabel = By.XPath("//span[contains(text(),' Last Modified By ')]");
        private readonly By LastModifiedDateLabel = By.XPath("//span[contains(text(),' Last Modified Date')]");

        #endregion
        public void ClickLinkAnalysisTab()
        {
            Driver.FindElement(LinkAnalysisTab).Click();
        }

        public void ClickCreatedByDropDown()
        {
            Driver.FindElement(CreatedBy).Click();
        }
        public void ClickAccessTypeDropDown()
        {
            Driver.FindElement(AccessType).Click();
        }
        public void ClickLinkAnalysisSearchBtn()
        {
            Driver.FindElement(LinkAnalysisSearch).Click();
        }
        public void ClickLinkAnalysisClearBtn()
        {
            Driver.FindElement(LinkAnalysisClear).Click();
        }
        public void EnterLinkAnalysisSearchTextbox(string searchTextboxValue)
        {
            Driver.FindElement(LinkAnalysisSearchTextbox).SendKeys(searchTextboxValue);
        }
         public void ClickTitleLabel()
        {
            Driver.FindElement(TitleLabel).Click();
        }
        public void ClickCreatedByLabel()
        {
            Driver.FindElement(CreatedByLabel).Click();
        }
        public void ClickAccessTypeLabel()
        {
            Driver.FindElement(AccessLabel).Click();
        }
        public void ClickLastModifiedByLabel()
        {
            Driver.FindElement(LastModifiedByLabel).Click();
        }
        public void ClickLastModifiedDateLabel()
        {
            Driver.FindElement(LastModifiedDateLabel).Click();
        }
         

    }
}
