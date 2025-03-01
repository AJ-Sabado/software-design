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
    public partial class SearchBookForm : Form
    {
        private readonly IForm1 _mainForm;
        public SearchBookForm(IForm1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            var book = await _mainForm.SearchBookByTitle(textBoxSearchTitle.Text);
            _mainForm.DisplaySearchResult(book);
            this.Close();
        }
    }
}
