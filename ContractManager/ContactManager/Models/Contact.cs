using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManager.Models;

public class Contact
{
    [Key]
    [Column("Id")]
    public Guid ContactId { get; set; }

    public string Name { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public bool IsMarried { get; set; }
    
    public string Phone { get; set; }
    
    public decimal Salary { get; set; }
}