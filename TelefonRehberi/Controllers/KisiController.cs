using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TelefonRehber.DAL;

namespace TelefonRehberi.Controllers
{
    public class KisiController : ApiController
    {
        /// <summary>
        /// Kişileri listele
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Kisi> GetPeople()
        {
            KisiBLL kisiler = new KisiBLL();
            return kisiler.GetPeople();
        }
        /// <summary>
        /// Kişi ekle 
        /// </summary>
        /// <param name="kisi"></param>
        /// <returns></returns>
        //[HttpGet]
        [HttpPost]

        public string AddPeople(Kisi kisi)
        {
            KisiBLL kisiler = new KisiBLL();
            Kisi person = new Kisi();
            person.KisiAdi = kisi.KisiAdi;
            person.Meslegi = kisi.Meslegi;
            person.Soyadı = kisi.Soyadı;
            kisiler.Addpeope(person);              
            return  person.KisiAdi+ "database eklendi";
        }
        [HttpGet]
        public List<Telefon> GetTelephone(int id)
        {
            Telefonbll tel = new Telefonbll();
            //KisiBLL kisiler = new KisiBLL();
            //Kisi k = kisiler.GetPeopleId(id);
            List<Telefon> kis = tel.GetTelefons(id);
            return kis;
            
        }
        [HttpGet]
        public Kisi GetInsan(int id)
        {
            KisiBLL k = new KisiBLL();
            Kisi ki = k.GetInsan(id);
            return ki;
        }
       


       

    }
}
