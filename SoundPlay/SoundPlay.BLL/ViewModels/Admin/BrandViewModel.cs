﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SoundPlay.BLL.ViewModels.Admin
{
    public sealed class BrandViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Brand")]
        public string? Name { get; set; }
    }
}