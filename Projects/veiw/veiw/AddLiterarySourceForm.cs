using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace veiw
{
    public partial class AddLiterarySourceForm : Form
    {
        public ILiterarySource LiterarySource { get; set; }

        public AddLiterarySourceForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Кнопка для перехода на главную форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Кнопка для создания объекта путем рандомного генерирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomButton_Click(object sender, EventArgs e)
        {
            String[] strAuthor =
            {
                "Чоу Е.Д.",
                "Шурыгин Ю.А.",
                "Гробовой Н.Ю.",
                "Смирнов О.Ж.",
                "Павлова Н.К.",
                "Казинак Т.М. "
            };
            Random author = new Random();
            int a = author.Next(0, 6);

            String[] strTitle =
            {
                "Любовь и ненависть",
                "До края 1000 шагов",
                "Анализ и оценка оперативной обстановки в республике, крае, области",
                "Маркетинг и менеджмент",
                "Инвестиции в человеческий капитал",
                "Будем читать. Глядишь, и кризис пройдет"
            };
            Random title = new Random();
            int t = title.Next(0, 6);

            String[] strResponsibility =
            {
                "И.И. Думова, М.В. Колесникова",
                "Шурыгин Ю.А.",
                "Гробовой Н.Ю.",
                "Смирнов О.Ж.",
                "Павлова Н.К.",
                "Казинак Т.М. "
            };
            Random res = new Random();
            int r = res.Next(0, 6);


            String[] strYear =
            {
                "2003",
                "1998",
                "2007",
                "1978",
                "2009",
                "2003"
            };
            Random year = new Random();
            int y = year.Next(0, 6);

        }

        private void addFieldsButton_Click(object sender, EventArgs e)
        {
            fieldsGroupBox.Visible = bookRadioButton.Checked;
            //if (bookRadioButton.Checked)
            //{
            //    fieldsGroupBox.Visible = false;
            //
            //}
        }

        private void bookRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //fieldsGroupBox.Controls.Clear();
            //fieldsGroupBox.Controls.Add(BookControl);
            //BookControl.Location = new Point(0, 0);
        }

        private void fieldsGroupBox_ControlAdded(object sender, ControlEventArgs e)
        {
            fieldsGroupBox.Controls.Clear();
            fieldsGroupBox.Controls.Add(Bookcontrol);
            BookControl.Location = new Point(0, 0);
        }
    }
}
