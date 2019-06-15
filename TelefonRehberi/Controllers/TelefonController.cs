using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TelefonRehber.DAL;

namespace TelefonRehberi.Controllers
{
    public class TelefonController : ApiController
    {


        /// <summary>
        /// Telefon Ekleme
        /// </summary>
        /// <param name="telefon"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        //[HttpGet]
        [HttpPost]


        public string AddTel(Telefon telefon,int id)
        {
            Telefonbll telbll = new Telefonbll();
            KisiBLL kisibll = new KisiBLL();
            Kisi kisiler = kisibll.GetPeopleId(id);
            Telefon tel  = new Telefon();
            tel.KisiId = kisiler.KisiId;
            tel.TelefonNumarası = telefon.TelefonNumarası;
            telbll.AddTel(tel);
            
            

            return kisiler.KisiAdi + "nın "+tel.TelefonNumarası+"database eklendi";

        }
        /// <summary>
        /// Kişiye göre telefon numarası listeleme
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Telefon> GetTelefons(int id)
        {
            Telefonbll telbll = new Telefonbll();
            KisiBLL kisibll = new KisiBLL();
            Kisi k = kisibll.GetPeopleId(id);
            List<Telefon> t = telbll.GetTelefons(k.KisiId);
            return t;
        }
       
        [HttpPost]
        public void DeleteTelephone(int id)
        {
            Telefonbll tel = new Telefonbll();
            tel.DeleteTelefon(id);
           
        }
        [HttpGet]
        public Telefon Telgetir(int id)
        {
            Telefonbll telbll = new Telefonbll();
            Telefon t = telbll.TelefonGetir(id);
            return t;
        }

        [HttpPost]
        public void Update(Telefon model)
        {
            Telefonbll telbll = new Telefonbll();
            Telefon tel = telbll.TelefonGetir(model.TelefonId);
            tel.TelefonNumarası = model.TelefonNumarası;

            telbll.UpdateTelefon(tel);
       

        }



    }
}
