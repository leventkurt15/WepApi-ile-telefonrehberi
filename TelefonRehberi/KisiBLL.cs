using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelefonRehber.DAL;

namespace TelefonRehberi
{
    public  class KisiBLL
    {
        static DataContext db = new DataContext();
        public List<Kisi> GetPeople()
        {

            var people = db.Kisi.ToList();
            return people;
        }
        public Kisi GetInsan(int id)
        {

            var people = db.Kisi.Where(x=>x.KisiId==id).FirstOrDefault();
            return people;
        }

        public void Addpeope(Kisi kisi)
        {
            db.Kisi.Add(kisi);
            db.SaveChanges();

        }
        public Kisi GetPeopleId(int id)
        {
            var kis = db.Kisi.Where(x => x.KisiId == id).FirstOrDefault();
            return kis;

        }

        

    }
}