using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class ResponseToQuestions_Page5 : BaseSettings
    {
        public ResponseToQuestions_Page5(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements
        private readonly By doesThisReferralInvolveSpecificPatientDropdn = By.XPath("//select[@id='vpIsParticipant']");
        private readonly By IstheMemberSamePersonAsTheWitnessPartyDropdn = By.XPath("//select[@id='vpIsreferring']");
        private readonly By patientFNfield = By.XPath("//input[@id='paFirstName']");
        private readonly By patientLNfield = By.XPath("//input[@id='paLastName']");
        private readonly By memberIDfield = By.XPath("//input[@id='paID']");
        private readonly By dateOfBirthfield = By.XPath("//input[@name='paDOB']");
        private readonly By program_Or_Plan_Type_Field = By.XPath("//input[@id='paPlanType']");
        private readonly By phoneNumberField = By.XPath("//input[@id='paPhone']");
        private readonly By emailField = By.XPath("//input[@id='paEmail']");
        private readonly By address1Field = By.XPath("//input[@id='paAddress1']");
        private readonly By address2Field = By.XPath("//input[@id='paAddress2']");
        private readonly By cityField = By.XPath("//input[@id='paCity']");
        private readonly By stateDropdown = By.XPath("//select[@id='paState']");
        private readonly By countyDropdown = By.XPath("//select[@id='paCounty']");
        private readonly By zipCodeField = By.XPath("//input[@id='paZip']");
        private readonly By countryField = By.XPath("//input[@id='paCountry']");
        private readonly By proceed_To_Next_SectionButton = By.XPath("//button[text()='Proceed to Next Section']");
        private readonly By Go_To_Previous_SectionButton = By.XPath("//b[text()='Go to Previous Section']");

        private readonly By question1dropdwn = By.XPath("//select[@id='questiondDrDown1']");
        private readonly By question1TextBox = By.XPath("//textarea[@id='questionTxt1']");

        private readonly By question2TextBox = By.XPath("//textarea[@id='questionTxt2']");
        private readonly By question3Dropdwn = By.XPath("//select[@id='questiondDrDown3']");
        private readonly By question4TextBox = By.XPath("//textarea[@id='questionTxt4']");
        private readonly By question5Dropdwn = By.XPath("//select[@id='questiondDrDown5']");
        private readonly By question6TextBox = By.XPath("//textarea[@id='questionTxt6']");
        private readonly By submitReferralButton = By.XPath("//button[text()=' Submit Referral ']");
        private readonly By enterNewReferral = By.XPath("//button[text()='Enter New Referral']");
        private readonly By attachmentUploadMessage = By.XPath("//*[contains(normalize-space(text()), 'File(s) upload is in progress')]");
        private readonly By attachmentUploadSpinner = By.XPath("//*[contains(normalize-space(text()), 'Loading...')]");
        private readonly By attachmentFileNameHeader = By.XPath("//*[normalize-space(text())='File Name']");
        private readonly By attachmentStatusHeader = By.XPath("//*[normalize-space(text())='Status']");
        private readonly By attachmentUploadStatus = By.XPath("//*[contains(normalize-space(text()), 'Upload complete') or contains(normalize-space(text()), 'Upload is progress') or contains(normalize-space(text()), 'Upload in progress')]");
        private readonly By attachmentCorrectionWorkflow = By.XPath("//*[contains(translate(normalize-space(text()), 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), 'attachment') and (contains(translate(normalize-space(text()), 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), 'error') or contains(translate(normalize-space(text()), 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), 'correct'))]");

        #endregion

        public void SelectDoesThisReferralInvolveSpecificPatient(string doesThisReferralInvolveSpecificPatient)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, doesThisReferralInvolveSpecificPatientDropdn, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(doesThisReferralInvolveSpecificPatientDropdn), doesThisReferralInvolveSpecificPatient);
        }

        public void SelectIsThisPersonSameASWitness_Or_ExternalParty(string isThePersonsameAswitnessParty)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, IstheMemberSamePersonAsTheWitnessPartyDropdn, 50);
            CommonHelpers.selectOptionByValue(Driver.FindElement(IstheMemberSamePersonAsTheWitnessPartyDropdn), isThePersonsameAswitnessParty);

        }


        public void EnterPatientFirstName(string patientFirstName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, patientFNfield, 10);
            Driver.FindElement(patientFNfield).SendKeys(patientFirstName);
        }
        public void EnterPatientLastName(string patientLastName)
        {
            Driver.FindElement(patientLNfield).SendKeys(patientLastName);

        }

        public void EnterMemberID(string memberID)
        {
            Driver.FindElement(memberIDfield).SendKeys(memberID);
        }
        public void EnterDateOfBirth(string dateOfBirth)
        {
            Driver.FindElement(dateOfBirthfield).SendKeys(dateOfBirth);
        }

        public void EnterProgram_Or_Plan_Type(string program_Or_Plan_Type)
        {
            Driver.FindElement(program_Or_Plan_Type_Field).SendKeys(program_Or_Plan_Type);
        }
        public void EnterPhoneNumber(string phoneNumber)
        {
            Driver.FindElement(phoneNumberField).SendKeys(phoneNumber);
        }
        public void EnterEmail(string email)
        {
            Driver.FindElement(emailField).SendKeys(email);
        }

        public void EnterAddress1(string address1)
        {
            Driver.FindElement(address1Field).SendKeys(address1);

        }
        public void EnterAddress2(string address2)
        {
            Driver.FindElement(address2Field).SendKeys(address2);
        }
        public void EnterCity(string city)
        {
            Driver.FindElement(cityField).SendKeys(city);
        }

        public void SelectState(string state)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(stateDropdown), state);
        }
        public void SelectCounty(string county)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(countyDropdown), county);
        }

        public void EnterZipCode(string zipCode)
        {
            Driver.FindElement(zipCodeField).SendKeys(zipCode);
        }
        public void EnterCountry(string country)
        {
            Driver.FindElement(countryField).SendKeys(country);
        }

        public void SelectQuestion1Dropdown(string question1)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.ScrollToElement(Driver, question1dropdwn);
            CommonHelpers.WaitForElementVisiblity(Driver, question1dropdwn,20);
            
            Driver.FindElement(question1dropdwn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(question1dropdwn), question1);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 100);");
        }
        public void SelectQuestion1Test(string answer)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, question1TextBox, 100);
            Driver.FindElement(question1TextBox).SendKeys(answer);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0, 100);");
        }

        public void EnterQuestion2(string question2)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            Driver.FindElement(question2TextBox).Click();          
            Driver.FindElement(question2TextBox).SendKeys(question2);
        }
        public void SelectQuestion3dropdown(string question3)
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            Driver.FindElement(question3Dropdwn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(question3Dropdwn), question3);
        }
        
        public void EnterQuestion4(string question4)
        {
            Actions actions = new Actions(Driver);
           // new Actions(Driver).KeyDown(Keys.Control).SendKeys(Keys.PageDown).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 500);");
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.ScrollToElement(Driver, question4TextBox);
            Driver.FindElement(question4TextBox).Click();
            Driver.FindElement(question4TextBox).SendKeys(question4);

        }

        public void SelectQuestion5(string question5)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.ScrollToElement(Driver, question5Dropdwn);
            Driver.FindElement(question5Dropdwn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(question5Dropdwn), question5);
            }
       
        public void EnterQuestion6(string question6)
        {
            Actions actions = new Actions(Driver);
            //new Actions(Driver).KeyDown(Keys.Control).SendKeys(Keys.PageDown).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 500);");
            //CommonHelpers.WaitForElementVisiblity(Driver, question6TextBox, 100);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.ScrollToElement(Driver, question6TextBox);
            Driver.FindElement(question6TextBox).Click();
            Driver.FindElement(question6TextBox).SendKeys(question6);
            


        }


        public void ClickSubmitReferralButton()
        {
           
            CommonHelpers.WaitForPageLoading(Driver);
            CommonHelpers.ScrollUp(Driver);

            CommonHelpers.WaitForElementVisiblity(Driver, submitReferralButton, 100);
            Driver.FindElement(submitReferralButton).Submit();
        }

        public bool WaitForAttachmentUploadOrSubmissionOutcome(int timeoutInSeconds)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(_ => IsAttachmentUploadDisplayed() ||
                            IsSubmissionConfirmationDisplayed() ||
                            IsAttachmentCorrectionWorkflowDisplayed());

            return IsAttachmentUploadDisplayed();
        }

        public bool IsAttachmentUploadDisplayed()
        {
            return IsDisplayed(attachmentUploadMessage);
        }

        public bool IsAttachmentUploadSpinnerDisplayed()
        {
            return IsDisplayed(attachmentUploadSpinner);
        }

        public bool IsAttachmentUploadStatusBoxDisplayed()
        {
            return IsDisplayed(attachmentFileNameHeader) &&
                   IsDisplayed(attachmentStatusHeader) &&
                   IsDisplayed(attachmentUploadStatus);
        }

        public bool WaitForSubmissionOutcomeWithoutLeavingUploadPage(
            string submissionPageUrl,
            int timeoutInSeconds)
        {
            bool stayedOnSubmissionPage = true;
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));

            wait.Until(_ =>
            {
                if (IsAttachmentUploadDisplayed() &&
                    !string.Equals(Driver.Url, submissionPageUrl, StringComparison.OrdinalIgnoreCase))
                {
                    stayedOnSubmissionPage = false;
                }

                return IsSubmissionConfirmationDisplayed() ||
                       IsAttachmentCorrectionWorkflowDisplayed();
            });

            return stayedOnSubmissionPage;
        }

        public bool IsSubmissionConfirmationDisplayed()
        {
            return IsDisplayed(enterNewReferral);
        }

        public bool IsAttachmentCorrectionWorkflowDisplayed()
        {
            return IsDisplayed(attachmentCorrectionWorkflow);
        }

        private bool IsDisplayed(By locator)
        {
            return Driver.FindElements(locator).Any(element =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
        }

        public string GetReviewPageContent()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);

            return (string)((IJavaScriptExecutor)Driver).ExecuteScript(@"
                const visibleControlValues = Array.from(document.querySelectorAll('input, textarea, select'))
                    .filter(element => element.offsetParent !== null)
                    .map(element => element.tagName === 'SELECT'
                        ? element.options[element.selectedIndex]?.text ?? ''
                        : element.value ?? '');
                return `${document.body.innerText}\n${visibleControlValues.join('\n')}`;");
        }

        public bool EnterNewReferralButtonIsDisplayed()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.WaitForElementVisiblity(Driver, enterNewReferral, 100);
            return Driver.FindElement(enterNewReferral).Displayed;
        }

        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.ScrollUp(Driver);
            CommonHelpers.WaitForElementVisiblity(Driver, proceed_To_Next_SectionButton, 100);
            Driver.FindElement(proceed_To_Next_SectionButton).Click();
            CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 100);

        }

        public void ClickUploadFileArrow(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
