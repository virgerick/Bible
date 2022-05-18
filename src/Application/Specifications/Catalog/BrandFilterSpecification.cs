using Bible.Application.Specifications.Base;
using Bible.Domain.Entities.Catalog;

namespace Bible.Application.Specifications.Catalog;

public class BrandFilterSpecification : Specification<Brand>
{
    public BrandFilterSpecification(string searchString)
    {
        if (!string.IsNullOrEmpty(searchString))
        {
            Criteria = p => p.Name.Contains(searchString) || p.Description.Contains(searchString);
        }
        else
        {
            Criteria = p => true;
        }
    }
}
