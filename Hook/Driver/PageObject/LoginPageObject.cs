using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_flipkart_com.Hook.Driver.SetMethod.PageObject
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollectionDriver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='_3Ep39l']")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _1dBPDZ']")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _3v41xv _1dBPDZ']")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='_2AkmmA _1LctnI _7UHT_c']")]
        public IWebElement Save { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[@class='_2AkmmA _29YdH8']")]
        public IWebElement BrowserClose { get; set; }
    }
}
