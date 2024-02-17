using GenericCourses.Infra.Persistence;
using GenericCourses.Domain.Dtos.Pages;
using Microsoft.EntityFrameworkCore;

namespace GenericCourses.Application.Common;

// different name just future change
public class PaginatedLista<t> : List<t>
{
    public int PageIndex { get; private set; }
    public int TotalPages { get; private set; }

    public PaginatedLista(List<t> items, int count, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);

        this.AddRange(items);
    }

    public bool HasPreviousPage => PageIndex > 1;

    public bool HasNextPage => PageIndex < TotalPages;
}
