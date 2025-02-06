namespace lab2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBoxInputN = new TextBox();
			labelResult = new Label();
			buttonCalculateFactorial = new Button();
			textBoxArrayInput = new TextBox();
			buttonCalculateSum = new Button();
			labelSumResult = new Label();
			SuspendLayout();
			// 
			// textBoxInputN
			// 
			textBoxInputN.Location = new Point(217, 168);
			textBoxInputN.Name = "textBoxInputN";
			textBoxInputN.Size = new Size(100, 23);
			textBoxInputN.TabIndex = 0;
			// 
			// labelResult
			// 
			labelResult.AutoSize = true;
			labelResult.Location = new Point(217, 218);
			labelResult.Name = "labelResult";
			labelResult.Size = new Size(55, 15);
			labelResult.TabIndex = 1;
			labelResult.Text = "Factorial:";
			// 
			// buttonCalculateFactorial
			// 
			buttonCalculateFactorial.Location = new Point(217, 260);
			buttonCalculateFactorial.Name = "buttonCalculateFactorial";
			buttonCalculateFactorial.Size = new Size(100, 23);
			buttonCalculateFactorial.TabIndex = 2;
			buttonCalculateFactorial.Text = "Solve Factorial";
			buttonCalculateFactorial.UseVisualStyleBackColor = true;
			buttonCalculateFactorial.Click += buttonCalculateFactorial_Click;
			// 
			// textBoxArrayInput
			// 
			textBoxArrayInput.Location = new Point(483, 168);
			textBoxArrayInput.Name = "textBoxArrayInput";
			textBoxArrayInput.Size = new Size(100, 23);
			textBoxArrayInput.TabIndex = 3;
			// 
			// buttonCalculateSum
			// 
			buttonCalculateSum.Location = new Point(483, 260);
			buttonCalculateSum.Name = "buttonCalculateSum";
			buttonCalculateSum.Size = new Size(100, 23);
			buttonCalculateSum.TabIndex = 4;
			buttonCalculateSum.Text = "Solve Sum";
			buttonCalculateSum.UseVisualStyleBackColor = true;
			buttonCalculateSum.Click += buttonCalculateSum_Click;
			// 
			// labelSumResult
			// 
			labelSumResult.AutoSize = true;
			labelSumResult.Location = new Point(483, 218);
			labelSumResult.Name = "labelSumResult";
			labelSumResult.Size = new Size(34, 15);
			labelSumResult.TabIndex = 5;
			labelSumResult.Text = "Sum:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(labelSumResult);
			Controls.Add(buttonCalculateSum);
			Controls.Add(textBoxArrayInput);
			Controls.Add(buttonCalculateFactorial);
			Controls.Add(labelResult);
			Controls.Add(textBoxInputN);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxInputN;
        private Label labelResult;
        private Button buttonCalculateFactorial;
		private TextBox textBoxArrayInput;
		private Button buttonCalculateSum;
		private Label labelSumResult;
	}
}
