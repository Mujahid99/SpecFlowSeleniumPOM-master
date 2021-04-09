using OpenQA.Selenium;
using SpecFlowSeleniumPOM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumPOM.Page
{
    public class EAHomePage : BasePage2
    {
        #region // Locators
        
        private readonly By saveDropDownLocator = By.Name("TitleId");
        #endregion

        #region // Constructor
        public EAHomePage(IWebDriver driver2) : base(driver2) { }
        #endregion

        #region // Methods

        public void GoToEAHomePage(String url2)
        {
            GoToPage(url2);
        }

        public void ClickTitle2()
        {
            Click2(saveDropDownLocator, new TimeSpan(0, 1, 0));
            // return new EAHomePage(Driver);
        }



        #endregion
    }
}
