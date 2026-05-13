using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.LinkAnalysis.ExploreNewGraph
{
    public class ExploreNewGraph : BaseSettings
    {
        public ExploreNewGraph(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By LinkAnalysisTab = By.XPath("//a[contains(text(),'Link Analysis')]");
        private readonly By ExploreNewGraphBtn = By.XPath("//button[contains(text(),'Explore New Graph')]");
        private readonly By RefreshBtn = By.XPath("//button[contains(text(),'Refresh')]");
        private readonly By SearchCriteriaDropDown = By.XPath("//select[@id='searchCriteriaDropdown']");
        private readonly By ProviderIDValue = By.XPath("//input[@id='addNodeField']");
        private readonly By PlusSymbol = By.XPath("//div[@class='input-group']");
        private readonly By BackButton = By.XPath("//button[@id='BackButton']");
        private readonly By SaveButton = By.XPath("//button[@id='SnapshotButton']");
        private readonly By UndoButton = By.XPath("//button[@id='UndoButton']");
        private readonly By RedoButton = By.XPath("//button[@id='RedoButton']");
        private readonly By ClearButton = By.XPath("//button[@id='ClearButton']");
        private readonly By ShowHiddenTimeBar = By.XPath("//button[@id='ShowHideTimeBarButton']");
        private readonly By ExportDropDown = By.XPath("//button[@class='btn btn-secondary dropdown-toggle orangeBtn btn-height-100 height-fill display-single-line text-nowrap']");
        private readonly By MemberListValue = By.XPath("//li[contains(text(),'Member List')]");
        private readonly By ProviderListValue = By.XPath("//li[contains(text(),'Provider List')]");
        private readonly By FullScreenButton = By.XPath("//button[@id='FullScreenButton']");
        private readonly By StandardViewButton = By.XPath("//button[@id='StandardViewButton']");
        private readonly By HierarchyViewButton = By.XPath("//button[@id='HierarchyViewButton']");
        private readonly By RadialViewButton = By.XPath("//button[@id='RadialViewButton']");
        private readonly By LensViewButton = By.XPath("//button[@id='LensViewButton']");
        private readonly By SequentialViewButton = By.XPath("//button[@id='SequentialViewButton']");
        private readonly By MapViewButton = By.XPath("//button[@id='MapViewButton']");
        private readonly By HighlightButton = By.XPath("//button[@id='HighlightButton']");
        private readonly By RegularViewButton = By.XPath("//button[@id='RegularViewButton']");
        private readonly By CustomViewButton = By.XPath("//button[@id='CustomViewButton']");
        private readonly By CombineButton = By.XPath("//button[@id='CombineButton']");
        private readonly By UnCombineButton = By.XPath("//button[@id='UncombineButton']");


        #endregion
        public void ClickLinkAnalysisTab()
        {
            Driver.FindElement(LinkAnalysisTab).Click();
        }
        public void ClickExploreNewGraphBtn()
        {
            Driver.FindElement(ExploreNewGraphBtn).Click();
        }
        public void ClickRefreshBtn()
        {
            Driver.FindElement(RefreshBtn).Click();
        }
        public void ClickSearchCriteriaDropDown(string searchCriteria)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, SearchCriteriaDropDown, 120);
            CommonHelpers.selectOptionByValue(Driver.FindElement(SearchCriteriaDropDown), searchCriteria);
        }
        public void EnterProviderIDValue(string providerID)
        {
            Driver.FindElement(ProviderIDValue).SendKeys(providerID);
        }
        public void ClickPlusSymbol()
        {
            Driver.FindElement(PlusSymbol).Click();
        }
        public void ClickBackButton()
        {
            Driver.FindElement(BackButton).Click();

        }
        public void ClickSaveButton()
        {
            Driver.FindElement(SaveButton).Click();
        }
        public void UndoButtonClick()
        {
            Driver.FindElement(UndoButton).Click();
        }
        public void RedoButtonClick()
        {
            Driver.FindElement(RedoButton).Click();
        }
        public void ClearButtonClick()
        {
            Driver.FindElement(ClearButton).Click();
        }
        public void ShowHiddenTimeBarClick()
        {
            Driver.FindElement(ShowHiddenTimeBar).Click();
        }
        public void ClickExportDropDown()
        {
            Driver.FindElement(ExportDropDown).Click();
        }
        public void ClickMemberListValue()
        {
            Driver.FindElement(MemberListValue).Click();
        }
        public void ClickProviderListValue()
        {
            Driver.FindElement(ProviderListValue).Click();
        }
        public void ClickFullScreenButton()
        {
            Driver.FindElement(FullScreenButton).Click();
        }
        public void ClickStandardViewButton()
        {
            Driver.FindElement(StandardViewButton).Click();
        }
        public void ClickHierarchyViewButton()
        {
            Driver.FindElement(HierarchyViewButton).Click();
        }
        public void ClickRadialViewButton()
        {
            Driver.FindElement(RadialViewButton).Click();
        }
        public void ClickLensViewButton()
        {
            Driver.FindElement(LensViewButton).Click();
        }
        public void ClickSequentialViewButton()
        {
            Driver.FindElement(SequentialViewButton).Click();
        }
        public void ClickMapViewButton()
        {
            Driver.FindElement(MapViewButton).Click();
        }
        public void ClickHighlightButton()
        {
            Driver.FindElement(HighlightButton).Click();
        }
        public void ClickRegularViewButton()
        {
            Driver.FindElement(RegularViewButton).Click();
        }
        public void ClickCustomViewButton()
        {
            Driver.FindElement(CustomViewButton).Click();
        }
        public void ClickCombineButton()
        {
            Driver.FindElement(CombineButton).Click();
        }
        public void ClickUnCombineButton()
        {
            Driver.FindElement(UnCombineButton).Click();
        }

    }

    }
