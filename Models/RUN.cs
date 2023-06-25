using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CUONGDB.Models;

public class RUN
{
    [Key]
    [Required(ErrorMessage = "Không được để trống!")]
    [Display(Name = "MÃ")]
    [MaxLength(10)]
    public string? RUNID { get; set; }

    [Required(ErrorMessage = "Không được để trống!")]
    [Display(Name = "TÊN")]
    [MaxLength(10)]
    public string? RUNNAME { get; set; }

    [Required(ErrorMessage = "Không được để trống!")]
    [Display(Name = "ĐỊA CHỈ")]
    [MaxLength(10)]
    public string? RUNADDRESS { get; set; }

    [Required(ErrorMessage = "Không được để trống!")]
    [Display(Name = "GIỚI TÍNH")]
    [MaxLength(10)]
    public string? RUNSEX { get; set; }
    public string? FCTID { get; set; }
    [ForeignKey("FCTID")]
    public Faculty? Faculty {get; set;}




}
