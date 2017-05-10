using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using GoogleMaps.HomePage;

namespace GoogleMapsTest
{
    [TestFixture]
    public class GoogleMapsTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckSiteIsLoaded()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            homePage.AssertSiteIsLoaded("http://maps.google.com");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckDirectionButtonDisplayed()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            homePage.AssertDirectionButtonExsists("Directions button is visible!");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckDirectionMenuIsLoaded()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();

            homePage.AssertDirectionMenuIsLoaded("Direction menu is loaded!");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckTheTimeBetweenStartAndFinalLocationWithTransit()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys("6480 Weathers Pl, San Diego, CA 92121, USA");
            homePage.FinalLocation.SendKeys("Bus Access Rd, San Diego, CA 92122, USA");
            homePage.TransitButton.Click();

            homePage.AssertTimeForTravelWithTransit("30 мин");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckTheDistanceBetweenStartAndFinalLocationWithDriving()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys("6480 Weathers Pl, San Diego, CA 92121, USA");
            homePage.FinalLocation.SendKeys("Bus Access Rd, San Diego, CA 92122, USA");
            homePage.DrivingButton.Click();

            homePage.AssertDistanceBetweenStartAndFinalLocationWithDriving("4,6 мили");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckTheDistanceAndTheTimeBetweenStartAndFinalLocationWithWalking()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys("6480 Weathers Pl, San Diego, CA 92121, USA");
            homePage.FinalLocation.SendKeys("Bus Access Rd, San Diego, CA 92122, USA");
            homePage.WalkingButton.Click();

            homePage.AssertDistanceBetweenStartAndFinalLocationWithWalking("5,6 мили");
            homePage.AssertTimeBetweenStartAndFinalLocationWithWalking("1 ч 53 мин");
        }
        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckTheHighestAltitudeBetweenStartAndFinalLocationWithCycling()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys("6480 Weathers Pl, San Diego, CA 92121, USA");
            homePage.FinalLocation.SendKeys("Bus Access Rd, San Diego, CA 92122, USA");
            homePage.CyclingButton.Click();

            homePage.AssertHighestAltitudeBetweenStartAndFinalLocationWithCycling("417 фута");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckSendDirectionToPhoneWithTransit()
        {
            // You have to login at www.gmail.com
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys("6480 Weathers Pl, San Diego, CA 92121, USA");
            homePage.FinalLocation.SendKeys("Bus Access Rd, San Diego, CA 92122, USA");
            homePage.TransitButton.Click();
            homePage.SendingButton.Click();
            homePage.PhoneModel.Click();

            homePage.AssertCheckButtonForSendingMessageDisplayed("The message was send!");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]
        public void CheckPlanAndScheduleToUser()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys("6480 Weathers Pl, San Diego, CA 92121, USA");
            homePage.FinalLocation.SendKeys("Bus Access Rd, San Diego, CA 92122, USA");
            homePage.TransitButton.Click();
            homePage.OptionButton.Click();
            homePage.CheckBusButton.Click();
            homePage.CheckTrainButton.Click();
            homePage.CheckFewerTransfersButton.Click();
            homePage.CloseButton.Click();
            homePage.LeaveNowDropDownButton.Click();
            homePage.LeaveNowDropDownMenu.Click();
            Type(homePage.TimeDropDownMenu, "9:33");
            homePage.DateDropDownMenu.Click();
            homePage.NextDateOfTravel.Click();
            homePage.ScheduleExplorerButton.Click();

            homePage.AssertTimeScheduleIsCorrect("9:33");
            homePage.AssertDateScheduleIsCorrect("пт, 16.05");
        }
        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
