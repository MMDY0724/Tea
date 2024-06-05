using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TeaTimeDemo.Models
{
    public class Category
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("飲料類別")]
        public string Name { get; set; }
        [DisplayName("價格")]
        [Range(1,150,ErrorMessage ="輸入範圍應該要在1-150之間")]
        public int DisplayOrder { get; set; }
    }
}
