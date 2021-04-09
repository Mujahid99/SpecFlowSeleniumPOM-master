using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowSeleniumPOM.Base;
using SpecFlowSeleniumPOM.Page;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumPOM
{
    [Binding]
    public class EAHomePageSteps : StepBase2
    {

        //private EAPage eAPage;
        private EAHomePage Title;
        private EAHomePage eAHomePage;
        private LoginPage loginPage;



        [Given(@"I am on EAPage")]
        public void GivenIAmOnEAPage()
        {
            eAHomePage = new EAHomePage(driver2);
            eAHomePage.GoToPage2("http://executeautomation.com/demosite/Login.html");
        }

        [When(@"I click on Title")]
        public void WhenIClickOnTitle()
        {

            Title.ClickTitle2();
        }


    }
}
