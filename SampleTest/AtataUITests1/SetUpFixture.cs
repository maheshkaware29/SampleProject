﻿using SampleProject.PageObjectModel;

namespace SampleProject
{
    [SetUpFixture]
    public sealed class SetUpFixture
    {
  
        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            // Find information about AtataContext configuration on https://atata.io/getting-started/#configuration
            AtataContext.GlobalConfiguration
                .UseChrome()
                    .WithArguments("start-maximized")
                .UseBaseUrl("https://demo.atata.io/")
                .UseCulture("en-US")
                .UseAllNUnitFeatures();

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }
    }
}