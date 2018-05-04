using Customer.Helper;
using Customer.Model;
using Customer.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Customer.ViewModel
{
    public class MusteriViewModel : INotifyPropertyChanged
    {
        MusteriProvider musteriProvider = new MusteriProvider();

        #region Constructor 
        private ObservableCollection<MusteriModel> musteriList;

        public ObservableCollection<MusteriModel> MusteriList
        {
            get { return musteriList; }
            set
            {
                musteriList = value;
                OnPropertyChanged(nameof(MusteriList));
            }
        }

        public MusteriViewModel()
        {
            MusteriList = new ObservableCollection<MusteriModel>(musteriProvider.MusterileriGetir());
        }
        private ICommand saveMusteri;

        public ICommand SaveMusteri
        {
            get
            {

                if (saveMusteri == null)
                    saveMusteri = new RelayCommand(MusteriGuncelle);
                return saveMusteri;

            }

        }

        private MusteriModel selectItem;

        public MusteriModel SelectItem
        {
            get { return selectItem; }
            set
            {
                selectItem = value;
                OnPropertyChanged(nameof(SelectItem));
            }
        }

        private ICommand deleteMusteri;

        public ICommand DeleteMusteri
        {
            get
            {
                if (deleteMusteri == null)
                    deleteMusteri = new RelayCommand(MusteriSil);
                return deleteMusteri;

            }

        }
        private ICommand yeniKisi;

        public ICommand YeniKisi
        {

            get
            {
                if (yeniKisi == null)
                    yeniKisi = new RelayCommand(KisiEkle);
                return yeniKisi;


            }
        }


        #endregion



        #region Methodlar
        private void MusteriGuncelle()
        {
            MusteriModel musteri = new MusteriModel();
            musteri.MusteriID = SelectItem.MusteriID;
            musteri.Adi = SelectItem.Adi;
            musteri.Soyadi = SelectItem.Soyadi;
            musteri.TelefonNo = SelectItem.TelefonNo;
            musteri.Adres = SelectItem.Adres;
            musteri.Bakiye = SelectItem.Bakiye;
            musteriProvider.MusteriUpdate(musteri);
        }

        private void MusteriSil()
        {
            musteriProvider.MusteriSil(selectItem);
            MusteriList.Remove(selectItem);
        }

        YeniKisiWindow window;
        private void KisiEkle()
        {
            if (window == null)
            {
                MusteriModel musteri = new MusteriModel();
                window = new YeniKisiWindow(musteri);
                window.YeniKisiViewModel.MusteriKaydet += YeniKisiViewModelMusteriKaydet;
                window.Closing += YeniKisiWindowClosing;
                window.Show();
            }
            else
            {
                window.Focus();
            }


        }

        private void YeniKisiWindowClosing(object sender, CancelEventArgs e)
        {
            window.Dispose();
            window = null;
            
        }

        private void YeniKisiViewModelMusteriKaydet(object sender, EventArgs e)
        {

            window.Close();
            MusteriList.Add((MusteriModel)sender);

        }





        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
    #endregion


}
