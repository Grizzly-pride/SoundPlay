﻿namespace SoundPlay.Core.Models;

public class AppUser : IdentityUser
{
    public string Name { get; set; }
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public string? PhoneNumber { get; set; }
}
