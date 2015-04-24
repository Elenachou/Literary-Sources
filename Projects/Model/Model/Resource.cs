using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Resource : ILiterarySource
    {
        /// <summary>
        /// Год издания.
        /// </summary>
        public string YearOfManufacture { get; set; }

        /// <summary>
        /// Автор
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Заглавие
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Ответственный
        /// </summary>
        public string StatementOfResponsibility { get; set; }



        public string GetDescription()
        {
            //return authorTextBox.Text + ". " + titleTextBox.Text + "/" + statementOfResponsibilityTextBox + "," + yearOfManufactureTextBox;
            return "Ololololo";
        }

    }
}
