using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public  class New_UI_Questions_Page5:BaseSettings
    {
        public New_UI_Questions_Page5(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements
        private readonly By Question1Dropdn = By.XPath("//select[@id='questiondDrDown1']");
        private By QuestionAnswerFieldbyIndex(int a) => By.XPath("//textarea[@id='questionTxt" + a + "']");
        private By QuestionDropdnbyIndex(int a) => By.XPath("//select[@id='questiondDrDown" + a + "']");
        private readonly By Question2 = By.XPath("//textarea[@id='questionTxt2']");
        private readonly By Question3 = By.XPath("//textarea[@id='questionTxt3']");
        private readonly By uploadFileArrow = By.XPath("//label[@id='fileLabel']//*[local-name()='svg']");
        private readonly By proceedToNextSessionButton = By.XPath("//button[@class='orangeBtn pull-right'][contains(text(),'Proceed to Next Session ')]");
        private readonly By Go_To_Previous_SectionButton = By.XPath("//*[contains(text(),'Go to Previous Section')]");
        private readonly By submitReferralButton = By.XPath("//button[contains(text(), 'Submit Referral')]");
        private readonly By enterNewReferral = By.XPath("//button[text()='Enter New Referral']");
        #endregion



        public void SelectQuestion1Option(string option)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Question1Dropdn, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(Question1Dropdn), option);
        }

        public void EnterAllQuestionAnswers()
        {
            //get all text area elements
            //Run a for loop for all the elements(count) identified above
            //if element exists then enter value in the text area
            var allTextFields= Driver.FindElements(By.XPath("//textarea[starts-with(@id,'questionTxt')]"));
            var allDropDowns = Driver.FindElements(By.XPath("//select[starts-with(@id,'questiondDrDown')]"));
            int n = 0;

            foreach (IWebElement ele in allTextFields)
            {
                ele.SendKeys("Test Answer"+n+1);
                               
            }
            //for (int i = 10; i >= allTextFields.Count-1; i--)
            //{
            //    if (Driver.FindElements(QuestionAnswerFieldbyIndex(i)).Any())
            //    {
            //        Driver.FindElement(QuestionAnswerFieldbyIndex(i)).Clear();
            //        Driver.FindElement(QuestionAnswerFieldbyIndex(i)).SendKeys("Test Answer " + i);
            //    }
            //}
            foreach(IWebElement ele in allDropDowns)
            {
                
                CommonHelpers.selectOptionByValue(ele, "Yes");
            }

        }

        public void EnterQuestion2Answer(string question2)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 500);");
            Driver.FindElement(Question2).SendKeys(question2);
        }

        public void EnterQuestion3Answer(string question3)
        {
           
            Driver.FindElement(Question3).SendKeys(question3);

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 700);");
        }

        const string JS_DROP_FILE = "for(var b=arguments[0],k=arguments[1],l=arguments[2],c=b.ownerDocument,m=0;;){var e=b.getBoundingClientRect(),g=e.left+(k||e.width/2),h=e.top+(l||e.height/2),f=c.elementFromPoint(g,h);if(f&&b.contains(f))break;if(1<++m)throw b=Error('Element not interractable'),b.code=15,b;b.scrollIntoView({behavior:'instant',block:'center',inline:'center'})}var a=c.createElement('INPUT');a.setAttribute('type','file');a.setAttribute('style','position:fixed;z-index:2147483647;left:0;top:0;');a.onchange=function(){var b={effectAllowed:'all',dropEffect:'none',types:['Files'],files:this.files,setData:function(){},getData:function(){},clearData:function(){},setDragImage:function(){}};window.DataTransferItemList&&(b.items=Object.setPrototypeOf([Object.setPrototypeOf({kind:'file',type:this.files[0].type,file:this.files[0],getAsFile:function(){return this.file},getAsString:function(b){var a=new FileReader;a.onload=function(a){b(a.target.result)};a.readAsText(this.file)}},DataTransferItem.prototype)],DataTransferItemList.prototype));Object.setPrototypeOf(b,DataTransfer.prototype);['dragenter','dragover','drop'].forEach(function(a){var d=c.createEvent('DragEvent');d.initMouseEvent(a,!0,!0,c.defaultView,0,0,0,g,h,!1,!1,!1,!1,0,null);Object.setPrototypeOf(d,null);d.dataTransfer=b;Object.setPrototypeOf(d,DragEvent.prototype);f.dispatchEvent(d)});a.parentElement.removeChild(a)};c.documentElement.appendChild(a);a.getBoundingClientRect();return a;";

        public void DropFile(IWebElement target, string filePath, double offsetX = 0, double offsetY = 0)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(filePath);

            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver;

            IWebElement input = (IWebElement)jse.ExecuteScript(JS_DROP_FILE, target, offsetX, offsetY);
            input.SendKeys(filePath);
        }
        /// <summary>
        /// Checks to see if the alert is displayed.
        /// </summary>
        public bool IsAlertDisplayed()
        {
            var alert = By.ClassName("close");
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

            try
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(alert));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
        public void CloseAlert()
        {
            var alert = By.ClassName("close");

            if (IsAlertDisplayed())
            {
                Driver.FindElement(alert).Click();
            }
        }
        private void WaitForAttachmentUpload(int seconds)
        {
            By alertDismissBtn = By.ClassName("close");
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(alertDismissBtn));
            CloseAlert();
        }
        public void ClickUploadFileArrow(string filepath)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 700);");

            CommonHelpers.WaitForElementVisiblity(Driver, uploadFileArrow,500);
           // Driver.FindElement(uploadFileArrow).Click();

            var fileUploadArea = Driver.FindElement(By.Id("fileLabel"));
           // var path = "C:/Users/jd/SourceQaDevelopment/Repos/FraudCapture_OnlineReferral/ReqnrollProject1/Attachments/";
            //Console.WriteLine(path);
            //var fileName = Path.Combine(path, "TestFile.txt");
            DropFile(fileUploadArea,filepath);
            //CommonHelpers.WaitForPageToLoad(Driver, 10000);
            
            js.ExecuteScript("window.scrollBy(0, 700);");
             CommonHelpers.WaitForPageLoading(Driver);
           


        }
        public void ClickProceedToNextSessionButton()
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            //js.ExecuteScript("window.scrollTo(0, 0);");
            //CommonHelpers.WaitForElementVisiblity(Driver, proceedToNextSessionButton, 10000);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            Driver.FindElement(proceedToNextSessionButton).Click();
            
            //CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 50000);
            //new CommonHelpers(Driver).WaitForPageLoading();
            //Thread.Sleep(5000);

            //Actions actions = new Actions(Driver);
            //actions.SendKeys(Keys.PageDown).Perform();
            //Thread.Sleep(5000);
            //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            //Thread.Sleep(5000);
            ////js.ExecuteScript("window.scrollBy(0, 1000);");
            ////new CommonHelpers(Driver).WaitForPageLoading();

            //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

            

            js.ExecuteScript("window.scrollTo(0, 0);");
            CommonHelpers.WaitForPageLoading(Driver);


            CommonHelpers.WaitForElementVisiblity(Driver, submitReferralButton, 1000);
            Driver.FindElement(submitReferralButton).Submit();
            CommonHelpers.WaitForPageLoading(Driver);


            //CommonHelpers.WaitForElementVisiblity(Driver, enterNewReferral, 5000);

        }




    }
}
