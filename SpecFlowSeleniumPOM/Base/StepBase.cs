using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumPOM.Base
{    
    public class StepBase 
    {
        public IWebDriver driver;

        [BeforeScenario("AliTest")]
        public void BeforeTestRun()
        {
            driver = new ChromeDriver();
        }

        [BeforeScenario("SmokeTest")]
        public void BeforeTestRun2()
        {
            driver = new ChromeDriver();
        }
        [AfterScenario("AliTest")]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
        [AfterScenario("SmokeTest")]
        public void AfterScenario2()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
