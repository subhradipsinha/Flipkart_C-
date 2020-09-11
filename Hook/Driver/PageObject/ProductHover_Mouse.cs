using demo_flipkart_com.Hook.Driver.SetMethod.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_flipkart_com.Hook.Driver.PageObject
{
    class ProductHover_Mouse : LoginPageObject
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Men')]")]
        public IWebElement Men_Hover { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[3]//ul[1]//li[1]//ul[1]//li[2]//ul[1]//li[3]//a[1]")]
        public IWebElement TShirt_Hover{get;set;}
    }
}
