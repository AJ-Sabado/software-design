namespace Task4
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
            buttonSort = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(44, 66);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(114, 44);
            buttonSort.TabIndex = 0;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(228, 66);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(521, 349);
            listBoxResults.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(buttonSort);
            Name = "Form1";
            Text = "Task 4";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSort;
        private ListBox listBoxResults;
    }
}
