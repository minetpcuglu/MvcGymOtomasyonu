//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcGymOtomasyonu.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUye
    {
        public int Id { get; set; }
        public string AdıSoyad { get; set; }
        public string Telefon { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<int> Yas { get; set; }
        public Nullable<int> Odeme { get; set; }
        public string Zamanlama { get; set; }
    }
}
