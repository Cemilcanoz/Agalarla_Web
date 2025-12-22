using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Agalarla_Web.Helpers
{
    public static class PriceHelper
    {
        public static HtmlString DisplayPrice(this IHtmlHelper html, decimal price, string? cssClass = "text-danger fw-bold", string currency = "TL")
        {
            return new HtmlString($"<span class='{cssClass}'>{price:N2} {currency}</span>");
        }
    }
}