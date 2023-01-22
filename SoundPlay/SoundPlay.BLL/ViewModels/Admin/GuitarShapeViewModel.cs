﻿using System.ComponentModel;

namespace SoundPlay.BLL.ViewModels.Admin
{
    public sealed class GuitarShapeViewModel
    {
        public int Id { get; set; }

        [DisplayName("Guitar shape")]
        public string Name { get; set; }
    }
}