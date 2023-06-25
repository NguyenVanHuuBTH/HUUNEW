using System.ComponentModel.DataAnnotations;
namespace CUONGDB.Models;
public class LOPHOC
{
    [Key]
   
    public int? MaLop { get; set; }
   
    public string? TenLop { get; set; }
    
    public string? SoLuong { get; set; }

}