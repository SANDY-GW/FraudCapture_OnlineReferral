using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class OnlineReferral_Referral_Page2 : BaseSettings
    {
        public OnlineReferral_Referral_Page2(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements

        private readonly By refTypeDropdn = By.XPath("//select[@id='referalType']");
        private readonly By involvedPartyTypeDropdn = By.XPath("//select[@id='involvedType']");
        private readonly By trackingNumberField = By.XPath("//input[@id='trackingNumber']");
        private readonly By detectedField = By.XPath("//input[@id='detected']");
        private readonly By referralSummaryField = By.XPath("//input[@id='referralSummary']");



        #endregion


        public void SelectRefType(string RefType)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, refTypeDropdn, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(refTypeDropdn), RefType);

        }

    }
}
