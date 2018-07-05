using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace Techdays.Screen.Home
{
    public class AndroidHomeScreen : IHomeScreen
    {
        public Func<AppQuery, AppQuery> MenuBtn => new Func<AppQuery, AppQuery>(c => c.Marked("OK"));

        public Func<AppQuery, AppQuery> SessionsBtn => new Func<AppQuery, AppQuery>(c => c.Marked("Sessions"));

        public Func<AppQuery, AppQuery> SpeakersBtn => new Func<AppQuery, AppQuery>(c => c.Marked("Speakers"));
    }
}
