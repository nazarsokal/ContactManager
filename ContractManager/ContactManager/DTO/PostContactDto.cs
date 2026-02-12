namespace ContactManager.DTO;

public class PostContactDto
{
    public Guid ContactId { get; set; }

    public string Name { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public bool IsMarried { get; set; }
    
    public string Phone { get; set; }
    
    public decimal Salary { get; set; }
}