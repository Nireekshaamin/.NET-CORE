using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DFA_CORE.Models
{
    public partial class Trainee
    {
        [Key]
        [Required(ErrorMessage = "Id is required")]
        public int Tid { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [MaxLength(15,ErrorMessage ="Max length should be 15")]
        [MinLength(3, ErrorMessage = "Min length should be 3")]
        public string? Tname { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(23,100,ErrorMessage ="Age should be more than 18")]
        public int? Tage { get; set; }
    }
}
