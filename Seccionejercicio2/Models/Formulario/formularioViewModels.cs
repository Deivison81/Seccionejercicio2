using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seccionejercicio2.Models.Formulario
{
    public class formularioViewModels
    {
        [MaxLength(6)]
        [RegularExpression("[MXM] {3}-[0-9]{3}")]
        public string Usuario { get; set; }
        [StringLength(15, MinimumLength = 5)]
        public string nombre { get; set; }
        [StringLength(10, MinimumLength = 5)]
        public string cargo { get; set; }
        [Phone]
        //[RegularExpression("[\+-]?")]
        public string telefono { get; set; }

        [EmailAddress]
        public string correore { get; set; }

    }
}