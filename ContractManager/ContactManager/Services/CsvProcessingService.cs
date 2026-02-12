using ContactManager.Models;
using ContactManager.ServiceContracts;

namespace ContactManager.Services;

public class CsvProcessingService : ICsvProcessingService
{
    public Task<List<Contact>> ProcessContactsAsync(IFormFile filePassed)
    {
        var file = filePassed.OpenReadStream();
        return null;
    }
}