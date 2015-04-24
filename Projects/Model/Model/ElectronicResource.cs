using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ElectronicResource : ILiterarySource
    {
        
        private int _yearOfManufacture;

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
                if (value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Год издание не должен превышать текущий год");
                }
                _yearOfManufacture = value;
            }
        }

        /// <summary>
        /// Тип ресурса
        /// </summary>
        public string TypeOfResource { set; get; }

        /// <summary>
        /// Место издания
        /// </summary>
        public string PlaceOfPublication { get; set; }

        /// <summary>
        /// Издательство
        /// </summary>
        public string PublishingHouse { get; set; }

        /// <summary>
        /// Серия
        /// </summary>
        public string Series { get; set; }

        /// <summary>
        /// Метод описания Электронного ресурса в строку
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            var str = Author + ". " + Title + ".-/" + StatementOfResponsibility + ".-" + TypeOfResource + ".-" + PlaceOfPublication + ":" + PublishingHouse + "," + _yearOfManufacture + ".-" + Series;
            return str;
        }


    }
}
