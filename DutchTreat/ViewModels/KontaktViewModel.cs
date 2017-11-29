using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.ViewModels
{
    public class KontaktViewModel
    {
        [Required]
        [MinLength(5, ErrorMessage = "Das Feld 'Name' muss mindestens 5 Buchstaben haben!")]
        public string name { get; set; }
     
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string betreff { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "Das Feld 'Nachricht' darf max. 250 Zeichen lang sein!")]
        public string nachricht { get; set; }
    }
}
