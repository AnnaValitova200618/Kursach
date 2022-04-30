using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Kursach.Tools
{
    public class CurrentPageControl
    {
        /*хранение в себе ссылки на отбражаемую в данный
        момент страницу*/
        Stack<Page> pages = new Stack<Page>();

        public Page Page { get; internal set; }
        public event EventHandler PageChanged;

        internal void SetPage(Page optionPage)
            /*метод, который меняет страницу */
        {
            if (Page != null)
                pages.Push(Page);
            Page = optionPage;
            PageChanged?.Invoke(this, new EventArgs());
        }

        internal void Back()
        {
            if (pages.Count > 0)
                Page = pages.Pop();
            else
                Page = null;
            PageChanged?.Invoke(this, new EventArgs());
        }
    }
}