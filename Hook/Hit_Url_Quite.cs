using demo_flipkart_com.Hook.Driver;
using demo_flipkart_com.Hook.Driver.SetMethod.PageObject;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace demo_flipkart_com.Hook
{
    public class Hit_Url_Quite
    {

        [Test, NUnit.Framework.Order(1)]
        public void Initialize()
        {

            PropertiesCollectionDriver.driver = new ChromeDriver();
            PropertiesCollectionDriver.driver.Url = "https://www.flipkart.com";
            PropertiesCollectionDriver.driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
        }
    }

    }