using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CSSSRUItest.StepDefinitions
{
    [Binding]
    public class ContentBlockSteps
    {
        [BeforeScenario]
        public void Initialize()
        {
            WebDriver.Initialize();
        }

        [AfterScenario]
        public void Close()
        {
            WebDriver.Close();
        }

        [Given(@"I am on quest page")]
        public void GivenIAmOnQuestPage()
        {
            WebDriver.Navigate();
        }
        
        [Given(@"ProjectDetails block displayed")]
        public void GivenProjectDetailsBlockDisplayed()
        {
            var projectDetails = WebDriver.DriverInstance.FindElement(By.ClassName("info-details"));
            Assert.IsTrue(projectDetails.Displayed, "Project Details block is not displayed");
        }
        
        [When(@"I click on InfoErrors link")]
        public void WhenIClickOnInfoErrorsLink()
        {
            var infoErrorsLink = WebDriver.DriverInstance.FindElement(By.ClassName("graphs-errors")).FindElement(By.XPath(".//a"));
            infoErrorsLink.Click();
            System.Threading.Thread.Sleep(3000);
        }
        
        [Then(@"InfoErrors block displayed")]
        public void ThenInfoErrorsBlockDisplayed()
        {
            var projectDetails = WebDriver.DriverInstance.FindElement(By.ClassName("info-errors"));
            Assert.IsTrue(projectDetails.Displayed, "Project Details block is not displayed");
        }
    }
}
