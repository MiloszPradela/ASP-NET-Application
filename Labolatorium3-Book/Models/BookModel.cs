﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium3_Book.Models
{
    public class Book
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tytuł jest wymagany!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Wprowadzony tytuł jest za długi, wprowadź  tytuł maksymalnie do 50 znaków.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Wprowadzone imię jest za długie, wprowadź maksymalnie do 50 znaków.")]
        public string Author { get; set; }

        public string PageNumber { get; set; }

        [StringLength(13, MinimumLength = 13, ErrorMessage = "Pole musi mieć dokładnie 13 znaków.")]
        public string ISBN { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string PublicationYear { get; set; }

        public string Publisher { get; set; }
    }
}