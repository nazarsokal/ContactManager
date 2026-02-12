using ContactManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Context;

public class ContactDbContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
}