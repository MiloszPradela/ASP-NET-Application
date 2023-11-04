using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium3_App.Models
{
    public enum Priority
    {
        [Display(Name = "Niski")]
        Low,
        [Display(Name = "Normalny")]
        Normal,
        [Display(Name = "Pilny")]
        High,
        [Display(Name = "Bardzo Pilny")] 
        Urgent
    }
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name="Imię")]
        [Required(ErrorMessage = "Musisz podać imię")]
        [StringLength(maximumLength: 50, ErrorMessage = "Wprowadzone imię jest za długie, wprowadź maksymalnie do 50 znaków.")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Musisz podać poprawny email")]
        [Display(Name = "Adres email")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Podaj numer telefonu")]
        [Display(Name ="Numer telefonu")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(Name="Data urodzin")]
        [DataType(DataType.Date)]
        public DateTime? Birth { get; set; }
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput(DisplayValue = false)]
        public DateTime Created { get; set; }
    }
}
