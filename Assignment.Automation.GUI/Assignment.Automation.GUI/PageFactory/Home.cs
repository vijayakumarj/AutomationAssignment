using Assignment.Automation.GUI.Resources;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Automation.GUI.PageFactory
{
    public class Home
    {
        IWebElement BtnSignIn => StaticResources.driver.FindElement(By.XPath("//a[@class='login']"));

        public void ClickButtonSignIn()
        {
            BtnSignIn.Click();
        }
    }
}
