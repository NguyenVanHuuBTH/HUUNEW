using System.ComponentModel.DataAnnotations;
namespace CUONGDB.Models;
public class LOPHOC
{
    [Key]
    [MaxLength((20))]
    public int? MaLop { get; set; }
    [MaxLength((50))]
    public string? TenLop { get; set; }
    public string? SoLuong { get; set; }

}