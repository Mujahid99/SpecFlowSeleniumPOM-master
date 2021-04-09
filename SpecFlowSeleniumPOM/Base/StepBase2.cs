using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumPOM.Base
{
    public class StepBase2
    {
        public IWebDriver driver2;

        [BeforeScenario("AliTest")]
        public void BeforeTestRun()
        {
            driver2 = new ChromeDriver();
        }

   
        [AfterScenario("AliTest")]
        public void AfterScenario()
        {
            driver2.Close();
            driver2.Quit();
        }
      

    }
}
