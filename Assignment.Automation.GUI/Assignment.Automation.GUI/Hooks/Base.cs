using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Assignment.Automation.GUI.Hooks
{
    [Binding]
    public class Base
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Resources.StaticResources.driver = new ChromeDriver();
            Resources.StaticResources.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }

    }
}
