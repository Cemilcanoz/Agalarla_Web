using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Agalarla_Web.Helpers
{
    [HtmlTargetElement("product-card")]
    public class ProductCardTagHelper : TagHelper
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "card m-2");
            var imgSection = string.Empty;
            if (!string.IsNullOrEmpty(ImageUrl))
            {
                imgSection = $"<img src=\"{ImageUrl}\" class=\"card-img-top\" alt=\"{Name}\">";
            }

            var stockBadge = Count <= 0 ? "<span class='badge bg-danger'>Tükendi</span>" : Count < 10 ? $"<span class='badge bg-warning text-dark'>Son {Count}</span>" : "<span class='badge bg-success'>Stokta</span>";

            var body = $@"
                {imgSection}
                <div class='card-body'>
                    <h5 class='card-title'>{Name} {stockBadge}</h5>
                    <p class='card-text'>{Description}</p>
                    <p class='card-text'><strong>{Price:N2} TL</strong></p>
                </div>
            ";

            output.Content.SetHtmlContent(body);
        }
    }
}
