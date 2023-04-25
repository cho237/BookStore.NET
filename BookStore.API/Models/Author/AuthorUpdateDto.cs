﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models.Author
{
    public class AuthorUpdateDto : BaseDto
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(250)]
        public string Bio { get; set; }
    }
}
