using Microsoft.AspNetCore.Mvc;

namespace SystemBiblioteczny.Controllers;

[ApiController]
[Route("[controller]")]
public class SearchController : ControllerBase
{
    [HttpPost]
    public SearchResult Post(SearchQuery searchQuery)
    {
        Catalog catalog = new();
        return catalog.Search(searchQuery);
    }
}