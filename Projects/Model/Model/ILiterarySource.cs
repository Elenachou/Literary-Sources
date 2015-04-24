using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Интерфейс литературный источник
    /// </summary>
    public interface ILiterarySource
    {
        /// <summary>
        /// Метод описания объекта в строку
        /// </summary>
        /// <returns></returns>
        string GetDescription();
        
    }
}
