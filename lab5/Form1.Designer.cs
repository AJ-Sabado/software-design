namespace lab5
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
            listBoxBooks = new ListBox();
            textBoxAuthorName = new TextBox();
            textBoxBookTitle = new TextBox();
            buttonAddBook = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonShowBooks = new Button();
            buttonUpdateBook = new Button();
            textBoxBookId = new TextBox();
            label3 = new Label();
            buttonDeleteBook = new Button();
            buttonSearchBook = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(237, 14);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(551, 424);
            listBoxBooks.TabIndex = 0;
            // 
            // textBoxAuthorName
            // 
            textBoxAuthorName.Location = new Point(97, 11);
            textBoxAuthorName.Name = "textBoxAuthorName";
            textBoxAuthorName.Size = new Size(100, 23);
            textBoxAuthorName.TabIndex = 1;
            // 
            // textBoxBookTitle
            // 
            textBoxBookTitle.Location = new Point(97, 76);
            textBoxBookTitle.Name = "textBoxBookTitle";
            textBoxBookTitle.Size = new Size(100, 23);
            textBoxBookTitle.TabIndex = 2;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(61, 119);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(91, 23);
            buttonAddBook.TabIndex = 3;
            buttonAddBook.Text = "Add book";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Book Name";
            // 
            // buttonShowBooks
            // 
            buttonShowBooks.Location = new Point(61, 162);
            buttonShowBooks.Name = "buttonShowBooks";
            buttonShowBooks.Size = new Size(91, 23);
            buttonShowBooks.TabIndex = 6;
            buttonShowBooks.Text = "Show Books";
            buttonShowBooks.UseVisualStyleBackColor = true;
            buttonShowBooks.Click += buttonShowBooks_Click;
            // 
            // buttonUpdateBook
            // 
            buttonUpdateBook.Location = new Point(61, 311);
            buttonUpdateBook.Name = "buttonUpdateBook";
            buttonUpdateBook.Size = new Size(91, 23);
            buttonUpdateBook.TabIndex = 7;
            buttonUpdateBook.Text = "Update Book";
            buttonUpdateBook.UseVisualStyleBackColor = true;
            buttonUpdateBook.Click += buttonUpdateBook_Click;
            // 
            // textBoxBookId
            // 
            textBoxBookId.Location = new Point(97, 256);
            textBoxBookId.Name = "textBoxBookId";
            textBoxBookId.Size = new Size(100, 23);
            textBoxBookId.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 259);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 9;
            label3.Text = "Book Id";
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.Location = new Point(61, 349);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new Size(91, 23);
            buttonDeleteBook.TabIndex = 10;
            buttonDeleteBook.Text = "Delete Book";
            buttonDeleteBook.UseVisualStyleBackColor = true;
            buttonDeleteBook.Click += buttonDeleteBook_Click;
            // 
            // buttonSearchBook
            // 
            buttonSearchBook.Location = new Point(61, 201);
            buttonSearchBook.Name = "buttonSearchBook";
            buttonSearchBook.Size = new Size(91, 23);
            buttonSearchBook.TabIndex = 11;
            buttonSearchBook.Text = "Search Book";
            buttonSearchBook.UseVisualStyleBackColor = true;
            buttonSearchBook.Click += buttonSearchBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSearchBook);
            Controls.Add(buttonDeleteBook);
            Controls.Add(label3);
            Controls.Add(textBoxBookId);
            Controls.Add(buttonUpdateBook);
            Controls.Add(buttonShowBooks);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddBook);
            Controls.Add(textBoxBookTitle);
            Controls.Add(textBoxAuthorName);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            Text = "Lab 5";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private TextBox textBoxAuthorName;
        private TextBox textBoxBookTitle;
        private Button buttonAddBook;
        private Label label1;
        private Label label2;
        private Button buttonShowBooks;
        private Button buttonUpdateBook;
        private TextBox textBoxBookId;
        private Label label3;
        private Button buttonDeleteBook;
        private Button buttonSearchBook;
    }
}
