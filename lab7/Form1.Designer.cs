namespace lab7
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
            labelPage = new Label();
            listBoxBooks = new ListBox();
            buttonPrev = new Button();
            buttonNext = new Button();
            buttonAdd = new Button();
            buttonExport = new Button();
            buttonSearch = new Button();
            buttonImport = new Button();
            SuspendLayout();
            // 
            // labelPage
            // 
            labelPage.AutoSize = true;
            labelPage.Location = new Point(12, 9);
            labelPage.Name = "labelPage";
            labelPage.Size = new Size(45, 15);
            labelPage.TabIndex = 0;
            labelPage.Text = "Page: 1";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(12, 34);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(776, 349);
            listBoxBooks.TabIndex = 1;
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(12, 389);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(75, 23);
            buttonPrev.TabIndex = 2;
            buttonPrev.Text = "Previous";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(93, 389);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 3;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(93, 5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add Book";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(336, 5);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(75, 23);
            buttonExport.TabIndex = 5;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(174, 5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonImport
            // 
            buttonImport.Location = new Point(255, 5);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(75, 23);
            buttonImport.TabIndex = 7;
            buttonImport.Text = "Import";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonImport);
            Controls.Add(buttonSearch);
            Controls.Add(buttonExport);
            Controls.Add(buttonAdd);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrev);
            Controls.Add(listBoxBooks);
            Controls.Add(labelPage);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPage;
        private ListBox listBoxBooks;
        private Button buttonPrev;
        private Button buttonNext;
        private Button buttonAdd;
        private Button buttonExport;
        private Button buttonSearch;
        private Button buttonImport;
    }
}
