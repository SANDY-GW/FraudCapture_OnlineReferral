using OpenQA.Selenium;
using System;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab
{
    /// <summary>
    /// Page object for Case Tracking actions used by <see cref="CaseEditPage"/>.
    /// </summary>
    public class CaseTrackingPage : BaseSettings
    {
        public CaseTrackingPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            throw new NotImplementedException();
        }

        public void ShowCases()
        {
            throw new NotImplementedException();
        }

        public void SwitchCasesUser(string userData)
        {
            throw new NotImplementedException();
        }

        public void SearchByCaseID()
        {
            throw new NotImplementedException();
        }

        public void SearchOnAllCasesGrid(string caseIdData)
        {
            throw new NotImplementedException();
        }

        public void SelectCase(string caseIdData, CaseEditPage caseEditPage)
        {
            throw new NotImplementedException();
        }
    }
}
