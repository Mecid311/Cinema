using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaPro.Domain.Entity
{
    public class Bankclient
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public decimal CartNumber { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Cvc { get; set; }
        [Required]
        public float Money { get; set; }
    }
}
