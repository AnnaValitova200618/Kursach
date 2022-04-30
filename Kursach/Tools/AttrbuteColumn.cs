using System;
using System.Collections.Generic;
using System.Text;

namespace Kursach.Tools
{
    internal class AttrbuteColumn : Attribute
        /*генерация запросов */
    {
        public string Column { get; }
        public AttrbuteColumn(string column)
        {
            Column = column;
        }
    }
}
