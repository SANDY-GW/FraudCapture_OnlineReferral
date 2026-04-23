using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.DataQueryExtraction
{
    public class DataQueryExtraction : BaseSettings
    {
        public DataQueryExtraction(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By queryLibraryTab = By.XPath("//*[@id=\"queryLibraryTabId\"]/a");
        private readonly By newQueryBtn = By.XPath("//*[@id=\"tabQueryLibrary\"]/div/div[1]/div[1]/button[1]");
        private readonly By applyDynamicFilteringBtn = By.XPath("//*[@id=\"applyQueryDynamicId\"]/b");
        private readonly By categoryDDl = By.XPath("//*[@id=\"categoryType\"]");

        private readonly By categoryByDDL = By.XPath("//*[@id=\"userList\"]");
        private readonly By accessTypeDDL = By.XPath("//*[@id=\"queryType\"]");
        private readonly By reApplyDefaultFiltersBtn = By.XPath("//*[@id=\"reapplyQueryDefaultId\"]/b");
        private readonly By searchTxt = By.XPath("//*[@id=\"tabQueryLibrary\"]/div/div[2]/div/div/div[2]/input");
        private readonly By searchBtn = By.XPath("//*[@id=\"tabQueryLibrary\"]/div/div[2]/div/div/div[3]/button[1]");
        private readonly By clearBtn = By.XPath("//*[@id=\"tabQueryLibrary\"]/div/div[2]/div/div/div[3]/button[2]");

        private readonly By titleHeader = By.XPath("//*[@id=\"allReasonsTbl\"]/thead/tr/th[1]/small/div/span");

        private readonly By categoryHeader = By.XPath("//*[@id=\"allReasonsTbl\"]/thead/tr/th[2]/small/div/span");

        private readonly By categoryByHeader = By.XPath("//*[@id=\"allReasonsTbl\"]/thead/tr/th[3]/small/div/span");

        private readonly By accessHeader = By.XPath("//*[@id=\"allReasonsTbl\"]/thead/tr/th[4]/small/div/span");

        private readonly By lastRunByHeader = By.XPath("//*[@id=\"allReasonsTbl\"]/thead/tr/th[5]/small/div/span");

        private readonly By lastRunOnHeader = By.XPath("//*[@id=\"allReasonsTbl\"]/thead/tr/th[6]/small/div/span");

        private readonly By lastModifiedByHeader = By.XPath("//*[@id=\"allReasonsTbl\"]/thead/tr/th[7]/small/div/span");

        private readonly By lastModifiedOnHeader = By.XPath("//*[@id=\"allReasonsTbl\"]/thead/tr/th[8]/small/div/span");

        #endregion
        public void ClickLastModifiedOnHeader()
        {

            Driver.FindElement(lastModifiedOnHeader).Click();
        }
        public void ClickLastModifiedByHeader()
        {

            Driver.FindElement(lastModifiedByHeader).Click();
        }
        public void ClicklastRunOnHeader()
        {

            Driver.FindElement(lastRunOnHeader).Click();
        }
        public void ClickLastRunByHeader()
        {

            Driver.FindElement(lastRunByHeader).Click();
        }
        public void ClickAccessHeader()
        {

            Driver.FindElement(accessHeader).Click();
        }
        public void ClickCategoryByHeader()
        {

            Driver.FindElement(categoryByHeader).Click();
        }
        public void ClickCategoryHeader()
        {

            Driver.FindElement(categoryHeader).Click();
        }
        public void ClickTitleHeader()
        {

            Driver.FindElement(titleHeader).Click();
        }
        public void ClickSearch()
        {

            Driver.FindElement(searchBtn).Click();
        }
        public void ClickClear()
        {

            Driver.FindElement(clearBtn).Click();
        }
        public void EnterSearctValue(string value)
        {

            Driver.FindElement(searchTxt).SendKeys(value);
        }
        public void ClickReApplyDefaultFilters()
        {

            Driver.FindElement(reApplyDefaultFiltersBtn).Click();
        }
        public void SelectAccessType(string accessType)
        {

            CommonHelpers.selectOptionByValue(Driver.FindElement(accessTypeDDL), accessType);
        }
        public void SelectCatoegoryBy(string categoryBy)
        {

            CommonHelpers.selectOptionByValue(Driver.FindElement(categoryByDDL), categoryBy);
        }
        public void SelectCategory(string category)
        {

            CommonHelpers.selectOptionByValue(Driver.FindElement(categoryDDl), category);
        }

        public void ClickApplyDynamicFiltering()
        {

            Driver.FindElement(applyDynamicFilteringBtn).Click();
        }
        public void ClickNewQuery()
        {

            Driver.FindElement(newQueryBtn).Click();
        }
        public void ClickQueryLibrary()
        {

            Driver.FindElement(queryLibraryTab).Click();
        }
    }
}
