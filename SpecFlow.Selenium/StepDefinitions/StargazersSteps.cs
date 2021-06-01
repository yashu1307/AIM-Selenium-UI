using OpenQA.Selenium;
using SpecFlow.Selenium.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlow.Selenium.StepDefinitions
{
	[Binding]
	public class StargazerSteps
	{
		private readonly Stargazers _page;

		public StargazerSteps(IWebDriver driver)
		{
			_page = new Stargazers(driver);
		}

		[Given(@"I am on ""(.*)""")]
		public void GivenIAmOn(string url)
		{
			_page.Navigate(url);
		}

		[When(@"I click on Star Count")]
		public void WhenIClickOnStarCount()
		{
			_page.clickOnStaredUsers();
		}

		[Then(@"List of all stargazers are displayed on page")]
		public void ThenListOfAllStargazersAreDisplayedOnPage()
		{
			_page.AssertCountsAndList();

		}
	}
}