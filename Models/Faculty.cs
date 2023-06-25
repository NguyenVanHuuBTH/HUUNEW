using System.ComponentModel.DataAnnotations;

namespace CUONGDB.Models;

public class Faculty
{
    [Key]
    public string? FCTID { get; set; }
    public string? FCTName { get; set; }
    
}
