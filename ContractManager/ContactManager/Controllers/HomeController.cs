using System.Diagnostics;
using ContactManager.Models;
using ContactManager.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers;

public class HomeController : Controller
{
    private readonly ICsvProcessingService _csvProcessingService;
    private readonly IContactService _contactService;
    public HomeController(ICsvProcessingService csvProcessingService, IContactService contactService)
    {
        _csvProcessingService = csvProcessingService;
        _contactService = contactService;
    }

    public async Task<IActionResult> Index()
    {
        var contacts = await _contactService.GetAllContactsAsync();
        
        return View(contacts);
    }

    [Route("upload")]
    [HttpPost]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        var processedContacts = await _csvProcessingService.ProcessContactsAsync(file);
        
        return View(processedContacts);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}