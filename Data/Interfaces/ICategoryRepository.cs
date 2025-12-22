using Agalarla_Web.Models;

namespace Agalarla_Web.Data.Interfaces
{
    public interface ICategoryRepository
    {
        // Sistemdeki tüm kategorileri (Alkollü, Alkolsüz vb.) getirmek için kullanılır
        IEnumerable<Category> Categories { get; }
    }
}
