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
    /// Логика взаимодействия для TrenersPage.xaml
    /// </summary>
    public partial class TrenersPage : Page
    {
        public TrenersPage()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }
    }
}
