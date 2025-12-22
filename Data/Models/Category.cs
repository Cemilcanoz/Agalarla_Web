namespace Agalarla_Web.Models
{
    public class Category
    {
        public int CategoryId { get; set; } // Kategori ID
        public string CategoryName { get; set; } // Örn: Alkollü, Alkolsüz, Sıcak İçecekler
        public string Description { get; set; } // Kategori açıklaması
        public List<Drink> Drinks { get; set; } // Bire-Çok ilişki: Bu kategorideki tüm içeceklerin listesi
    }
}
