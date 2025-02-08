namespace lab3
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
            buttonShowInfo = new Button();
            buttonShowBookList = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // buttonShowInfo
            // 
            buttonShowInfo.Location = new Point(35, 37);
            buttonShowInfo.Name = "buttonShowInfo";
            buttonShowInfo.Size = new Size(90, 40);
            buttonShowInfo.TabIndex = 0;
            buttonShowInfo.Text = "Show Info";
            buttonShowInfo.UseVisualStyleBackColor = true;
            buttonShowInfo.Click += buttonShowInfo_Click;
            // 
            // buttonShowBookList
            // 
            buttonShowBookList.Location = new Point(35, 114);
            buttonShowBookList.Name = "buttonShowBookList";
            buttonShowBookList.Size = new Size(90, 40);
            buttonShowBookList.TabIndex = 1;
            buttonShowBookList.Text = "Display Books";
            buttonShowBookList.UseVisualStyleBackColor = true;
            buttonShowBookList.Click += buttonShowBookList_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(131, 37);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(657, 409);
            listBoxResults.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(buttonShowBookList);
            Controls.Add(buttonShowInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonShowInfo;
        private Button buttonShowBookList;
        private ListBox listBoxResults;
    }
}
