using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages
{
    internal class FC_CaseTracking_LeadPage: BaseSettings
    {
        public FC_CaseTracking_LeadPage(IWebDriver driver) : base(driver) { }

        #region Elements
        //Add xpath here
        private readonly By LeadID = By.XPath("//input[@id='']");
        


        #endregion
    }
}
