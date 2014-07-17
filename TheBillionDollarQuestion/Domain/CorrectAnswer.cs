namespace TheBillionDollarQuestion.Domain
{
	// Represents a correct answer.
	public class CorrectAnswer : Answer
	{
		public CorrectAnswer(string value)
			: base(value, true)
		{
		}
	}
}