﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Aguiar.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string Title { get; set; }

        [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo {  get; set; }
        public bool CopiedToPlex { get; set; }



        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? Notes { get; set; }
        


    }
}