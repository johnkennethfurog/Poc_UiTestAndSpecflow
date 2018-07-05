using System;
using TechTalk.SpecFlow;

namespace Techdays.Steps
{
    [Binding]
    public class GotoSessionSteps : StepsBase
    {
        [Given(@"I am at the Home page")]
        public void GivenIAmAtTheHomePage()
        {
        }
        
        [When(@"I Tap menu")]
        public void WhenITapMenu()
        {
            app.Tap(homeScreen.MenuBtn);
        }
        
        [When(@"Tap Session")]
        public void WhenTapSession()
        {
            app.Tap(homeScreen.SessionsBtn);
        }
        
        [Then(@"I must go to session page")]
        public void ThenIMustGoToSessionPage()
        {

        }

        [Given(@"I will inspect elements")]
        public void GivenIWillInspectElements()
        {
            //app.Repl();
        }

    }
}
