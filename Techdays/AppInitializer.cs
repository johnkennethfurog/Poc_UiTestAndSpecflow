using System;
using Techdays.Screen;
using Techdays.Screen.Home;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Techdays
{
	public class AppInitializer
	{
        public static object InitializeScreens { get; internal set; }

        public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
                return ConfigureApp.Android
                    .EnableLocalScreenshots()
                    .ApkFile(@"C:\Source\TechDays2016-master\binaries\com.xpirit.techdays_1.0.61.apk")
                    .StartApp();
			}

			return ConfigureApp.iOS.StartApp();
		}

        internal static void InitializeScreen(Platform platform)
        {
            if(platform == Platform.Android)
            {
                FeatureContext.Current.Add(ScreenNames.HomeScreen, new AndroidHomeScreen());
            }
        }
    }
}