using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techdays.Screen;
using Techdays.Screen.Home;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Techdays.Steps
{
    public class StepsBase
    {
        protected readonly IApp app;

        protected readonly IHomeScreen homeScreen;

        public StepsBase()
        {
            app = FeatureContext.Current.Get<IApp>("App");
            homeScreen = FeatureContext.Current.Get<IHomeScreen>(ScreenNames.HomeScreen);
        }
    }
}
