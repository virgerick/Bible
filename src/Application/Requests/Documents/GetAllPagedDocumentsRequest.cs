using Virgerick.Bible.Application.Requests;

namespace Bible.Application.Requests.Documents;

public class GetAllPagedDocumentsRequest : PagedRequest
{
    public string SearchString { get; set; }
}