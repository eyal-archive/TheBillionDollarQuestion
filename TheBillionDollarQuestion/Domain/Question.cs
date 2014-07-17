namespace TheBillionDollarQuestion.Domain
{
	using System;
	using System.Linq;

	// Represents a question with one answers and two incorrect answers.
	public class Question
	{
		private static readonly Random _random = new Random();

		private readonly Answer[] _answers = new Answer[3];

		public Question(string text, CorrectAnswer correctAnswer, IncorrectAnswer incorrectAnswer1, IncorrectAnswer incorrectAnswer2)
		{
			Text = text;

			_answers[0] = correctAnswer;
			_answers[1] = incorrectAnswer1;
			_answers[2] = incorrectAnswer2;
		}

		public string Text { get; private set; }

		public Answer GetAnswer(int selectedAnswer)
		{
			return _answers[selectedAnswer - 1];
		}

		public Answer GetCorrectAnswer()
		{
			return _answers.FirstOrDefault(answer => answer.IsCorrectAnswer);
		}

		public void RandomizeAnswers()
		{
			int indexA = _random.Next(0, _answers.Length);
			int indexB = _random.Next(0, _answers.Length);

			Answer answer = _answers[indexA];

			_answers[indexA] = _answers[indexB];

			_answers[indexB] = answer;
		}
	}
}