namespace lab7
{
    partial class SearchBookForm
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
            buttonSearch = new Button();
            label1 = new Label();
            textBoxSearchTitle = new TextBox();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(261, 212);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 84);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter Book Title:";
            // 
            // textBoxSearchTitle
            // 
            textBoxSearchTitle.Location = new Point(200, 131);
            textBoxSearchTitle.Name = "textBoxSearchTitle";
            textBoxSearchTitle.Size = new Size(197, 23);
            textBoxSearchTitle.TabIndex = 2;
            // 
            // SearchBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 327);
            Controls.Add(textBoxSearchTitle);
            Controls.Add(label1);
            Controls.Add(buttonSearch);
            Name = "SearchBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSearch;
        private Label label1;
        private TextBox textBoxSearchTitle;
    }
}