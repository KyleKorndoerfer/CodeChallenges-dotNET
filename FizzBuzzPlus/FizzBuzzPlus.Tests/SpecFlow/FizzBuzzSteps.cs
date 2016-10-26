using FizzBuzzPlus.Code;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace FizzBuzzPlus.Tests.SpecFlow
{
	[Binding]
	public class FizzBuzzSteps
	{
		private FizzBuzzPlusMachine fb;
		private string actualResult;

		[Given( @"I have entered (.*) into the fizzbuzz machine" )]
		public void GivenIHaveEnteredIntoTheFizzbuzzMachine( int number )
		{
			fb = new FizzBuzzPlusMachine( number );
		}

		[When( @"I ask for the answer" )]
		public void WhenIAskForTheAnswer()
		{
			actualResult = fb.ToString();
		}

		[Then( @"the result should be (.*)" )]
		public void ThenTheResultShouldBe( string expectedResult )
		{
			Assert.AreEqual( expectedResult, actualResult );
		}
	}
}
