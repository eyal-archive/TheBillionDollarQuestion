namespace TheBillionDollarQuestion.UI.View
{
	partial class QuestionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.firstAnswer = new System.Windows.Forms.Button();
			this.secondAnswer = new System.Windows.Forms.Button();
			this.thirdAnswer = new System.Windows.Forms.Button();
			this.question = new System.Windows.Forms.Label();
			this.results = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// firstAnswer
			// 
			this.firstAnswer.Location = new System.Drawing.Point(15, 70);
			this.firstAnswer.Name = "firstAnswer";
			this.firstAnswer.Size = new System.Drawing.Size(75, 23);
			this.firstAnswer.TabIndex = 0;
			this.firstAnswer.Text = "Answer A";
			this.firstAnswer.UseVisualStyleBackColor = true;
			this.firstAnswer.Click += new System.EventHandler(this.button1_Click);
			// 
			// secondAnswer
			// 
			this.secondAnswer.Location = new System.Drawing.Point(96, 70);
			this.secondAnswer.Name = "secondAnswer";
			this.secondAnswer.Size = new System.Drawing.Size(75, 23);
			this.secondAnswer.TabIndex = 1;
			this.secondAnswer.Text = "Answer B";
			this.secondAnswer.UseVisualStyleBackColor = true;
			this.secondAnswer.Click += new System.EventHandler(this.button2_Click);
			// 
			// thirdAnswer
			// 
			this.thirdAnswer.Location = new System.Drawing.Point(177, 70);
			this.thirdAnswer.Name = "thirdAnswer";
			this.thirdAnswer.Size = new System.Drawing.Size(75, 23);
			this.thirdAnswer.TabIndex = 2;
			this.thirdAnswer.Text = "Answer C";
			this.thirdAnswer.UseVisualStyleBackColor = true;
			this.thirdAnswer.Click += new System.EventHandler(this.button3_Click);
			// 
			// question
			// 
			this.question.AutoSize = true;
			this.question.Location = new System.Drawing.Point(12, 9);
			this.question.Name = "question";
			this.question.Size = new System.Drawing.Size(65, 17);
			this.question.TabIndex = 3;
			this.question.Text = "Question";
			// 
			// results
			// 
			this.results.AutoSize = true;
			this.results.Location = new System.Drawing.Point(10, 120);
			this.results.Name = "results";
			this.results.Size = new System.Drawing.Size(55, 17);
			this.results.TabIndex = 4;
			this.results.Text = "Results";
			// 
			// QuestionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 150);
			this.Controls.Add(this.results);
			this.Controls.Add(this.question);
			this.Controls.Add(this.thirdAnswer);
			this.Controls.Add(this.secondAnswer);
			this.Controls.Add(this.firstAnswer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "QuestionForm";
			this.Text = "The Billion Dollar Question";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button firstAnswer;
		private System.Windows.Forms.Button secondAnswer;
		private System.Windows.Forms.Button thirdAnswer;
		private System.Windows.Forms.Label question;
		private System.Windows.Forms.Label results;
	}
}

