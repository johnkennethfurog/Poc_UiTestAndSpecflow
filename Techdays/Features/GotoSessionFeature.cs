using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace Techdays.Features
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public partial class GotoSessionFeature : FeatureBase
    {
        public GotoSessionFeature(Platform platform) : base(platform)
        {
        }
    }
}
