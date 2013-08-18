using System.Web;
using System.Web.Mvc;
using Cervezas.Models;

namespace Cervezas.Helpers
{
    public static class Extensions
    {
        public static IHtmlString Favicon(this HtmlHelper html, Site site, int height = 16, int width = 16)
        {
            return html.Img(site.FaviconUrl, site.DomainName, height, width);
        }

        public static IHtmlString Img(this HtmlHelper html, string imageSource, string alt, int height, int width)
        {
            var builder = new TagBuilder("img");

            builder.MergeAttribute("src", imageSource);
            builder.MergeAttribute("alt", alt);
            builder.MergeAttribute("height", height.ToString());
            builder.MergeAttribute("width", width.ToString());
            builder.AddCssClass("site-favicon");

            return new HtmlString(builder.ToString());
        }
    }
}