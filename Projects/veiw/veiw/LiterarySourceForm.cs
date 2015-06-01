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
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms.VisualStyles;
using Model;

namespace view
{
    public partial class LiterarySourceForm : Form
    {
        private SourcesList sourcesList;
        private ILiterarySource source;
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
            sourcesList = new SourcesList();
            foreach (DataGridViewColumn col in DescriptionSourceDataGridView.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            DescriptionSourceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void AddLiterarySourceButton_Click(object sender, EventArgs e)
        {
            AddLiterarySourceForm sourceForm = new AddLiterarySourceForm();
            sourceForm.ShowDialog();
            if (sourceForm.DialogResult != DialogResult.Cancel)
            {
                var newRow = LiterarySources.NewRow();
                source = sourceForm.GetLiterarySource();
                if (source is Book)
                {
                    newRow[0] = "Book";
                }
                if (source is JournalArticle)
                {
                    newRow[0] = "JournalArticle";
                }
                if (source is ElectronicResource)
                {
                    newRow[0] = "ElectronicResource";
                }
                newRow[1] = source.GetDescription();
                LiterarySources.Rows.Add(newRow);
                sourcesList.Add(source);
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

        private void RemoveLiterarySourceButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in DescriptionSourceDataGridView.SelectedRows)
            {
                sourcesList.RemoveAt(dr.Index);
                DescriptionSourceDataGridView.Rows.Remove(dr);
            }
        }
    }
}

