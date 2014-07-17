namespace TheBillionDollarQuestion.Domain
{
	// Represents an abstract answer that is either correct or incorrect.
	public abstract class Answer
	{
		protected Answer(string value, bool isCorrectAnswer)
		{
			Value = value;

			IsCorrectAnswer = isCorrectAnswer;
		}

		public string Value { get; private set; }

		public bool IsCorrectAnswer { get; private set; }
	}
}