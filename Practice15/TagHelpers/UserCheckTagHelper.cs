using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;

namespace Practice15.TagHelpers
{
    public class UserCheckTagHelper : TagHelper
    {
        [HtmlAttributeName("names")]
        public string[] Names { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Names.Contains("lotfi"))
            {
                output.TagName = "p";
                output.Content.SetContent("Hello lotfi");
            }
            else
            {
                output.TagName = "p";
                output.Content.SetContent("By By lotfi");
            }
        }
    }
}
