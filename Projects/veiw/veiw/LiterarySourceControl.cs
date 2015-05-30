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
    public partial class LiterarySourceControl : UserControl
    {
        public ILiterarySource LiterarySource { get; set; }

        private BookControl _bookControl = new BookControl();
        private ElectronicResourceControl _electronicResourceControl = new ElectronicResourceControl();
        private JournalArticleControl _journalArticleControl = new JournalArticleControl();

        public LiterarySourceControl()
        {
            InitializeComponent();
        }

        private void BookRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BookControl bookControl = new BookControl();
            FieldsGroupBox.Controls.Clear();
            FieldsGroupBox.Controls.Add(bookControl);
            bookControl.Location = new Point(3, 11);
            bookControl.Visible = true;
        }

        private void ElectronicResourceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ElectronicResourceControl electronicResourceControl = new ElectronicResourceControl();
            FieldsGroupBox.Controls.Clear();
            FieldsGroupBox.Controls.Add(electronicResourceControl);
            electronicResourceControl.Location = new Point(3, 11);
            electronicResourceControl.Visible = true;
        }

        private void JournalArticleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            JournalArticleControl journalArticleControl = new JournalArticleControl();
            FieldsGroupBox.Controls.Clear();
            FieldsGroupBox.Controls.Add(journalArticleControl);
            journalArticleControl.Location = new Point(3, 11);
            journalArticleControl.Visible = true;
        }
        public ILiterarySource GetLiterarySource()
        {
            ILiterarySource source = null;
            if (BookRadioButton.Checked)
            {
                source = _bookControl.GetBook();
            }
            if (ElectronicResourceRadioButton.Checked)
            {
                source = _electronicResourceControl.GetElectronicResource();
            }
            if (JournalArticleRadioButton.Checked)
            {
                source = _journalArticleControl.GetJournalArticle();
            }
            return source;
        }
    }
}
