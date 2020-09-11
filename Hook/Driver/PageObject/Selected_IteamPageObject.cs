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
    class Selected_IteamPageObject:LoginPageObject
    {
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[3]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/a[1]/div[2]/div[1]/div[1]")]
        public IWebElement Product_Select { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/button[1]")]
        public IWebElement Add_To_Cart { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='_3ybBIU _23_I2B']//a[1]")]
        public IWebElement Logo_Hit_Page { get; set; }

    }
}
