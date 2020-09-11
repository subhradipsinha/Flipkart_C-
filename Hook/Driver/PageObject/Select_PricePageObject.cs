using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_flipkart_com.Hook.Driver.SetMethod.PageObject
{
    class Select_PricePageObject : LoginPageObject
    {
        
        [FindsBy(How = How.XPath,Using = "//div[@class='_1YoBfV']//select[@class='fPjUPw']")]
        public IWebElement droupdown_field{ get; set; }
              
    }
}
