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
            Driver.FindElement(BeginEditingBtn).Click();
        }
        public void SortReason()
        {
            Driver.FindElement(reasonField).Click();
        }
        public void SortSource()
        {
            Driver.FindElement(sourceField).Click();
        }
        public void SortDetectionMethod()
        {
            Driver.FindElement(detectionMethodField).Click();
        }
        public void SortDescription()
        {
            Driver.FindElement(descriptionField).Click();
        }
        public void SortCreator()
        {
            Driver.FindElement(creatorField).Click();
        }
        public void SortPrimarySubject()
        {
            Driver.FindElement(primarySubject).Click();
        }
        public void SortSubjectType()
        {
            Driver.FindElement(subjectType).Click();

        }
        public void SortSubjectName()
        {
            Driver.FindElement(subjectName).Click();
        }
        public void SortStreetAddress1()
        {
            Driver.FindElement(streetAddress1).Click();

        }

        public void SortStreetAddress2()
        {
            Driver.FindElement(streetAddress2).Click();
        }
        public void SortCity()
        {
            Driver.FindElement(city).Click();

        }
        public void SortStateOrTerritory()
        {
            Driver.FindElement(stateOrTerritory).Click();

        }
        public void SortID()
        {
            Driver.FindElement(id).Click();

        }
        public void SortMasterID()
        {
            Driver.FindElement(masterId).Click();

        }
        public void SortZipCode()
        {
            Driver.FindElement(zipcode).Click();

        }

        public void SortCreated()
        {
            Driver.FindElement(createField).Click();
        }
        public void ClickLeadTab()
        {
            Driver.FindElement(leadTab).Click();
        }
        public void ClickLeadReasonTab()
        {
            Driver.FindElement(leadReasonTab).Click();
        }
        public void ClickLeadSubjectTab()
        {
            Driver.FindElement(leadSubjectTab).Click();
        }
        public void ClickLeadReferralTab()
        {
            Driver.FindElement(leadReferralTab).Click();
        }
        public void ClickLeadPriorityTab()
        {
            Driver.FindElement(leadPriorityTab).Click();
        }
    }
}
