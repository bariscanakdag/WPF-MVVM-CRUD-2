using Customer.Helper;
using Customer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Customer.ViewModel
{
    public class YeniKisiViewModel : INotifyPropertyChanged
    {

        #region Constructor


        private MusteriModel musteri;

        public MusteriModel Musteri
        {
            get { return musteri; }
            set { musteri = value;
                OnPropertyChanged(nameof(Musteri));
            }
        }


        public YeniKisiViewModel(MusteriModel musteri)
        {
            this.Musteri = musteri;

        }

        private ICommand musteriKayit;

     

        public ICommand MusteriKayit
        {
            get
            {
                if (musteriKayit == null)
                    musteriKayit = new RelayCommand(KayitEt);
                return musteriKayit;


            }
        }



        #endregion


        #region Method
        public event EventHandler MusteriKaydet;
        private void KayitEt()
        {
            MusteriModel musteri = new MusteriModel();
            musteri.Adi = Musteri.Adi;
            musteri.Soyadi = Musteri.Soyadi;
            musteri.TelefonNo = Musteri.TelefonNo;
            musteri.Adres = Musteri.Adres;
            musteri.Bakiye = Musteri.Bakiye;
            MusteriProvider musteriProvider = new MusteriProvider();
            musteriProvider.MusteriSave(musteri);
            musteri = musteriProvider.TekPersonelGetir();
            if (MusteriKaydet != null)
            {
                MusteriKaydet(musteri, null);
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;


        #region INotifyPropertyChanged
        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }

        }
        #endregion

    }
}
