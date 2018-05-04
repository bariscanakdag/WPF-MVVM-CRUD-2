using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Model
{
    public class MusteriModel
    {
        #region MusteriModel Constructor 
      
        private int musteriID;
        public int MusteriID
        {
            get { return musteriID; }
            set { musteriID = value; }
        }

        private string adi;

        public string  Adi
        {
            get { return adi; }
            set { adi = value; }
        }
        private string soyadi;

        public string Soyadi
        {
            get { return soyadi; }
            set { soyadi = value; }
        }
        private string telefonNo;

        public string TelefonNo
        {
            get { return telefonNo; }
            set { telefonNo = value; }
        }
        private string adres;

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        private int bakiye;

        public int Bakiye
        {
            get { return bakiye; }
            set { bakiye = value; }
        }





        #endregion
    }
}
