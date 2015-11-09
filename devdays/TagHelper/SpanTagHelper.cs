using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.TagHelpers;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;
namespace devdays
{
	[HtmlTargetElement("span", Attributes = AttributeNameConst)]
	public class SpanTagHelper : TagHelper
	{
		private const string AttributeNameConst = "emoji";
		
		[HtmlAttributeName(AttributeNameConst)]
    	public string Emoji { get; set; }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			if (Emoji == "smile")
			{
				output.Attributes.Add("title", "smile");
				output.Content.SetContent(" :) ");
				output.TagMode = TagMode.StartTagAndEndTag;
			}
			else if (Emoji == "sad")
			{
				var childContent = await context.GetChildContentAsync();
				output.Attributes.Add("title", "sad");
				output.Content.Append(childContent.GetContent() + ":'(");
			}
		}
	}
}