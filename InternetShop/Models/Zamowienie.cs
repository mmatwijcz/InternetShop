﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetShop.Models
{
    public class Zamowienie
    {
        public int ZamowienieId { get; set; }
        [Required(ErrorMessage = "Wprowadz imie")]
        [StringLength(50)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwisko")]
        [StringLength(50)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Wprowadz ulice")]
        [StringLength(100)]
        public string Ulica { get; set; }
        [Required(ErrorMessage = "Wprowadz miasto")]
        [StringLength(100)]
        public string Miasto { get; set; }
        [Required(ErrorMessage = "Wprowadz kod pocztowy")]
        [StringLength(6)]
        public string KodPocztowy { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public string Komentarz { get; set; }
        public DateTime DataDodania { get; set; }
        public StanZamowienia StanZamowienia { get; set; }
        public decimal WartoscZamowienia { get; set; }
        List<PozycjaZamowienia> PozycjaZamowienia { get; set; }
    }

    public enum StanZamowienia
    {
        Nowe,
        Zrealizowane

    }

}