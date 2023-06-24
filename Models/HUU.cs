using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CUONGDB.Models;

public class HUU
{
    [Key]
    [Required(ErrorMessage = "Mã hồ sơ không được để trống !!!")]
    [Display(Name = "MÃ HỒ SƠ")]
    [MaxLength(10)]
    public string? HUUID { get; set; }


    [Required(ErrorMessage = "Tên sản phẩm không được để trống !!!")]
    [Display(Name = "TÊN HỒ SƠ")]
    [MaxLength(10)]
    public string? HUUName { get; set; }
    
    
    [Required(ErrorMessage = "Số điện thoại không được để trống !!!")]
    [Display(Name = "SỐ ĐIỆN THOẠI")]
    [MaxLength(10)]
    public string? HUUSđt { get; set; }

    [Required(ErrorMessage = "Số lượng không được để trống !!!")]
    [Display(Name = "HUU")]
    [MaxLength(10)]
    public string? HUUSL { get; set; }
    
    
}