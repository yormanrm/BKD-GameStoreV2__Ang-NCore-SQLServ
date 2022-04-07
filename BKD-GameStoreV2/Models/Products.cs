using System.ComponentModel.DataAnnotations;

namespace BKD_GameStoreV2.Models
{
    public class Products
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public int price { get; set; }

        [Required] 
        public int quantity { get; set; }   

        [Required]
        public string state { get; set; }

        [Required]
        public string platform { get; set; }
        [Required]
        public string subplatform { get; set; }

        [Required]
        public string category { get; set; }

        [Required]
        public string image { get; set; }

    }
}
