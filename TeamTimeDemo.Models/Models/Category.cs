using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeamTimeDemo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("類別名稱")]
        [StringLength(10, ErrorMessage = "類別名稱不能超過 10 個字元")]
        public string Name { get; set; }
        [DisplayName("顯示順序")]
        [Range(1, 100, ErrorMessage = "顯示順序必須介於 1 到 100 之間")]
        public int DisplayOrder { get; set; }
        [DisplayName("類別描述")]
        [StringLength(100, ErrorMessage = "類別描述不能超過 100 個字元")]
        public string Description { get; set; }
    }
}
