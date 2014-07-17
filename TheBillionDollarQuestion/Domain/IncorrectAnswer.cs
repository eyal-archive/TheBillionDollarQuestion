namespace TheBillionDollarQuestion.Domain
{
	// Represents an incorrect answer.
	public class IncorrectAnswer : Answer
	{
		public IncorrectAnswer(string value)
			: base(value, false)
		{
		}
	}
}