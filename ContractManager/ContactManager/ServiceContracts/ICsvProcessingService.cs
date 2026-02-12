using ContactManager.DTO;
using ContactManager.Models;

namespace ContactManager.ServiceContracts;

public interface ICsvProcessingService
{
    Task<List<UploadContactDto>> ProcessContactsAsync(IFormFile file);
}