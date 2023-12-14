using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace trabalho_final.Models
{
    public class Cliente
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;
    }
}