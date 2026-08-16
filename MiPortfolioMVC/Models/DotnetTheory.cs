using System.ComponentModel.DataAnnotations;

namespace MiPortfolioMVC.Models
{
    public class DotnetTheory
    {
        [Required, StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required, StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;
    }
}