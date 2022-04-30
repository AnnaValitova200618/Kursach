using Kursach.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursach.Pages
{
    /// <summary>
    /// Логика взаимодействия для CouchPage1.xaml
    /// </summary>
    public partial class CouchPage1 : Page
    {
        public CouchPage1()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }
    }
}
