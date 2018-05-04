using Customer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Customer.View
{
    /// <summary>
    /// Interaction logic for YeniKisiWindow.xaml
    /// </summary>
    public partial class YeniKisiWindow : Window,IDisposable
    {
        public YeniKisiViewModel  YeniKisiViewModel;
        public YeniKisiWindow(Model.MusteriModel musteri)
        {
            InitializeComponent();
            YeniKisiViewModel = new YeniKisiViewModel(musteri);
            DataContext = YeniKisiViewModel;

        }

        public void Dispose()
        {
            YeniKisiViewModel = null;
            GC.SuppressFinalize(this);
            GC.Collect();
        }
    }
}
