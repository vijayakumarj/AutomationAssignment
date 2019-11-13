using Assignment.Automation.GUI.Hooks;
using Assignment.Automation.GUI.PageFactory;
using System;
using TechTalk.SpecFlow;

namespace Assignment.Automation.GUI.FeatureFiles
{
    [Binding]
    public class SpecFlowFeature1Steps : Base
    {
        [Given(@"Matt, one new customer navigates to application sign-in page")]
        public void GivenMattANewCustomerNavigatesToApplicationSign_InPage()
        {
            Home homepage = new Home();
            homepage.ClickButtonSignIn();
        }
        
        [Given(@"Matt registers as a new user of the application")]
        public void GivenMattRegistersAsANewUserOfTheApplication()
        {
            CreateNewAccount createNewAccountPage = new CreateNewAccount();
            createNewAccountPage.EnterText("test@iop.com");
            createNewAccountPage.ClickButtonCreateAccount();
        }
        
        [Given(@"Matt should get logged into the application")]
        public void GivenMattShouldGetLoggedIntoTheApplication()
        {

        }
        
        [Given(@"Matt should be able to view his account page")]
        public void GivenMattShouldBeAbleToViewHisAccountPage()
        {

        }
        
        [Given(@"view the sign out option")]
        public void GivenViewTheSignOutOption()
        {

        }
    }
}
