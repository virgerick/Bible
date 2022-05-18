using System.Threading.Tasks;

namespace Bible.Application.Interfaces.Repositories;

public interface IDocumentRepository
{
    Task<bool> IsDocumentTypeUsed(int documentTypeId);

    Task<bool> IsDocumentExtendedAttributeUsed(int documentExtendedAttributeId);
}