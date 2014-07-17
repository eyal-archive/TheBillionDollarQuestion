namespace TheBillionDollarQuestion.UI.Presenter
{
	using TheBillionDollarQuestion.Domain;
	using TheBillionDollarQuestion.UI.Model;

	// The presenter responsible to handle actions/behaviours on behalf of the view.
	public class QuestionPresenter
	{
		private readonly QuestionModel _model;

		public QuestionPresenter(QuestionModel model)
		{
			_model = model;
		}

		public string GetCorrectAnswer()
		{
			return _model.GetCorrectAnswer();
		}

		public void SelectAnswer(int selectedAnswer)
		{
			Question question = _model.Question;

			Answer answer = question.GetAnswer(selectedAnswer);

			_model.SelectedAnswer = answer;
		}
	}
}