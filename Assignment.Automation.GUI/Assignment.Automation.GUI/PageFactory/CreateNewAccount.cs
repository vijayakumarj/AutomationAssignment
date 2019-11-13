using Assignment.Automation.GUI.Resources;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Automation.GUI.PageFactory
{
    public class CreateNewAccount
    {
        IWebElement TxtEmail => StaticResources.driver.FindElement(By.Id("email_create"));
        IWebElement BtnCreateAccount => StaticResources.driver.FindElement(By.Id("SubmitCreate"));
        
        public void EnterText(string value)
        {
            TxtEmail.SendKeys(value);
        }
        public void ClickButtonCreateAccount()
        {
            BtnCreateAccount.Click();
        }

    }
}
