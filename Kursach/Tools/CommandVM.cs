using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Kursach.Tools
{
    public class CommandVM : ICommand
    {
        Action action;

        public CommandVM(Action action)
        {
            this.action = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           action();
        }
    }
}
