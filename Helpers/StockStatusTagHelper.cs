using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Agalarla_Web.Helpers
{
    [HtmlTargetElement("stock-status")]
    public class StockStatusTagHelper : TagHelper
    {
        public int Count { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            if (Count <= 0)
            {
                output.Attributes.SetAttribute("class", "badge bg-danger");
                output.Content.SetContent("Tükendi");
            }
            else if (Count < 10)
            {
                output.Attributes.SetAttribute("class", "badge bg-warning text-dark");
                output.Content.SetContent($"Son {Count} ürün!");
            }
            else
            {
                output.Attributes.SetAttribute("class", "badge bg-success");
                output.Content.SetContent("Stokta Var");
            }
        }
    }
}