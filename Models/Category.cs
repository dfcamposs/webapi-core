using System.ComponentModel.DataAnnotations;

namespace webapi_core.Models
{
  public class Category
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Este campo é obrigatório")]
    [MaxLength(60, ErrorMessage = "Este campo deve conter 3 a 60 caracteres")]
    [MinLength(3, ErrorMessage = "Este campo deve conter 3 a 60 caracteres")]
    public string Title { get; set; }
  }
}