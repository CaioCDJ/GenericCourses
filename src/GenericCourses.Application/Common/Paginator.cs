namespace GenericCourses.Application.Common;

// different name just future change
public class PaginatedList<t> : List<t> {
	public int PageIndex { get; private set; }
	public int TotalPages { get; private set; }
	public int TotalItems { get; private set; }

	public PaginatedList(List<t> items, int count, int pageIndex, int pageSize = 8) {
		PageIndex = pageIndex;
		TotalPages = (int) Math.Ceiling(count / (double) pageSize);
		TotalItems = count;
		this.AddRange(items);
	}

	public bool HasPreviousPage => PageIndex > 1;

	public bool HasNextPage => PageIndex < TotalPages;

	public Nav pagination()
		=> new Nav() {
			TotalPages = this.TotalPages,
			PageIndex = this.PageIndex,
			HasNextPage = this.HasNextPage,
			HasPreviousPage = this.HasPreviousPage
		};

}

public class Nav {
	public int TotalPages { get; init; }
	public int PageIndex { get; init; }
	public bool HasPreviousPage { get; init; }
	public bool HasNextPage { get; init; }
}
