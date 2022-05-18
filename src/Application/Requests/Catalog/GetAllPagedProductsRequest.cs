using Virgerick.Bible.Application.Requests;

namespace Bible.Application.Requests.Catalog;

public class GetAllPagedProductsRequest : PagedRequest
{
    public string SearchString { get; set; }
}