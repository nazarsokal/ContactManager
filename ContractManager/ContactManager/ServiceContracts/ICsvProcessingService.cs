using ContactManager.Models;

namespace ContactManager.ServiceContracts;

public interface ICsvProcessingService
{
    Task<List<Contact>> ProcessContactsAsync(IFormFile file);
}