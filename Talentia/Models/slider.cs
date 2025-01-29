using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Talentia.Models
{
    public class slider
    {
        [Key]
        public int sliderId {  get; set; }
        public string? sliderName { get; set; } = string.Empty;
        public string? Header1 { get; set; } = string.Empty;
        public string? Header2 { get; set; } = string.Empty;
        public string? Context { get; set; } = string.Empty;
        public string? SliderImage { get; set; } = string.Empty;
        [NotMapped]
        public IFormFile? ImageUpload { get; set; }
    }
}
