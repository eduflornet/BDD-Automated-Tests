using System;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestProject.OpenSDK.Drivers.Web;

namespace NET5.Specflow.Hooks
{
    [Binding]
    public sealed class Hook1
    {
        private readonly DriverHelper _driverHelper;

        public Hook1(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //new DriverManager().SetUpDriver(new ChromeConfig());


            var options = new ChromeOptions();
            options.AddArgument("--headless");

            Console.WriteLine("Setup");

            //Using TestProject OpenSDK replacing the existing WebDriverManager
            //Note: Here the Token is taken from the .runsettings file
            _driverHelper.Driver = new FirefoxDriver(null, "U--LKi5tve35kNidu4uRp5IzAWrhL7PNVp3jEn4Y55U1");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}