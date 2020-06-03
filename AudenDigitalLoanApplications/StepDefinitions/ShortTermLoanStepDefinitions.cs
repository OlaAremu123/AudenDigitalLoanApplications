using AudenDigitalLoanApplications.Hooks;
using AudenDigitalLoanApplications.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace AudenDigitalLoanApplications.StepDefinitions
{ 
    //Step definitions generated from features to execute the test steps

    [Binding]
    public class ShortTermLoanStepDefinitions
    {
        Context context;
        ShortTermLoanPages shortTermLoanPages;
        public ShortTermLoanStepDefinitions(Context _context, ShortTermLoanPages _shortTermLoanPages)
        {
            context = _context;
            shortTermLoanPages = _shortTermLoanPages;
        }

        // Step to launch and maximize AudenGroupLoan page

        [Given(@"auden group short tem loan page is fully loaded")]
        public void GivenAudenGroupShortTemLoanPageIsFullyLoaded()
        {
            context.Initialize();
        }

        //Step to select £350 loan on a loan application

        [When(@"a user selects £350 loan amount")]
        public void WhenAUserSelectsLoanAmount()
        {
            shortTermLoanPages.ClickOnShortTermLoanAmount();
        }

        //Step to ascertain if truly £350 has been selected

        [Then(@"£350 loan amount should be selected and displayed successfully")]
        public void ThenLoanAmountShouldBeSelectedAndDisplayedSuccessfully()
        {
            bool actualResult = shortTermLoanPages.VerifyLoanApplicationSuccessful();
            Assert.AreEqual(true, actualResult);
        }

        //Step to select loan date of Saturday 6 Jun 2020

        [When(@"a user selects a weekend date like Saturday 6 Jun 2020")]
        public void WhenAUserSelectsAWeekendDateLikeSaturdayJun()
        {
            shortTermLoanPages.ClickOnRepaymentDay();
        }

        //Step to ascertain Friday 5 Jun 2020 is displaying successfully

        [Then(@"Friday 5 Jun 2020 should be displayed successfully")]
        public void ThenFridayJunShouldBeDisplayedSuccessfully()
        {
            bool actualResult = shortTermLoanPages.VerifyRepaymentDaySuccessful();
            Assert.AreEqual(false, actualResult);
        }

        //Step to click on about us link

        [When(@"a user clicks on the about us link")]
        public void WhenAUserClicksOnTheAboutUsLink()
        {
           shortTermLoanPages.ClickOnAboutUsLink();
        }

        //Step to ensure that user has navigated to about us page successfully

        [Then(@"a user should navigate to about us page successfully")]
        public void ThenAUserShouldNavigateToAboutUsPageSuccessfully()
        {
            bool actualResult = shortTermLoanPages.VerifyAboutUsPageSuccessful();
            Assert.AreEqual(true, actualResult);
        }

        //Step to click on FAQs link

        [When(@"a user clicks on the FAQs link")]
        public void WhenAUserClicksOnTheFAQsLink()
        {
            shortTermLoanPages.ClickOnFAQsLink();
        }

        //Step to ascertain user has navigated to FAQs page successfully

        [Then(@"a user should navigate to FAQs page successfully")]
        public void ThenAUserShouldNavigateToFAQsPageSuccessfully()
        {
            bool actualResult = shortTermLoanPages.VerifyFAQsPageSuccessful();
            Assert.AreEqual(true, actualResult);
        }

        //Step to close and dispose Application Under Test

        [AfterScenario]
        public void CloseAUT()
        {
            context.CloseApplicationUnderTest();
        }
    }
}
