using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Kategori adı zorunludur.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Kategori ismi için 5-100 arası karakter giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Url zorunludur.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Kategori url için 5-100 arası karakter giriniz.")]
        public string Url { get; set; }
        public List<Product> Products { get; set; }
    }
}