using OpenQA.Selenium;
using OrderForm.Utilites;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderForm.PageObject
{
    class OrderFormPage
    {
       public OrderFormPage()
        {
            driver = Hooks1.driver; 
        }
        
        IWebDriver driver;

        IWebElement ChooseMake => driver.FindElement(By.CssSelector("#vehicleBrand"));









        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://checkout.pod-point.com/");
        }

        public void selectMakeDropDownList()
        {
            Choose drop = new Choose("Tesla");
        }








    }

}














