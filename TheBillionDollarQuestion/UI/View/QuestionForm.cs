namespace TheBillionDollarQuestion.UI.View
{
	using System;
	using System.Windows.Forms;

	using TheBillionDollarQuestion.UI.Model;
	using TheBillionDollarQuestion.UI.Presenter;

	// The view responsible to handle the UI component. 
	public partial class QuestionForm : Form
	{
		private QuestionPresenter _presenter;

		public QuestionForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			QuestionModel model = new QuestionModel();

			question.Text = model.Question.Text;

			firstAnswer.Text = model.GetRandomAnswer();
			secondAnswer.Text = model.GetRandomAnswer();
			thirdAnswer.Text = model.GetRandomAnswer();

			_presenter = new QuestionPresenter(model);

			results.Text = string.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_presenter.SelectAnswer(1);

			results.Text = _presenter.GetCorrectAnswer();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			_presenter.SelectAnswer(2);

			results.Text = _presenter.GetCorrectAnswer();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			_presenter.SelectAnswer(3);

			results.Text = _presenter.GetCorrectAnswer();
		}
	}
}