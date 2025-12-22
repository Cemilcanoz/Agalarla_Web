using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Agalarla_Web.Helpers
{
    [HtmlTargetElement("discount-price")]
    public class DiscountTagHelper : TagHelper
    {
        public double Price { get; set; }
        public int Percent { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var discounted = Price * (1 - Percent / 100.0);
            var html = $"<span class='text-muted text-decoration-line-through'>{Price:N2} TL</span> <span class='fw-bold text-danger ms-2'>{discounted:N2} TL</span>";
            output.Content.SetHtmlContent(html);
        }
    }
}
