using System.ComponentModel.DataAnnotations;

namespace Avam.DigiCura.NgOne.UI.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required, MaxLength(50,ErrorMessage ="Name length exceeeds limit")]
        public string Name { get; set; }
        [MaxLength(500, ErrorMessage = "Description length exceeeds limit")]
        public string Description { get; set; }
    }
}