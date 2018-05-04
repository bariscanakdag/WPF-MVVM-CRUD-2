using Customer.View;
using Customer.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Customer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MusteriWindowView window = new MusteriWindowView();
            MusteriViewModel VM = new MusteriViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
