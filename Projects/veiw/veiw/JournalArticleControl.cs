using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace view
{
    public partial class JournalArticleControl : UserControl
    {
        public JournalArticleControl()
        {
            InitializeComponent();
        }
        public JournalArticle GetJournalArticle()
        {
            return new JournalArticle()
            {
                Author = AuthorTextBox.Text,
                Title = TitleTextBox.Text,
                StatementOfResponsibility = StatementOfResponsibilityTextBox.Text,
                YearOfManufacture = Convert.ToInt32(yearOfManufactureTextBox.Text),
                NameJournal = NameJournalTextBox.Text,
                IssueNumber = Convert.ToInt32(JournalNumberTextBox.Text),
                //StartPage = Convert.ToInt32(startPageTextBox.Text),
                //EndPage = Convert.ToInt32(startPageTextBox.Text)
            };

        }
    }
}
