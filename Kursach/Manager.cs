using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Kursach
{
   public class Manager : IDataErrorInfo
    {

        public string this[string columnName]
        {
            get {
                Error = null;
                switch (columnName)
                {
                    case "Login":
                        if (string.IsNullOrEmpty(Login))
                            Error = "Введите имя";
                        else if (Login != "AnnA")
                            Error = "Введено неверное имя"; 
                        break;
                    case "Password":
                        if (string.IsNullOrEmpty(Password))
                            Error = "Введите пароль";
                        else if (Password != "110704")
                            Error = "Введен неверный пароль";
                        break;
                }
             return Error;
            }
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public string Error { get ; set; }
    }
}
