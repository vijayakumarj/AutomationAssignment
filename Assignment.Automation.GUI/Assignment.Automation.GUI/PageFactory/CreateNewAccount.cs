using Assignment.Automation.GUI.Resources;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace Assignment.Automation.GUI.PageFactory
{
    public class CreateNewAccount
    {
        IWebElement TxtEmail => StaticResources.driver.FindElement(By.Id("email_create"));
        IWebElement BtnCreateAccount => StaticResources.driver.FindElement(By.Id("SubmitCreate"));
        IWebElement RadioBtnMr => StaticResources.driver.FindElement(By.Id("id_gender1"));
        IWebElement TxtEmailNew => StaticResources.driver.FindElement(By.Id("email"));
        IWebElement TxtFirstName => StaticResources.driver.FindElement(By.Id("customer_firstname"));
        IWebElement TxtLastName => StaticResources.driver.FindElement(By.Id("customer_lastname"));
        IWebElement TxtPassword => StaticResources.driver.FindElement(By.Id("passwd"));
        IWebElement DropdownDays => StaticResources.driver.FindElement(By.Id("days"));
        IWebElement DropdownMonths => StaticResources.driver.FindElement(By.Id("days"));
        IWebElement DropdownYears => StaticResources.driver.FindElement(By.Id("days"));


        public void EnterTextEmail(string value)
        {
            TxtEmail.SendKeys(value);
        }
        public void ClickButtonCreateAccount()
        {
            BtnCreateAccount.Click();
        }

        public void EnterTextFirstName(string value)
        {
            TxtFirstName.SendKeys(value);
        }
        public void EnterTextLastName(string value)
        {
            TxtLastName.SendKeys(value);
        }
        public void EnterTextPassword(string value)
        {
            TxtPassword.SendKeys(value);
        }

        public void SelectDobDay(string value)
        {
            SelectElement element = new SelectElement(DropdownDays);
            element.SelectByText(value);
        }
        public void SelectDobMonth(string value)
        {
            SelectElement element = new SelectElement(DropdownDays);
            element.SelectByText(value);
        }
    }
}
