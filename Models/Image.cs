using System.ComponentModel.DataAnnotations;

namespace MyFriends.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public byte[] Img { get; set; }

        [Required]
        public Friend Friend { get; set; }
    }
}
