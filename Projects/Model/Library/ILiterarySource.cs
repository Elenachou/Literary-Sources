using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ILiterarySourceBase
    {
        private string Autor;
        private string TitleOfArticle;
        private string StatementOfResponsibility;
        private int YearOfManufacture;
        
        
        public string GetDescription()
        {
            return "";
        }
    }
}
