using OpenQA.Selenium;

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
            new CaseTracking_CasePage(driver).ClickCaseTab();
        }


        public void ShowCases()
        {
            new CaseTracking_CasePage(driver).ClickCaseTab();
        }

        public void SwitchCasesUser(string userData)
        {
            new CaseTracking_CasePage(driver).SelectCaseAssignedTo(userData);
        }

        public void SearchByCaseID()
        {
            new CaseTracking_CasePage(driver).SelectCaseSearchCriteriaOption("Case ID");
        }

        public void SearchOnAllCasesGrid(string caseIdData)
        {
            var casePage = new CaseTracking_CasePage(driver);
            casePage.EnterCaseSearchCriteria(caseIdData);
            casePage.ClickCaseSearchCriteriaSearchBtn();
        }

        public void SelectCase(string caseIdData, CaseEditPage caseEditPage)
        {
            CommonHelpers.WaitForPageLoading(driver);
            var caseIdLink = By.XPath($"//*[@id='allCaselist-wrapper']//div[1]/table//tr/td[2]//a[normalize-space()='{caseIdData}']");
            driver.FindElement(caseIdLink).Click();
            CommonHelpers.SwitchtoNewWindow(driver);
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
