using Agalarla_Web.Models;

namespace Agalarla_Web.Data.Interfaces
{
    public interface IDrinkRepository
    {
        // Tüm içecekleri liste olarak döndürür
        IEnumerable<Drink> Drinks { get; }

        // Sadece IsPreferredDrink değeri true olan (öne çıkan) içecekleri getirir
        IEnumerable<Drink> PreferredDrinks { get; }

        // ID numarasına göre tek bir içeceğin bilgisini getirir
        Drink GetDrinkById(int drinkId);
    }
}
