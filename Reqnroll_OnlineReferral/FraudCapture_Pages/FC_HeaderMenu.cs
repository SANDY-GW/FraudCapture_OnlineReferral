using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages
{
    public class FC_HeaderMenu: BaseSettings
    {
        public FC_HeaderMenu(IWebDriver driver) : base(driver) { }
        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        private readonly By payorDropField = By.XPath("//ul[@id='payorSelector']");
        private readonly By payorDemo = By.XPath("//a[@id='DEMO']");
        
        public void SelectPayor(string Payor)
        {
            var payorDropField = By.XPath("//ul[@id='payorSelector']");
            CommonHelpers.WaitForElementVisiblity(Driver, payorDropField, 10);
            Driver.FindElement(payorDropField).Click();
            var payorOption = Driver.FindElement(By.XPath("//a[@id='" + Payor + "']"));
            payorOption.Click();
        }
    }
}
