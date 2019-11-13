using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Assignment.Automation.GUI.Hooks
{
    [Binding]
    public class Base
    {
        public IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {

        }

    }
}
