using Bible.Application.Requests;

namespace Bible.Application.Interfaces.Services;

public interface IUploadService
{
    string UploadAsync(UploadRequest request);
}