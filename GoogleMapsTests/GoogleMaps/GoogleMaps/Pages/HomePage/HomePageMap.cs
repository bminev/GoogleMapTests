using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMaps.HomePage
{
    public partial class HomePage : BasePage
    {
        public IWebElement DirectionButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"searchbox-directions\"]"));
            }
        }
        public IWebElement DirectionMenu
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div"));
            }
        }

        public IWebElement TransitButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[3]/button/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[3]/button/div[1]"));
            }
        }
       
        public IWebElement StartLocation
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sb_ifc51\"]/input"));
            }
        }

        public IWebElement FinalLocation
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sb_ifc52\"]/input"));
            }
        }
        
        public IWebElement ButtonSearch
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"directions-searchbox-1\"]/button[1]"));
            }
        }
        public IWebElement TimeForTravelWithTransit
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div/div[2]/div[2]/div[1]/div")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div/div[2]/div[2]/div[1]/div"));
            }
        }
        public IWebElement DrivingButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[2]/button/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[2]/button/div[1]"));
            }
        }
        public IWebElement DistanceBetweenStartAndFinalLocationWithDriving
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div"));
            }
        }
        public IWebElement WalkingButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[4]/button/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[4]/button/div[1]"));
            }
        }
        public IWebElement DistanceBetweenStartAndFinalLocationWithWalking
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[1]/div[2]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[1]/div[2]"));
            }
        }
        public IWebElement TimeBetweenStartAndFinalLocationWithWalking
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[1]/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[1]/div[1]"));
            }
        }
        public IWebElement CyclingButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[2]/div[1]/div[1]/button/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[2]/div[1]/div[1]/button/div[1]"));
            }
        }
        public IWebElement HighestAltitudeBetweenStartAndFinalLocationWithCycling
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[3]/div/div/span[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[3]/div/div/span[1]"));
            }
        }
        public IWebElement SendingButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[4]/div[2]/div[2]/button")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[4]/div[2]/div[2]/button"));
            }
        }
        public IWebElement PhoneModel
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"modal-dialog-widget\"]/div[2]/div/div[3]/div/div/div[1]/div[1]/div/span[3]/span[1]/span[1]/button")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"modal-dialog-widget\"]/div[2]/div/div[3]/div/div/div[1]/div[1]/div/span[3]/span[1]/span[1]/button"));
            }
        }
        public IWebElement CheckButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[4]/div[2]/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[4]/div[2]/div[1]"));
            }
        }
        public IWebElement LeaveNowDropDownButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/span/div/div/div/div[2]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/span/div/div/div/div[2]"));
            }
        }
        public IWebElement LeaveNowDropDownMenu
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\":1\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\":1\"]"));
            }
        }
        public IWebElement TimeDropDownMenu
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[1]/span[1]/input")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[1]/span[1]/input"));
            }
        }
        public IWebElement DateDropDownMenu
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[1]/span[2]/span[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[1]/span[2]/span[1]"));
            }
        }
        public IWebElement NextDateOfTravel
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\":2a\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\":2a\"]"));
            }
        }
        public IWebElement OptionButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/button[3]/span[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/button[3]/span[1]"));
            }
        }
        public IWebElement CheckBusButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[2]/div/div[3]/div[1]/div[1]/label")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[2]/div/div[3]/div[1]/div[1]/label"));
            }
        }
        public IWebElement CheckTrainButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[2]/div/div[3]/div[1]/div[3]/label")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[2]/div/div[3]/div[1]/div[3]/label"));
            }
        }
        public IWebElement CheckFewerTransfersButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[2]/div/div[3]/div[2]/label[2]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[2]/div/div[3]/div[2]/label[2]"));
            }
        }
        public IWebElement CloseButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/button[3]/span[2]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/button[3]/span[2]"));
            }
        }
        public IWebElement ScheduleExplorerButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[6]/button")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[6]/button"));
            }
        }
        public IWebElement TimeScheduleExplorer
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("time-input")));
                return this.Driver.FindElement(By.ClassName("time-input"));
            }
        }
        public IWebElement DateScheduleExplorer
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("date-input")));
                return this.Driver.FindElement(By.ClassName("date-input"));
            }
        }
    }
}
