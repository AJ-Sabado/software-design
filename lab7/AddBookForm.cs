using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class AddBookForm : Form
    {
        private readonly IForm1 _parentForm;
        public AddBookForm(IForm1 parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _parentForm.Adding = true;
        }

        private async void buttonAddNewBook_Click(object sender, EventArgs e)
        {
            await _parentForm.SaveBookAuthorWithHandling(textBoxBookTitle.Text, textBoxAuthorName.Text);
            _parentForm.Adding = false;
            this.Close();
        }
    }
}
