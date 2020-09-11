// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation

using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using demo_flipkart_com.Hook;
using demo_flipkart_com.Hook.Driver;
using demo_flipkart_com.Hook.Driver.PageObject;
using demo_flipkart_com.Hook.Driver.SetMethod.PageObject;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;


namespace demo_flipkart_com
{
    [TestFixture]
    class TestClass : Hit_Url_Quite
    {
              
        [Test, NUnit.Framework.Order(2)]
        public void Login()
        {
            LoginPageObject page = new LoginPageObject();

            page.BrowserClose.Click();
            Thread.Sleep(2000);
            Console.WriteLine("Browser Close");

            page.LoginButton.Click();
            Thread.Sleep(2000);
            Console.WriteLine("LoginButton Enter");

            page.Email.SendKeys("8961543969");
            Thread.Sleep(2000);
            Console.WriteLine("Email ID Enter");
            page.Password.SendKeys("8961543969");
            Thread.Sleep(2000);
            Console.WriteLine("password ID Enter");
            page.Save.Click();
            Thread.Sleep(5000);
            Console.WriteLine("Save button Enter");
        }

        [Test, NUnit.Framework.Order(3)]
        public void Dashboard()
        {
            DashPageObject dashPageObject = new DashPageObject();
            Thread.Sleep(3000);
            dashPageObject.Searchtext.SendKeys("samsung mobiles");
            Thread.Sleep(3000);
            Console.WriteLine("Search Value given");
            dashPageObject.SearchEnter.Click();
            Console.WriteLine("Search option working");
            Thread.Sleep(3000);
        }
        [Test, NUnit.Framework.Order(4)]
        public void Selected_price()
        {
            //Price Amount Droupdaown box
            Select_PricePageObject select_IteamPageObject = new Select_PricePageObject();
            Thread.Sleep(3000);
            new SelectElement(select_IteamPageObject.droupdown_field).SelectByValue("2000");
            Thread.Sleep(5000);
            Console.WriteLine("Price Amount Select");
        }
        [Test, NUnit.Framework.Order(5)]
        public void Selected_Iteam()
        {
            Selected_IteamPageObject selected_IteamPageObject = new Selected_IteamPageObject();
            System.Threading.Thread.Sleep(5000);
            selected_IteamPageObject.Product_Select.Click();
            System.Threading.Thread.Sleep(5000);
            /* Return to the window with handle = 0 */
            PropertiesCollectionDriver.driver.SwitchTo().Window(PropertiesCollectionDriver.driver.WindowHandles[0]).Close();
            System.Threading.Thread.Sleep(5000);
            /* Close the newly opened Window and return to the old window */
            PropertiesCollectionDriver.driver.SwitchTo().Window(PropertiesCollectionDriver.driver.WindowHandles[1]);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Switch to Other window");
            //Add to Cart Button Click
            selected_IteamPageObject.Add_To_Cart.Click();
            Console.WriteLine("Add_To_Cart Button Click");
            System.Threading.Thread.Sleep(5000);

            //Hit Logo
            selected_IteamPageObject.Logo_Hit_Page.Click();
            Console.WriteLine("Hit Logo");
            Thread.Sleep(5000);
        }
        [Test, NUnit.Framework.Order(6)]
        public void Men_Tab()
        {
            ProductHover_Mouse productHover_Mouse = new ProductHover_Mouse();
            productHover_Mouse.Men_Hover.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Men_Hover clicl");

            productHover_Mouse.TShirt_Hover.Click();
            Console.WriteLine("T-shirt Click");
            Thread.Sleep(5000);

        }
        [Test, NUnit.Framework.Order(7)]
        public void Close_Url()
        {
            Thread.Sleep(5000);
            /*PropertiesCollectionDriver.driver.Quit();*/
            Console.WriteLine("Close Url");
            Thread.Sleep(2000);
        }


    }
}
