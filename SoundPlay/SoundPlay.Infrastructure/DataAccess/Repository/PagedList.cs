﻿namespace SoundPlay.Infrastructure.DataAccess.Repository;

public sealed class PagedList<TItem> : IPagedList<TItem> where TItem : class
{
    public int IndexFrom { get; init; }

    public int PageIndex { get; init; }

    public int PageSize { get; init; }

    public int TotalCount { get; init; }

    public int TotalPages { get; init; }

    public IList<TItem> Items { get; init; }

    public bool HasPreviousPage => PageIndex - IndexFrom > 0;

    public bool HasNextPage => PageIndex - IndexFrom + 1 < TotalPages;

    internal PagedList(IEnumerable<TItem> source, int pageIndex, int pageSize, int indexFrom)
    {
        if (indexFrom > pageIndex)
        {
            throw new ArgumentException(
                $"indexFrom: {indexFrom} > pageIndex: {pageIndex}, must indexFrom <= pageIndex");
        }

        if (source is IQueryable<TItem> queryable)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            IndexFrom = indexFrom;
            TotalCount = queryable.Count();
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);
            Items = queryable.Skip((PageIndex - IndexFrom) * PageSize).Take(PageSize).ToList();
        }
        else
        {
            var enumerable = source.ToList();
            PageIndex = pageIndex;
            PageSize = pageSize;
            IndexFrom = indexFrom;
            TotalCount = enumerable.Count;
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);
            Items = enumerable
                .Skip((PageIndex - IndexFrom) * PageSize)
                .Take(PageSize)
                .ToList();
        }
    }

    internal PagedList() => Items = Array.Empty<TItem>();
}