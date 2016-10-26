namespace FizzBuzz.Code
{
	/// <summary>
	///	Determines if a number is divisible by 3, 5, or both and prints
	/// out either "Fizz", "Buzz", or "FizzBuzz", respectively, if they are.
	/// For all other inputs the number itself is the output.
	/// </summary>
	public class FizzBuzzMachine
	{
		private readonly int _number;

		public FizzBuzzMachine(int number)
		{
			_number = number;
		}

		#region Overrides of Object

		public override string ToString()
		{
			var result = string.Empty;

			if ( _number % 3 == 0 )
			{
				result += "Fizz";
			}

			if ( _number % 5 == 0 )
			{
				result += "Buzz";
			}

			return result != string.Empty ? result : _number.ToString();
		}

		#endregion
	}
}
