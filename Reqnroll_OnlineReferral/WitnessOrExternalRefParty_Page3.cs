using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral
{
    public class WitnessOrExternalRefParty_Page3 : BaseSettings
    {
        public WitnessOrExternalRefParty_Page3(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements

        private readonly By isExtRefDropdn = By.XPath("//select[@id='isExternalReferal']");
       



        #endregion

        public void SelectisExtRefType(string isExtRefAvailable)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, isExtRefDropdn, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(isExtRefDropdn), isExtRefAvailable);

        }

    }
}
