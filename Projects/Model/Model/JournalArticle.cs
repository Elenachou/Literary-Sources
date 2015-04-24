using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class JournalArticle : ILiterarySource
    {
        /// <summary>
        /// Год издания
        /// </summary>
        private int _yearOfManufacture;

        /// <summary>
        /// Номер журнала
        /// </summary>
        private int _issueNumber;

        /// <summary>
        /// Начальная страница статьи
        /// </summary>
        private int _startPage;

        /// <summary>
        /// Конечная страница статьи
        /// </summary>
        private int _endPage;

        /// <summary>
        /// Автор
        /// </summary>
        public string Author { set; get; }

        /// <summary>
        /// Заглавие
        /// </summary>
        public string Title { set; get; }

        /// <summary>
        /// Ответственный
        /// </summary>
        public string StatementOfResponsibility { set; get; }

        /// <summary>
        /// Название Журнала
        /// </summary>
        public string NameJournal { set; get; }

        /// <summary>
        /// Метод 
        /// </summary>
        public void SetStartAndEndPage(int startPage, int endPage)
        {
            if (startPage < 0)
            {
                throw new ArgumentException("Страница не может иметь отрицательное значение");
            }
            if (endPage < 0)
            {
                throw new ArgumentException("Страница не может иметь отрицательное значение");
            }
            if (startPage > endPage)
            {
                throw new ArgumentException("Начальная страница статьи не может превышать конечную");
            }
            _startPage = startPage;
            _endPage = endPage;
        }

        /// <summary>
        /// Номер журнала
        /// </summary>
        public int IssueNumber
        {
            get { return _issueNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество страниц не может быть отрицательным числом");
                }
                _issueNumber = value;
            }
        }

        /// <summary>
        /// Начальная страница статьи
        /// </summary>
        public int StartPage
        {
            get { return _startPage; }
        }

        /// <summary>
        /// Конечная страница статьи
        /// </summary>
        public int EndPage
        {
            get { return _endPage; }
        }

        /// <summary>
        /// Год издания
        /// </summary>
        public int YearOfManufacture
        {

            get { return _yearOfManufacture; }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Год издание не должен превышать текущий год");
                }
                _yearOfManufacture = value;
            }
        }

        /// <summary>
        /// Метод описания статьи из журнала в строку
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            var str = Author + ". " + Title + "/" + StatementOfResponsibility + "//" + NameJournal + ".- " + YearOfManufacture + ".- " + IssueNumber + ".- " + StartPage + "-" + EndPage;
            return str;
        }
    }
}
