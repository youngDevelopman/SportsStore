using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SportsStore.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Please enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a product description")]
        public string Description { get; set; }

        [Required]
        [Range(0.1,double.MaxValue,ErrorMessage ="Please enter a positive number")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter a product category")]
        public string Category { get; set; }
    }
}
