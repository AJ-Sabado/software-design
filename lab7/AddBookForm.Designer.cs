namespace lab7
{
    partial class AddBookForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxAuthorName = new TextBox();
            textBoxBookTitle = new TextBox();
            buttonAddNewBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 72);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Author's Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 134);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Book Title";
            // 
            // textBoxAuthorName
            // 
            textBoxAuthorName.Location = new Point(187, 99);
            textBoxAuthorName.Name = "textBoxAuthorName";
            textBoxAuthorName.Size = new Size(223, 23);
            textBoxAuthorName.TabIndex = 2;
            // 
            // textBoxBookTitle
            // 
            textBoxBookTitle.Location = new Point(187, 161);
            textBoxBookTitle.Name = "textBoxBookTitle";
            textBoxBookTitle.Size = new Size(223, 23);
            textBoxBookTitle.TabIndex = 3;
            // 
            // buttonAddNewBook
            // 
            buttonAddNewBook.Location = new Point(261, 214);
            buttonAddNewBook.Name = "buttonAddNewBook";
            buttonAddNewBook.Size = new Size(75, 23);
            buttonAddNewBook.TabIndex = 4;
            buttonAddNewBook.Text = "Add";
            buttonAddNewBook.UseVisualStyleBackColor = true;
            buttonAddNewBook.Click += buttonAddNewBook_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 327);
            Controls.Add(buttonAddNewBook);
            Controls.Add(textBoxBookTitle);
            Controls.Add(textBoxAuthorName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxAuthorName;
        private TextBox textBoxBookTitle;
        private Button buttonAddNewBook;
    }
}