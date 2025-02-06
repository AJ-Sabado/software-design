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
			buttonFibonacci = new Button();
			labelFibonacci = new Label();
			textBoxFibonacci = new TextBox();
			textBoxPower = new TextBox();
			labelPower = new Label();
			buttonCalculatePower = new Button();
			SuspendLayout();
			// 
			// textBoxInputN
			// 
			textBoxInputN.Location = new Point(458, 90);
			textBoxInputN.Name = "textBoxInputN";
			textBoxInputN.Size = new Size(100, 23);
			textBoxInputN.TabIndex = 0;
			textBoxInputN.Text = "1";
			// 
			// labelResult
			// 
			labelResult.AutoSize = true;
			labelResult.Location = new Point(458, 140);
			labelResult.Name = "labelResult";
			labelResult.Size = new Size(55, 15);
			labelResult.TabIndex = 1;
			labelResult.Text = "Factorial:";
			// 
			// buttonCalculateFactorial
			// 
			buttonCalculateFactorial.Location = new Point(458, 182);
			buttonCalculateFactorial.Name = "buttonCalculateFactorial";
			buttonCalculateFactorial.Size = new Size(100, 23);
			buttonCalculateFactorial.TabIndex = 2;
			buttonCalculateFactorial.Text = "Solve Factorial";
			buttonCalculateFactorial.UseVisualStyleBackColor = true;
			buttonCalculateFactorial.Click += buttonCalculateFactorial_Click;
			// 
			// textBoxArrayInput
			// 
			textBoxArrayInput.Location = new Point(243, 245);
			textBoxArrayInput.Name = "textBoxArrayInput";
			textBoxArrayInput.Size = new Size(100, 23);
			textBoxArrayInput.TabIndex = 3;
			textBoxArrayInput.Text = "1,2,3";
			// 
			// buttonCalculateSum
			// 
			buttonCalculateSum.Location = new Point(244, 337);
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
			labelSumResult.Location = new Point(244, 295);
			labelSumResult.Name = "labelSumResult";
			labelSumResult.Size = new Size(34, 15);
			labelSumResult.TabIndex = 5;
			labelSumResult.Text = "Sum:";
			// 
			// buttonFibonacci
			// 
			buttonFibonacci.Location = new Point(243, 182);
			buttonFibonacci.Name = "buttonFibonacci";
			buttonFibonacci.Size = new Size(100, 23);
			buttonFibonacci.TabIndex = 6;
			buttonFibonacci.Text = "Solve Fibonacci";
			buttonFibonacci.UseVisualStyleBackColor = true;
			buttonFibonacci.Click += buttonFibonacci_Click;
			// 
			// labelFibonacci
			// 
			labelFibonacci.AutoSize = true;
			labelFibonacci.Location = new Point(243, 140);
			labelFibonacci.Name = "labelFibonacci";
			labelFibonacci.Size = new Size(61, 15);
			labelFibonacci.TabIndex = 7;
			labelFibonacci.Text = "Fibonacci:";
			// 
			// textBoxFibonacci
			// 
			textBoxFibonacci.Location = new Point(243, 90);
			textBoxFibonacci.Name = "textBoxFibonacci";
			textBoxFibonacci.Size = new Size(100, 23);
			textBoxFibonacci.TabIndex = 8;
			textBoxFibonacci.Text = "1";
			// 
			// textBoxPower
			// 
			textBoxPower.Location = new Point(458, 245);
			textBoxPower.Name = "textBoxPower";
			textBoxPower.Size = new Size(100, 23);
			textBoxPower.TabIndex = 9;
			textBoxPower.Text = "2^2";
			// 
			// labelPower
			// 
			labelPower.AutoSize = true;
			labelPower.Location = new Point(458, 295);
			labelPower.Name = "labelPower";
			labelPower.Size = new Size(145, 15);
			labelPower.TabIndex = 10;
			labelPower.Text = "X raised to the power of n:";
			// 
			// buttonCalculatePower
			// 
			buttonCalculatePower.Location = new Point(458, 337);
			buttonCalculatePower.Name = "buttonCalculatePower";
			buttonCalculatePower.Size = new Size(100, 23);
			buttonCalculatePower.TabIndex = 11;
			buttonCalculatePower.Text = "Solve Power";
			buttonCalculatePower.UseVisualStyleBackColor = true;
			buttonCalculatePower.Click += buttonCalculatePower_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonCalculatePower);
			Controls.Add(labelPower);
			Controls.Add(textBoxPower);
			Controls.Add(textBoxFibonacci);
			Controls.Add(labelFibonacci);
			Controls.Add(buttonFibonacci);
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
		private Button buttonFibonacci;
		private Label labelFibonacci;
		private TextBox textBoxFibonacci;
		private TextBox textBoxPower;
		private Label labelPower;
		private Button buttonCalculatePower;
	}
}
