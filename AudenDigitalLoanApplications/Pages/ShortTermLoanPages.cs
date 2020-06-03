using OpenQA.Selenium;
using AudenDigitalLoanApplications.Hooks;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace AudenDigitalLoanApplications.Pages
{
    public class ShortTermLoanPages
    {
        Context context;
        
        //Constructor to call Hooks class in order to utilize the functions in hooks class
        public ShortTermLoanPages(Context _context)
        {
            context = _context;
        }

        // Elements on the page

        By loanAmount = By.CssSelector(".loan-amount__range-slider__input");
        By loanDate = By.CssSelector("[value='6'");
        By aboutUs = By.XPath("//*[@id='root']/header/nav/div/section[2]/div/ul/li[3]/a");
        By fAQs = By.XPath("//*[@id='root']/header/nav/div/section[2]/div/ul/li[4]/a");

        //Function for clicking loan amount to be utilized in StepDefinitions
        public void ClickOnShortTermLoanAmount()
        {
            Thread.Sleep(2000);
            IWebElement slider = context.driver.FindElement(loanAmount);  
            Actions action = new Actions(context.driver);
            action.MoveToElement(slider).Build();
            action.ClickAndHold(slider).Build().Perform();          
        }

        //Function for verifying loan amount to be utilized in StepDefinitions
        public bool VerifyLoanApplicationSuccessful()
        {
            return context.driver.PageSource.Contains("£350");
        }

        //Function for clicking repayment day to be utilized in StepDefinitions
        public void ClickOnRepaymentDay()
        {
            Thread.Sleep(2000);
            IWebElement slider = context.driver.FindElement(loanDate);
            Actions action = new Actions(context.driver);
            action.MoveToElement(slider).Build();
            action.ClickAndHold(slider).Build().Perform();
            Thread.Sleep(2000);
        }

        //Function for verifying repayment day to be utilized in StepDefinitions
        public bool VerifyRepaymentDaySuccessful()
        {
            return context.driver.PageSource.Contains("Saturday 6 Jun 2020");
        }

        //Function for clicking about us to be utilized in StepDefinitions
        public void ClickOnAboutUsLink()
        {
            context.driver.FindElement(aboutUs).Click();
        }

        //Function for verifying about us page to be utilized in StepDefinitions
        public bool VerifyAboutUsPageSuccessful()
        {
            return context.driver.PageSource.Contains("About us");
        }

        //Function for clicking FAQs link to be utilized in StepDefinitions
        public void ClickOnFAQsLink()
        {
            context.driver.FindElement(fAQs).Click();
        }

        //Function for verifying FAQs link to be utilized in StepDefinitions
        public bool VerifyFAQsPageSuccessful()
        {
            return context.driver.PageSource.Contains("FAQs");
        }
    }
}
