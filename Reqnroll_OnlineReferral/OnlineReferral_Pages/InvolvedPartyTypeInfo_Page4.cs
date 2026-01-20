using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class InvolvedPartyTypeInfo_Page4 : BaseSettings
    {
        public InvolvedPartyTypeInfo_Page4(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements
        private readonly By orgNameField = By.XPath("//input[@id='nepOrgName']");



        #endregion


        public void SelectRefType(string OrgName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, orgNameField, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(orgNameField), OrgName);

        }

    }
}
