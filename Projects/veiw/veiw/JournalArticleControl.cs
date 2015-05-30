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
                Author = authorTextBox.Text,
                Title = titleTextBox.Text,
                StatementOfResponsibility = statementOfResponsibilityTextBox.Text,
                YearOfManufacture = Convert.ToInt32(yearOfManufactureTextBox.Text),
                NameJournal = nameJournalTextBox.Text,
                IssueNumber = Convert.ToInt32(issueNumberTextBox.Text),
                //StartPage = Convert.ToInt32(startPageTextBox.Text),
                //EndPage = Convert.ToInt32(startPageTextBox.Text)
            };

        }
    }
}
