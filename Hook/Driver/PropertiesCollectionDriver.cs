using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_flipkart_com.Hook.Driver
{
    enum PropertyType
    {
        Id,
        Name,
        ClassName,
        CssName,
        LinkText,
        Xpath
    }
    public class PropertiesCollectionDriver
    {
        public static IWebDriver driver { get; set; }

    }
   
}
