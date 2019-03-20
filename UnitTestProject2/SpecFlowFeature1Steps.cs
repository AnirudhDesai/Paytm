using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject2
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        IWebDriver driver = new ChromeDriver();

        [Given(@"I have entered Paytm website")]
        public void GivenIHaveEnteredPaytmWebsite()
        {
            driver.Navigate().GoToUrl("https://www.paytm.com");
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"I validate '(.*)','(.*)','(.*)','(.*)' optios are available\.")]
        public void GivenIValidateOptiosAreAvailable_(string p0, string p1, string p2, string p3)
        {
            Assert.IsNotNull(p0);
            Assert.IsNotNull(p1);
            Assert.IsNotNull(p2);
            Assert.IsNotNull(p3);
           //driver.FindElement(By.XPath("//*[@id='app']/div/div[3]/div/div/ul/li[2]/a")).Equals(p0);
        }

        [Given(@"I click on '(.*)' option and validate")]
        public void GivenIClickOnOptionAndValidate(string p0)
        {
            driver.FindElement(By.ClassName("_160X")).Click();
        }


        [Given(@"I Enter Mobile number,select Operator,state and enter the Amount")]
       

        [When(@"I Enter Mobile number,select Operator,state and enter the Amount and Click on Proceed to Recharge then validate")]
        public void WhenIEnterMobileNumberSelectOperatorStateAndEnterTheAmountAndClickOnProceedToRechargeThenValidate()
        {
            driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys("9986612038");


            driver.FindElement(By.XPath("//*[@id='app']/div/div[4]/div[1]/div[1]/div/div[2]/div[2]/ul/li[3]/div[1]/div[1]/input")).SendKeys("100");
            driver.FindElement(By.XPath("//*[@id='app']/div/div[4]/div[1]/div[1]/div/div[2]/div[5]/button")).Click();

        }


        [Then(@"result should be dipalyed which will navigate to proceed to pay")]
        public void ThenResultShouldBeDipalyedWhichWillNavigateToProceedToPay()
        {
            
        }

    }
}
