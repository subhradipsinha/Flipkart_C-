using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_flipkart_com.Hook.Driver.SetMethod.PageObject
{
    class DashPageObject :LoginPageObject
    {
       
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search for products, brands and more']")]
         public IWebElement Searchtext { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='vh79eN']")]
        public IWebElement SearchEnter { get; set; }

    }
}
