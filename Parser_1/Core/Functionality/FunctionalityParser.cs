using AngleSharp.Html.Dom;
using System.Collections.Generic;

namespace Parser_1.Core.Functionality
{
    class FunctionalityParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            //var items = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("value"));
            var items = document.QuerySelectorAll("tr");

            
            foreach (var item in items)
            {



                list.Add(item.FirstChild.TextContent);
                list.Add(item.Children[1].TextContent);
                // else continue;
            }
            return list.ToArray();
        }
    }
}
