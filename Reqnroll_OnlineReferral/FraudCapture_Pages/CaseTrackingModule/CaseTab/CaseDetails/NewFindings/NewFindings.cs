using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.NewFindings
{
    public class NewFindings : BaseSettings
    {
        public NewFindings(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By newFindingBtn = By.XPath("//*[@id=\"caseDetailsTab\"]/div[1]/ul/li[8]/button");

        #endregion

        public void ClickNewFindingsBtn()
        {
            Driver.FindElement(newFindingBtn).Click();
        }
    }
}
