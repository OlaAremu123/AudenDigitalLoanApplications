using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AudenDigitalLoanApplications.Hooks
{
    public class Context
    {
        public IWebDriver driver;
        string baseUrl = "https://www.auden.co.uk/credit/shorttermloan";
        
        //Function to launch and maximize AudenGroupLoan page 
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
        }

        //Function to close and dispose application under test
        public void CloseApplicationUnderTest()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}

