using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelefonRehber.DAL;

namespace TelefonRehberi
{
    public class Telefonbll
    {
        static DataContext db = new DataContext();
        public void AddTel(Telefon tel)
        {
            db.Telefon.Add(tel);
            db.SaveChanges();

        }
        public  List<Telefon> GetTelefons(int id)
        {
            var result= db.Telefon.Where(x => x.KisiId == id).ToList();
            return result;
        }
        public void DeleteTelefon(int id)
        {
            var tel = db.Telefon.Where(x => x.TelefonId == id).FirstOrDefault();
            db.Telefon.Remove(tel);
            db.SaveChanges();

        }
        public Telefon TelefonGetir(int id)
        {

            var tele = db.Telefon.Where(x => x.TelefonId == id).FirstOrDefault();
            return tele;
        }
        public void UpdateTelefon(Telefon telo)
        {
            db.SaveChanges();
        }
    }
}