using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Techdays.Features
{
    public class FeatureBase
    {
        protected static IApp app;
        protected Platform platform;

        public FeatureBase(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
            FeatureContext.Current.Clear();
            FeatureContext.Current.Add("App", app);
            AppInitializer.InitializeScreen(platform);
        }
    }
}
