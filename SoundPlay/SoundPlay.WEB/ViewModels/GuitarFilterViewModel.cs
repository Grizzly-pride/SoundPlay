﻿namespace SoundPlay.Web.ViewModels;

public class GuitarFilterViewModel : ProductFilterViewModel
{
    public GuitarType Category { get; set; }
    public int? BrandId { get; set; }
    public int? ColorId { get; set; }
    public int? ShapeId { get; set; }
    public int? SoundboardId { get; set; }
    public int? NeckId { get; set; }
    public int? FretboardId { get; set; }
    public int? PickupSetId { get; set; }
    public int? TremoloTypeId { get; set; }

    [Display(Name = "Brands")]
    public IEnumerable<SelectListItem>? Brands { get; set; }
    [Display(Name = "Colors")]
    public IEnumerable<SelectListItem>? Colors { get; set; }
    [Display(Name = "Guitar Shapes")]
    public IEnumerable<SelectListItem>? GuitarShapes { get; set; }
    [Display(Name = "Soundboards")]
    public IEnumerable<SelectListItem>? Soundboards { get; set; }
    [Display(Name = "Necks")]
    public IEnumerable<SelectListItem>? Necks { get; set; }
    [Display(Name = "Fretboards")]
    public IEnumerable<SelectListItem>? Fretboards { get; set; }
    [Display(Name = "Pickup Sets")]
    public IEnumerable<SelectListItem>? PickupSets { get; set; }
    [Display(Name = "Tremolo Types")]
    public IEnumerable<SelectListItem>? TremoloTypes { get; set; }

    public GuitarFilterViewModel()
    {
    }

    public GuitarFilterViewModel(GuitarType category)
    {
        Category = category;
    }

    public GuitarFilterViewModel(
        decimal? priceStart,
        decimal? priceEnd,
        GuitarType category,
        List<CatalogProductViewModel>? products,
        IEnumerable<SelectListItem>? brands,
        IEnumerable<SelectListItem>? colors,
        IEnumerable<SelectListItem>? guitarShapes,
        IEnumerable<SelectListItem>? materials,
        IEnumerable<SelectListItem>? pickupSets,
        IEnumerable<SelectListItem>? tremoloTypes)            
        : base(priceStart, priceEnd, products)
    {
        Category = category;
        Brands = brands;
        Colors = colors;
        GuitarShapes = guitarShapes;
        Soundboards = materials;
        Necks = materials;
        Fretboards = materials;
        PickupSets = pickupSets;
        TremoloTypes = tremoloTypes;
    }
}