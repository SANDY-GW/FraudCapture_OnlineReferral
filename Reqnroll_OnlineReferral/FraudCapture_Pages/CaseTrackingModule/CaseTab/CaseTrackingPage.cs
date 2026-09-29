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

        //public void GoTo()
        //{
        //    throw new NotImplementedException();
        //}

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

        public void ClickOnLatestCaseID()
        {
            throw new NotImplementedException();
        }

        public string GetCaseFromCaseGrid()
        {
           CommonHelpers.WaitForLoadingOverlayToDisappear(driver,100);
            //var tableRows = Driver.WrappedDriver.FindElements(NgBy.Repeater("p in caseList"));
            var tableRows = Driver.WrappedDriver.FindElements(By.XPath("//div[@id='allCaselist-wrapper']/descendant::table/tbody/tr"));
            var firstRow1 = tableRows[0];
            var firstRowData = firstRow1.FindElements(By.TagName("td"));
            var caseIDLink = firstRowData.ElementAt(1).FindElement(By.XPath(".//a"));
            var caseid = "";
            try
            {
                caseid = firstRowData.ElementAt(1).FindElement(By.XPath(".//a")).Text;
            }
            catch (Exception e) { }
            ScrollByElementCoordinates(caseIDLink);
            //caseIDLink.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            return caseid;
        }
    }
}
