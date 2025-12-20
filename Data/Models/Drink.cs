namespace Agalarla_Web.Models
{
    public class Drink
    {
        public int DrinkId { get; set; } // Birincil anahtar (Primary Key)
        public string Name { get; set; } // İçecek adı
        public string Description { get; set; } //  açıklama
        public decimal Price { get; set; } // Ürün fiyatı
        public string ImageUrl { get; set; } // Büyük resim yolu
        public string ImageThumbnailUrl { get; set; } // Küçük resim (önizleme) yolu
        public bool IsPreferredDrink { get; set; } // Haftanın ürünü mü? (Ana sayfada göstermek için)
        public int InStock { get; set; } // Stok durumu (kaç adet kaldı?)
        public int CategoryId { get; set; } // Foreign Key: Hangi kategoriye ait olduğunu bağlar
        public virtual Category Category { get; set; } // Navigation Property: İlişkili kategori nesnesine ulaşmak için
    }
}
