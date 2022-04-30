using Kursach.MoreWindow;
using Kursach.Pages;
using Kursach.Tools;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Kursach.ViewModels
{
    public class MainVM : BaseVM
    {
        CurrentPageControl currentPageControl;
        private Visibility entered = Visibility.Hidden;

        public Page CurrentPage
        {
            get => currentPageControl.Page;
        }

        public Visibility Entered
        {
            get => entered;
            set
            {
                entered = value;
                Signal();
            }
        }
        public CommandVM OpenTreners { get; set; }
        public CommandVM OpenCouch { get; set; }
        public CommandVM OpenSportsman { get; set; }
        public CommandVM LogIn { get; set; }
        public CommandVM OpenAttendance { get; set; }
        public CommandVM OpenVacation { get; set; }
        public CommandVM OpenListVacation { get; set; }
        public Manager EditManager { get; set; }

        public MainVM()
        {
            EditManager = new Manager();
            currentPageControl = new CurrentPageControl();
            currentPageControl.PageChanged += CurrentPageControl_PageChanged;
            currentPageControl.SetPage(new HomePage(this));
            OpenTreners = new CommandVM(() => { currentPageControl.SetPage(new TrenersPage()); });
            OpenCouch = new CommandVM(() => { currentPageControl.SetPage(new CouchPage1()); });
            OpenSportsman = new CommandVM(() => { currentPageControl.SetPage(new SportsmanPage()); });
            OpenAttendance = new CommandVM(() => { new AttendanceWindow().Show(); });
            OpenVacation = new CommandVM(() => { new VacationWindow().Show(); });
            OpenListVacation = new CommandVM(() => { new ListVacation().Show(); });
            LogIn = new CommandVM(() =>
            {
                if (string.IsNullOrEmpty(EditManager.Error))
                {
                    Entered = Visibility.Visible;
                    currentPageControl.SetPage(new TrenersPage());
                }
            });
        }
        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }
    }
}
