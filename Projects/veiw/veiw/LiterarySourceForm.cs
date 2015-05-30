using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Model;

namespace view
{
    public partial class LiterarySourceForm : Form
    {
        /// <summary>
        /// Таблица
        /// </summary>
        public DataTable LiterarySources { get; set; }

        /// <summary>
        /// Список Литературных источников
        /// </summary>
        private List<ILiterarySource> Literure { get; set; }

        private Dictionary<DataRow, ILiterarySource> hjhk;

        /// <summary>
        /// Главная форма
        /// </summary>
        public LiterarySourceForm()
        {
            InitializeComponent();
            LiterarySources = new DataTable();
            var column = new DataColumn()
            {
                Caption = "LiterarySource",
                ColumnName = "LiterarySource",
                ReadOnly = true,
                DataType = typeof(string)
            };
            LiterarySources.Columns.Add(column);
            column = new DataColumn()
            {
                Caption = "GetDescription",
                ColumnName = "GetDescription",
                ReadOnly = true,
                DataType = typeof(string)
            };
            LiterarySources.Columns.Add(column);
            DescriptionSourceDataGridView.DataSource = LiterarySources;
            DescriptionSourceDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Кнопка при нажатии на которую открывается форма для создания нового объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLiterarySourceButton_Click(object sender, EventArgs e)
        {
            AddLiterarySourceForm sourceForm = new AddLiterarySourceForm();
            sourceForm.ShowDialog();
            if (sourceForm.DialogResult == DialogResult.OK)
            {
                var source = sourceForm.GetLiterarySource();

                Literure.Add(source);
                LiterarySources.Rows.Add("Source", source.GetDescription());
            }
        }

        /// <summary>
        /// Кнопка для закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

