using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KarcicegiYayinVeDagitim.Models
{
    public class ShippingDetails
    {
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Adres tanımını giriniz")]
        public string AdresBasligi { get; set; }
        [Required(ErrorMessage = "Lütfen Adres giriniz")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen Sehir giriniz")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen Semt giriniz")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen Mahalle giriniz")]
        public string Mahalle { get; set; }
        [Required(ErrorMessage = "Lütfen PosteKodu giriniz")]
        public string PosteKodu { get; set; }
    }
}