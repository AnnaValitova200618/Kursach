using System;
using System.Collections.Generic;
using System.Text;

namespace Kursach.Tools
{
    internal class AttributeTable : Attribute
    /*генерация запросов */
    {
        public string Table { get; }
        public AttributeTable(string table) 
        {
            Table = table;
        }
    }
}
