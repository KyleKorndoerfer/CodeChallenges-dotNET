using FizzBuzz.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace FizzBuzz.Tests.SpecFlow
{
	[Binding]
	public class FizzBuzzSteps
	{
		/// <summary>The <see cref="FizzBuzzMachine"/> instance.</summary>
		private FizzBuzzMachine fb;

		/// <summary>The actual result fro mthe FizzBuzz machine.</summary>
		private string actualResult;

		[Given( @"I have entered (.*) into the fizzbuzz machine" )]
		public void GivenIHaveEnteredIntoTheFizzbuzzMachine( int number )
		{
			fb = new FizzBuzzMachine( number );
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
