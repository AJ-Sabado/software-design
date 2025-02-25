namespace lab6
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
            buttonFetchBooks = new Button();
            listBoxBooks = new ListBox();
            textBoxAuthorName = new TextBox();
            textBoxBookTitle = new TextBox();
            buttonAddBook = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxBookId = new TextBox();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            progressBarProcess = new ProgressBar();
            SuspendLayout();
            // 
            // buttonFetchBooks
            // 
            buttonFetchBooks.Location = new Point(229, 12);
            buttonFetchBooks.Name = "buttonFetchBooks";
            buttonFetchBooks.Size = new Size(75, 23);
            buttonFetchBooks.TabIndex = 0;
            buttonFetchBooks.Text = "Fetch";
            buttonFetchBooks.UseVisualStyleBackColor = true;
            buttonFetchBooks.Click += buttonFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(229, 52);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(539, 394);
            listBoxBooks.TabIndex = 1;
            // 
            // textBoxAuthorName
            // 
            textBoxAuthorName.Location = new Point(12, 52);
            textBoxAuthorName.Name = "textBoxAuthorName";
            textBoxAuthorName.Size = new Size(211, 23);
            textBoxAuthorName.TabIndex = 2;
            // 
            // textBoxBookTitle
            // 
            textBoxBookTitle.Location = new Point(12, 96);
            textBoxBookTitle.Name = "textBoxBookTitle";
            textBoxBookTitle.Size = new Size(211, 23);
            textBoxBookTitle.TabIndex = 3;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(12, 174);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(75, 23);
            buttonAddBook.TabIndex = 4;
            buttonAddBook.Text = "Add";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "Book Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "Book Id";
            // 
            // textBoxBookId
            // 
            textBoxBookId.Location = new Point(12, 145);
            textBoxBookId.Name = "textBoxBookId";
            textBoxBookId.Size = new Size(211, 23);
            textBoxBookId.TabIndex = 7;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(148, 174);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(12, 203);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // progressBarProcess
            // 
            progressBarProcess.Location = new Point(12, 423);
            progressBarProcess.Name = "progressBarProcess";
            progressBarProcess.Size = new Size(211, 23);
            progressBarProcess.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBarProcess);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(label3);
            Controls.Add(textBoxBookId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddBook);
            Controls.Add(textBoxBookTitle);
            Controls.Add(textBoxAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(buttonFetchBooks);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFetchBooks;
        private ListBox listBoxBooks;
        private TextBox textBoxAuthorName;
        private TextBox textBoxBookTitle;
        private Button buttonAddBook;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxBookId;
        private Button buttonUpdate;
        private Button buttonDelete;
        private ProgressBar progressBarProcess;
    }
}
