﻿namespace SoundPlay.BLL.ViewModels.Admin;

public sealed class CreateGuitarViewModel
{
    public GuitarViewModel? GuitarViewModel { get; set; }
    public IEnumerable<SelectListItem>? Categories { get; set; }
    public IEnumerable<SelectListItem>? Brands { get; set; }
    public IEnumerable<SelectListItem>? Colors { get; set; }
    public IEnumerable<SelectListItem>? GuitarShapes { get; set; }
    public IEnumerable<SelectListItem>? Soundboards { get; set; }
    public IEnumerable<SelectListItem>? Necks { get; set; }
    public IEnumerable<SelectListItem>? Fretboards { get; set; }
    public IEnumerable<SelectListItem>? PickupSets { get; set; }
    public IEnumerable<SelectListItem>? TremoloTypes { get; set; }
}
