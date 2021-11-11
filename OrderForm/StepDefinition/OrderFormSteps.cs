using OrderForm.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrderForm.StepDefinition
{
    [Binding]
    public class OrderFormSteps
    {
        OrderFormPage orderFormPage;
        public OrderFormSteps()
        {
            orderFormPage = new OrderFormPage();
        }









        [Given(@"navigate to website")]
        public void GivenNavigateToWebsite()
        {
            orderFormPage.NavigateToWebsite();
        }
        
        [Given(@"select make of care")]
        public void GivenSelectMakeOfCare()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"choose model of car")]
        public void GivenChooseModelOfCar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"choose new model")]
        public void GivenChooseNewModel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"select connection type")]
        public void GivenSelectConnectionType()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"select power rating")]
        public void GivenSelectPowerRating()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"select extras")]
        public void GivenSelectExtras()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"click on next button")]
        public void GivenClickOnNextButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter first name")]
        public void GivenEnterFirstName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"last name")]
        public void GivenLastName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter phone")]
        public void GivenEnterPhone()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter email address")]
        public void GivenEnterEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click on submit")]
        public void WhenClickOnSubmit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
