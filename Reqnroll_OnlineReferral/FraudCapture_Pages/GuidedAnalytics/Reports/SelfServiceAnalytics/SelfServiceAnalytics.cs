using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.Reports.SelfServiceAnalytics
{
    public class SelfServiceAnalytics : BaseSettings
    {
        public SelfServiceAnalytics(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By ReportsTab = By.XPath("//a[contains(text(),'Reports')]");
        private readonly By SelfServiceAnalyticsTab = By.XPath("//button[contains(text(),'Self Service Analytics')]");
        private readonly By CreatedByUserList = By.XPath("//select[@id='userListcl']");
        private readonly By AccessBy = By.XPath("//select[@id='queryType']");
        private readonly By SelfServiceAnalyticsSearch = By.XPath("(//div/button[@class='greyBtn'])[1]");
        private readonly By SelfServiceAnalyticsClear = By.XPath("//div/button[@class='greyBtn ps-0']");
        private readonly By SelfServiceAnalyticsSearchTextbox = By.XPath("//input[@class='form-control ng-pristine ng-valid ng-touched']");
        private readonly By Title = By.XPath(" (//div/span[contains(text(),'Title')])[2]");
        private readonly By Access = By.XPath(" (//span[contains(text(),'Access')])[1]");
        private readonly By CreatedBy = By.XPath("(//span[contains(text(),'Created By ')])[1]");
        private readonly By LastModifiedBy = By.XPath("(//span[contains(text(),' Last Modified By')])[1]");
        private readonly By LastModifiedOn = By.XPath("(//span[contains(text(),' Last Modified On')])[1]");

        


        #endregion
        public void ClickReportsTab()
        {
            Driver.FindElement(ReportsTab).Click();
        }
        public void ClickSelfServiceTab()
        {
            Driver.FindElement(SelfServiceAnalyticsTab).Click();
        }
            public void SelectCreatedByUserList(string CreatedByUser )
        {
            CommonHelpers.WaitForElementVisiblity(Driver, CreatedByUserList, 120);
            CommonHelpers.selectOptionByValue(Driver.FindElement(CreatedByUserList), CreatedByUser);

        }
        public void SelectAccessByList(string AccessByList)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, CreatedByUserList, 120);
            CommonHelpers.selectOptionByValue(Driver.FindElement(AccessBy), AccessByList);

        }

        public void EnterSelfServiceAnalyticsTextbox(string searchTextboxValue)
        {
            Driver.FindElement(SelfServiceAnalyticsSearchTextbox).SendKeys(searchTextboxValue);
        }
        public void ClickSelfServiceAnalyticsSearch()
        {
            Driver.FindElement(SelfServiceAnalyticsSearch).Click();
        }
        public void ClickSelfServiceAnalyticsClear()
        {
            Driver.FindElement(SelfServiceAnalyticsClear).Click();
        }
        public void ClickTitle()
        {
            Driver.FindElement(Title).Click();
        }
        public void ClickAccess()
        {
            Driver.FindElement(Access).Click();
        }
        public void ClickCreatedBy()
        {
            Driver.FindElement(CreatedBy).Click();
        }
        public void ClickLastModifiedBy()
        {
            Driver.FindElement(LastModifiedBy).Click();
        }
        public void ClickLastModifiedOn()
        {
            Driver.FindElement(LastModifiedOn).Click();
        }



    }
    
}
