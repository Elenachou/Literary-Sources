using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Book : ILiterarySource
    {
        /// <summary>
        /// Год издания.
        /// </summary>
        private int _yearOfManufacture;

        /// <summary>
        /// Количество страниц
        /// </summary>
        private int _countOfPages;

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
        /// Год издания
        /// </summary>
        public int YearOfManufacture
        { 
            
            get { return _yearOfManufacture; }
            set
            {
                if (value > DateTime.Now.Year )
                {
                    throw new ArgumentException("Год издание не должен превышать текущий год");
                }
                _yearOfManufacture = value;
            }
        }

        /// <summary>
        /// Количество страниц.
        /// </summary>
        public int CountOfPages
        {
            get { return _countOfPages; }
            set
            {
                if (value < 0) 
                {
                    throw new ArgumentException("Количество страниц не может быть отрицательным числом!");
                }
                _countOfPages = value;
            }
        }
        
        /// <summary>
        /// Метод описания книги в строку
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return Author + "." + Title +"/"+ StatementOfResponsibility + "," + _yearOfManufacture + ".- " + _countOfPages;
        }
    }
}
