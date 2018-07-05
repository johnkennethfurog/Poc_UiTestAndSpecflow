using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace Techdays.Screen.Home
{
    public interface IHomeScreen
    {
        Func<AppQuery,AppQuery> MenuBtn { get; }
        Func<AppQuery, AppQuery> SessionsBtn { get; }
        Func<AppQuery, AppQuery> SpeakersBtn { get; }
    }
}
