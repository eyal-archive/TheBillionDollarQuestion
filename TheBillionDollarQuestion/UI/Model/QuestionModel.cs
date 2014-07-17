namespace TheBillionDollarQuestion.UI.Model
{
	using TheBillionDollarQuestion.Domain;

	// The model responsible to track changes that are made to the state of the UI 
	// and is working against the business objects of the domain.
	public class QuestionModel
	{
		private static int _number;

		public QuestionModel()
		{
			Question = new Question("Which number is a prime?", new CorrectAnswer("2"), new IncorrectAnswer("4"), new IncorrectAnswer("6"));
		
			Question.RandomizeAnswers();
		}

		public Question Question { get; private set; }

		public Answer SelectedAnswer { get; set; }

		public string GetCorrectAnswer()
		{
			string answerValue;

			Answer correctAnswer = Question.GetCorrectAnswer();

			if (SelectedAnswer.IsCorrectAnswer)
			{
				answerValue = "Congratulations! the correct answer was selected.";
			}
			else
			{
				answerValue = string.Format("The selected answer was {0} but the correct answer is {1}.", SelectedAnswer.Value, correctAnswer.Value);
			}

			return answerValue;
		}

		public string GetRandomAnswer()
		{
			_number++;

			return Question.GetAnswer(_number).Value;
		}
	}
}