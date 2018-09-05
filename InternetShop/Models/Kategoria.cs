using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetShop.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe kategorii")]
        [StringLength(100)]
        public string NazwaKategorii { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe kategorii")]
        public string Opiskategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Kurs> Kursy { get; set; }
    }
}