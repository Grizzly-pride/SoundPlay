﻿namespace SoundPlay.Core.Extensions;

public static class SelectListItemExtensions
{
    public static List<SelectListItem> ToSelectListItems<TItem>(this IEnumerable<TItem> items)
        where TItem : Item
    {
        return items.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }).ToList();
    }

    public static List<SelectListItem> ToSelectListItems<TItem>(this IEnumerable<TItem> items, SelectListItem defaultItem)
        where TItem : Item
    {
        var selectList = items.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }).ToList();
        selectList.Insert(0, defaultItem);
        return selectList;
    }
}