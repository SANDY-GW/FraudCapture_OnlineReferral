using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Lead
{
    public class Leads : BaseSettings
    {
        public Leads(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By BeginEditingBtn = By.XPath("//*[@id='caseViewEditEndButton']");
        private readonly By leadTab = By.XPath("//*[@id='LeadTabId']");
        private readonly By reasonField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[1]/small/div/span");
        private readonly By createField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[2]/small/div");

        private readonly By creatorField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[3]/small/div/span");
        private readonly By detectionMethodField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[4]/small/div/span");
        private readonly By sourceField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[5]/small/div/span");

        private readonly By primarySubject = By.XPath("//cdk-virtual-scroll-viewport[@id='caseSubjectNewScroll_table']/div[1]/table/thead/tr/th[1]/small/div/span");
        private readonly By subjectType = By.XPath("//cdk-virtual-scroll-viewport[@id='caseSubjectNewScroll_table']/div[1]/table/thead/tr/th[2]/small/div/span");
        private readonly By subjectName = By.XPath("//cdk-virtual-scroll-viewport[@id='caseSubjectNewScroll_table']/div[1]/table/thead/tr/th[3]/small/div/span");
        private readonly By streetAddress1 = By.XPath("//cdk-virtual-scroll-viewport[@id='caseSubjectNewScroll_table']/div[1]/table/thead/tr/th[4]/small/div/span");
        private readonly By streetAddress2 = By.XPath("//cdk-virtual-scroll-viewport[@id='caseSubjectNewScroll_table']/div[1]/table/thead/tr/th[5]/small/div/span");
        private readonly By city = By.XPath("//cdk-virtual-scroll-viewport[@id='caseSubjectNewScroll_table']/div[1]/table/thead/tr/th[6]/small/div/span");
        private readonly By stateOrTerritory = By.XPath("//cdk-virtual-scroll-viewport[@id='caseSubjectNewScroll_table']/div[1]/table/thead/tr/th[7]/small/div/span");
        private readonly By zipcode = By.XPath("//cdk-virtual-scroll-viewport[@id='caseSubjectNewScroll_table']/div[1]/table/thead/tr/th[8]/small/div/span");
        private readonly By id = By.XPath("//cdk-virtual-scroll-viewport[@id='caseSubjectNewScroll_table']/div[1]/table/thead/tr/th[9]/small/div/span");
        private readonly By masterId = By.XPath("//cdk-virtual-scroll-viewport[@id='caseSubjectNewScroll_table']/div[1]/table/thead/tr/th[10]/small/div/span");


        private readonly By descriptionField = By.XPath("//*[@id=\"recentActivity\"]/thead/tr/th[7]/small/div/span");
        private readonly By leadReasonTab = By.XPath("//*[@id='leadReasonTabId']");
        private readonly By leadSubjectTab = By.XPath("//*[@id='leadSubjectTabId']");
        private readonly By leadReferralTab = By.XPath("//*[@id='leadReferralTabId']");
        private readonly By leadPriorityTab = By.XPath("//*[@id='leadPriorityWizardTabId']");





        #endregion
        public void ClickBeginEditing()
        {
            driver.FindElement(BeginEditingBtn).Click();
        }
        public void SortReason()
        {
            driver.FindElement(reasonField).Click();
        }
        public void SortSource()
        {
            driver.FindElement(sourceField).Click();
        }
        public void SortDetectionMethod()
        {
            driver.FindElement(detectionMethodField).Click();
        }
        public void SortDescription()
        {
            driver.FindElement(descriptionField).Click();
        }
        public void SortCreator()
        {
            driver.FindElement(creatorField).Click();
        }
        public void SortPrimarySubject()
        {
            driver.FindElement(primarySubject).Click();
        }
        public void SortSubjectType()
        {
            driver.FindElement(subjectType).Click();

        }
        public void SortSubjectName()
        {
            driver.FindElement(subjectName).Click();
        }
        public void SortStreetAddress1()
        {
            driver.FindElement(streetAddress1).Click();

        }

        public void SortStreetAddress2()
        {
            driver.FindElement(streetAddress2).Click();
        }
        public void SortCity()
        {
            driver.FindElement(city).Click();

        }
        public void SortStateOrTerritory()
        {
            driver.FindElement(stateOrTerritory).Click();

        }
        public void SortID()
        {
            driver.FindElement(id).Click();

        }
        public void SortMasterID()
        {
            driver.FindElement(masterId).Click();

        }
        public void SortZipCode()
        {
            driver.FindElement(zipcode).Click();

        }

        public void SortCreated()
        {
            driver.FindElement(createField).Click();
        }
        public void ClickLeadTab()
        {
            driver.FindElement(leadTab).Click();
        }
        public void ClickLeadReasonTab()
        {
            driver.FindElement(leadReasonTab).Click();
        }
        public void ClickLeadSubjectTab()
        {
            driver.FindElement(leadSubjectTab).Click();
        }
        public void ClickLeadReferralTab()
        {
            driver.FindElement(leadReferralTab).Click();
        }
        public void ClickLeadPriorityTab()
        {
            driver.FindElement(leadPriorityTab).Click();
        }
    }
}
