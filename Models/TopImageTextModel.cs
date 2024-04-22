using System.ComponentModel.DataAnnotations;

namespace VertoTest.Models
{
    public class TopHomeImageTextModel
    {
        public int Id { get; set; }
        public string ImageTitle { get; set; } = string.Empty;
        public string ImageDescription { get; set; } = string.Empty;
    }
}
