using Customer.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Helper
{
    public class MusteriProvider
    {

        /// <summary>
        /// Veritabanından tüm müşterileri çeker
        /// </summary>
        /// <returns>MusteriModel list tipinde geri döner</returns>
        #region  MusterileriGetir
        public List<MusteriModel> MusterileriGetir()
        {
            List<MusteriModel> musteriler = new List<MusteriModel>();
            string patch = @"C:\Users\asus\Desktop\Musteri.db";
            SQLiteConnection con = new SQLiteConnection("Data Source=" + patch);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("select * from Musteri", con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MusteriModel musteri = new MusteriModel();
                musteri.MusteriID = dr.GetInt32(dr.GetOrdinal("MusteriID"));
                musteri.Adi = dr.GetString(dr.GetOrdinal("Adi"));
                musteri.Soyadi = dr.GetString(dr.GetOrdinal("Soyadi"));
                musteri.TelefonNo = dr.GetString(dr.GetOrdinal("TelefonNo"));
                musteri.Adres = dr.GetString(dr.GetOrdinal("Adres"));
                musteri.Bakiye = dr.GetInt32(dr.GetOrdinal("Bakiye"));
                musteriler.Add(musteri);
            }
            con.Close();
            return musteriler;
        }
        #endregion


        /// <summary>
        /// Olan musteriyi günceller
        /// </summary>
        /// <param name="musteri"></param>
        #region MusteriUpdate
        public void MusteriUpdate(MusteriModel musteri)
        {
            string patch = @"C:\Users\asus\Desktop\Musteri.db";
            SQLiteConnection con = new SQLiteConnection("Data Source="+ patch);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("update Musteri set Adi=@adi,Soyadi=@soyadi,TelefonNo=@telefon,Adres=@adres,Bakiye=@bakiye where MusteriID=@id",con);
            cmd.Parameters.AddWithValue("@adi", musteri.Adi);
            cmd.Parameters.AddWithValue("@soyadi", musteri.Soyadi);
            cmd.Parameters.AddWithValue("@telefon", musteri.TelefonNo);
            cmd.Parameters.AddWithValue("@adres", musteri.Adres);
            cmd.Parameters.AddWithValue("@bakiye", musteri.Bakiye);
            cmd.Parameters.AddWithValue("@id", musteri.MusteriID);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        #endregion

        /// <summary>
        /// Gelen Musteri nesnesini veritabanına kayıt eder.
        /// </summary>
        /// <param name="musteri"></param>
        #region MusteriSave
        public void MusteriSave(MusteriModel musteri)
        {
            string patch = @"C:\Users\asus\Desktop\Musteri.db";
            SQLiteConnection con = new SQLiteConnection("Data Source=" + patch);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("insert into  Musteri(Adi,Soyadi,TelefonNo,Adres,Bakiye) values(@ad,@soyad,@tel,@adres,@bakiye) ", con);
            cmd.Parameters.AddWithValue("@ad", musteri.Adi);
            cmd.Parameters.AddWithValue("@soyad", musteri.Soyadi);
            cmd.Parameters.AddWithValue("@tel", musteri.TelefonNo);
            cmd.Parameters.AddWithValue("@adres", musteri.Adres);
            cmd.Parameters.AddWithValue("@bakiye", musteri.Bakiye);
            cmd.ExecuteNonQuery();
            con.Close();


        }
        #endregion

        /// <summary>
        /// Son eklenen kaydı getirir
        /// </summary>
        /// <returns>Musteri tipinde</returns>
        #region TekPersonelGetir
        public MusteriModel TekPersonelGetir()
        {
            string patch = @"C:\Users\asus\Desktop\Musteri.db";
            SQLiteConnection con = new SQLiteConnection("Data Source=" + patch);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Musteri ORDER BY MusteriID DESC LIMIT 1 ", con);

            SQLiteDataReader dr = cmd.ExecuteReader();
            MusteriModel musteri = new MusteriModel();

            while (dr.Read())
            {
               
                musteri.MusteriID = dr.GetInt32(dr.GetOrdinal("MusteriID"));
                musteri.Adi = dr.GetString(dr.GetOrdinal("Adi"));
                musteri.Soyadi = dr.GetString(dr.GetOrdinal("Soyadi"));
                musteri.TelefonNo = dr.GetString(dr.GetOrdinal("TelefonNo"));
                musteri.Adres = dr.GetString(dr.GetOrdinal("Adres"));
                musteri.Bakiye = dr.GetInt32(dr.GetOrdinal("Bakiye"));
                
            }
            return musteri;

        }
        #endregion


        /// <summary>
        /// Musteri nesnesi alır veritabanından belirli müşteriyi siler
        /// </summary>
        /// <param name="musteri"></param>
        #region  MusteriSil
        public void MusteriSil(MusteriModel musteri)
        {
            string patch = @"C:\Users\asus\Desktop\Musteri.db";
            SQLiteConnection con = new SQLiteConnection("Data Source=" + patch);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("delete from  Musteri where MusteriID=@id ", con);
            cmd.Parameters.AddWithValue("@id", musteri.MusteriID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
    }
}
