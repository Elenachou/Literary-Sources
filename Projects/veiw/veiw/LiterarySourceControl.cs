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
            bookControl.Size = new Size(FieldsGroupBox.Width-20, bookControl.Height);
            bookControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            bookControl.Visible = true;
        }

        private void ElectronicResourceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ElectronicResourceControl electronicResourceControl = new ElectronicResourceControl();
            FieldsGroupBox.Controls.Clear();
            FieldsGroupBox.Controls.Add(electronicResourceControl);
            electronicResourceControl.Location = new Point(3, 11);
            electronicResourceControl.Size = new Size(FieldsGroupBox.Width - 20, electronicResourceControl.Height);
            electronicResourceControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            electronicResourceControl.Visible = true;
        }

        private void JournalArticleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            JournalArticleControl journalArticleControl = new JournalArticleControl();
            FieldsGroupBox.Controls.Clear();
            FieldsGroupBox.Controls.Add(journalArticleControl);
            journalArticleControl.Location = new Point(3, 11);
            journalArticleControl.Size = new Size(FieldsGroupBox.Width - 20, journalArticleControl.Height);
            journalArticleControl.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            journalArticleControl.Visible = true;
        }
        public ILiterarySource GetLiterarySource()
        {
           
            if (BookRadioButton.Checked)
            {
                LiterarySource = _bookControl.GetBook();
            }
            if (ElectronicResourceRadioButton.Checked)
            {
                LiterarySource = _electronicResourceControl.GetElectronicResource();
            }
            if (JournalArticleRadioButton.Checked)
            {
                LiterarySource = _journalArticleControl.GetJournalArticle();
            }
            return LiterarySource;
        }
    }
}
