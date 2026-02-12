using System.Globalization;
using ContactManager.DTO;
using ContactManager.Models;
using ContactManager.ServiceContracts;
using CsvHelper;

namespace ContactManager.Services;

public class CsvProcessingService : ICsvProcessingService
{
    public async Task<List<UploadContactDto>> ProcessContactsAsync(IFormFile filePassed)
    {
        using var reader = new StreamReader(filePassed.OpenReadStream());
        
        var csvContent = await reader.ReadToEndAsync();
        using var csv = new CsvReader(new StringReader(csvContent), CultureInfo.InvariantCulture);
        
        var records = csv.GetRecords<UploadContactDto>().ToList();

        return records;
    }
}